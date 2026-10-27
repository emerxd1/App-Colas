using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ArbolVisual
{
    public enum TipoRecorrido { InOrden, PreOrden, PostOrden, PorNiveles }

    public class NodoArbol
    {
        public int Valor;
        public NodoArbol Izq, Der;
        public NodoArbol(int valor) { Valor = valor; }
    }

    /// <summary>Paleta tomada de la imagen de referencia.</summary>
    public static class Paleta
    {
        public static readonly Color Fondo       = ColorTranslator.FromHtml("#EEF3F0");
        public static readonly Color Tarjeta     = ColorTranslator.FromHtml("#F7FAF8");
        public static readonly Color Puntos      = ColorTranslator.FromHtml("#D3DCD7");
        public static readonly Color Raiz        = ColorTranslator.FromHtml("#0B3D2E");
        public static readonly Color NodoBorde   = ColorTranslator.FromHtml("#1F7A5C");
        public static readonly Color Texto       = ColorTranslator.FromHtml("#0B3D2E");
        public static readonly Color TextoSuave  = ColorTranslator.FromHtml("#5F6F68");
        public static readonly Color Arista      = ColorTranslator.FromHtml("#A3B8AE");
        public static readonly Color Encontrado  = ColorTranslator.FromHtml("#F2A03D");
        public static readonly Color EncontradoB = ColorTranslator.FromHtml("#D98A1F");
        public static readonly Color Chip        = ColorTranslator.FromHtml("#E1EFE7");
        public static readonly Color Borde       = ColorTranslator.FromHtml("#DCE5E0");
    }

    /// <summary>
    /// Control que dibuja un árbol binario de búsqueda y, debajo, el recorrido
    /// en cuadritos. Se redibuja solo cada vez que cambias los datos.
    /// </summary>
    public class ArbolBinarioView : Control
    {
        NodoArbol _raiz;
        int? _encontrado;
        TipoRecorrido _recorrido = TipoRecorrido.InOrden;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float NodoRadio { get; set; } = 26f;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TipoRecorrido Recorrido
        {
            get { return _recorrido; }
            set { _recorrido = value; Invalidate(); }
        }

        public int Cantidad { get; private set; }

        public ArbolBinarioView()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Paleta.Fondo;
            Font = new Font("Segoe UI", 10f);
            MinimumSize = new Size(420, 360);
        }

        // ======================= LÓGICA DEL ÁRBOL =======================

        /// <summary>Inserta un valor. Devuelve false si ya existía.</summary>
        public bool Insertar(int valor)
        {
            if (_raiz == null) { _raiz = new NodoArbol(valor); Cantidad = 1; Invalidate(); return true; }
            var actual = _raiz;
            while (true)
            {
                if (valor == actual.Valor) return false;
                if (valor < actual.Valor)
                {
                    if (actual.Izq == null) { actual.Izq = new NodoArbol(valor); break; }
                    actual = actual.Izq;
                }
                else
                {
                    if (actual.Der == null) { actual.Der = new NodoArbol(valor); break; }
                    actual = actual.Der;
                }
            }
            Cantidad++;
            Invalidate();
            return true;
        }

        /// <summary>Busca el valor y lo resalta en naranja. Devuelve si existe.</summary>
        public bool Buscar(int valor)
        {
            var n = _raiz;
            while (n != null && n.Valor != valor)
                n = valor < n.Valor ? n.Izq : n.Der;
            _encontrado = n != null ? (int?)valor : null;
            Invalidate();
            return n != null;
        }

        public void QuitarResaltado() { _encontrado = null; Invalidate(); }

        public bool Eliminar(int valor)
        {
            bool ok = false;
            _raiz = EliminarRec(_raiz, valor, ref ok);
            if (ok) { Cantidad--; if (_encontrado == valor) _encontrado = null; Invalidate(); }
            return ok;
        }

        NodoArbol EliminarRec(NodoArbol n, int v, ref bool ok)
        {
            if (n == null) return null;
            if (v < n.Valor) n.Izq = EliminarRec(n.Izq, v, ref ok);
            else if (v > n.Valor) n.Der = EliminarRec(n.Der, v, ref ok);
            else
            {
                ok = true;
                if (n.Izq == null) return n.Der;
                if (n.Der == null) return n.Izq;
                var s = n.Der;
                while (s.Izq != null) s = s.Izq;
                n.Valor = s.Valor;
                bool dummy = false;
                n.Der = EliminarRec(n.Der, s.Valor, ref dummy);
            }
            return n;
        }

        public void Limpiar()
        {
            _raiz = null; _encontrado = null; Cantidad = 0;
            Invalidate();
        }

        public List<int> ObtenerRecorrido()
        {
            var r = new List<int>();
            switch (_recorrido)
            {
                case TipoRecorrido.InOrden:    In(_raiz, r); break;
                case TipoRecorrido.PreOrden:   Pre(_raiz, r); break;
                case TipoRecorrido.PostOrden:  Post(_raiz, r); break;
                case TipoRecorrido.PorNiveles: Niveles(r); break;
            }
            return r;
        }

        static void In(NodoArbol n, List<int> r)   { if (n == null) return; In(n.Izq, r); r.Add(n.Valor); In(n.Der, r); }
        static void Pre(NodoArbol n, List<int> r)  { if (n == null) return; r.Add(n.Valor); Pre(n.Izq, r); Pre(n.Der, r); }
        static void Post(NodoArbol n, List<int> r) { if (n == null) return; Post(n.Izq, r); Post(n.Der, r); r.Add(n.Valor); }
        void Niveles(List<int> r)
        {
            if (_raiz == null) return;
            var q = new Queue<NodoArbol>();
            q.Enqueue(_raiz);
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                r.Add(n.Valor);
                if (n.Izq != null) q.Enqueue(n.Izq);
                if (n.Der != null) q.Enqueue(n.Der);
            }
        }

        static string NombreRecorrido(TipoRecorrido t)
        {
            switch (t)
            {
                case TipoRecorrido.InOrden:    return "InOrden";
                case TipoRecorrido.PreOrden:   return "PreOrden";
                case TipoRecorrido.PostOrden:  return "PostOrden";
                default:                       return "Por niveles";
            }
        }

        // ======================= DIBUJO =======================

        const int Pad = 12;
        const int ChipW = 46, ChipH = 40, Sep = 30, ChipsX = 170;

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(Paleta.Fondo);

            var valores = ObtenerRecorrido();

            // ---- tamaño del panel de resultados (puede ocupar varias filas) ----
            int disponible = Width - Pad * 2 - ChipsX - 16;
            int porFila = Math.Max(1, (disponible + Sep) / (ChipW + Sep));
            int filas = Math.Max(1, (int)Math.Ceiling(valores.Count / (double)porFila));
            int resH = Math.Max(76, 28 + filas * (ChipH + 10));
            resH = Math.Min(resH, Math.Max(76, Height / 2));

            var rectArbol = new Rectangle(Pad, Pad, Width - Pad * 2, Height - resH - Pad * 3);
            var rectRes = new Rectangle(Pad, rectArbol.Bottom + Pad, Width - Pad * 2, resH);

            DibujarArbol(g, rectArbol);
            DibujarResultado(g, rectRes, valores, porFila);
        }

        void DibujarArbol(Graphics g, Rectangle r)
        {
            // tarjeta con puntitos
            using (var path = Redondeado(r, 22))
            {
                using (var b = new SolidBrush(Paleta.Tarjeta)) g.FillPath(b, path);
                var clip = g.Clip;
                g.SetClip(path, CombineMode.Intersect);
                using (var b = new SolidBrush(Paleta.Puntos))
                    for (int x = r.X + 14; x < r.Right; x += 24)
                        for (int y = r.Y + 14; y < r.Bottom; y += 24)
                            g.FillEllipse(b, x, y, 2.2f, 2.2f);
                g.Clip = clip;
                using (var p = new Pen(Paleta.Borde)) g.DrawPath(p, path);
            }

            using (var f = new Font("Segoe UI Semibold", 8.5f))
            using (var b = new SolidBrush(Paleta.TextoSuave))
                g.DrawString("VISTA DEL ÁRBOL", f, b, r.X + 26, r.Y + 14);

            DibujarLeyenda(g, r);

            if (_raiz == null)
            {
                using (var f = new Font("Segoe UI", 11f))
                using (var b = new SolidBrush(Paleta.TextoSuave))
                {
                    var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString("Inserta un valor para comenzar", f, b, r, sf);
                }
                return;
            }

            // ---- posiciones: X = orden inorden, Y = nivel ----
            var pos = new Dictionary<NodoArbol, Point>();
            int idx = 0, niveles = 0;
            Posicionar(_raiz, 0, ref idx, ref niveles, pos);
            int n = idx;

            float izquierda = r.X + 120, derecha = r.Right - 40;
            float ancho = derecha - izquierda;
            float sep = Math.Min(ancho / n, 130f);
            float inicio = izquierda + (ancho - sep * n) / 2f + sep / 2f;
            float radio = Math.Max(11f, Math.Min(NodoRadio, sep * 0.4f));

            float y0 = r.Y + 100;
            float altoNivel = niveles > 1 ? Math.Min(145f, (r.Height - 100 - 50) / (float)(niveles - 1)) : 0;
            altoNivel = Math.Max(altoNivel, 40f);

            Func<NodoArbol, PointF> centro = nodo =>
                new PointF(inicio + pos[nodo].X * sep, y0 + pos[nodo].Y * altoNivel);

            // etiquetas de nivel
            using (var f = new Font("Segoe UI Semibold", 8.5f))
            using (var b = new SolidBrush(Paleta.TextoSuave))
            {
                var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                for (int d = 0; d < niveles; d++)
                    g.DrawString("NIVEL " + d, f, b, r.X + 26, y0 + d * altoNivel, sf);
            }

            // aristas
            using (var p = new Pen(Paleta.Arista, 3.2f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
                foreach (var kv in pos)
                {
                    var c = centro(kv.Key);
                    if (kv.Key.Izq != null) g.DrawLine(p, c, centro(kv.Key.Izq));
                    if (kv.Key.Der != null) g.DrawLine(p, c, centro(kv.Key.Der));
                }

            // nodos
            float tam = Math.Max(9f, radio * 0.62f);
            using (var f = new Font("Segoe UI", tam, FontStyle.Bold, GraphicsUnit.Point))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                foreach (var kv in pos)
                    DibujarNodo(g, kv.Key, centro(kv.Key), radio, f, sf);
            }
        }

        void DibujarNodo(Graphics g, NodoArbol nodo, PointF c, float radio, Font f, StringFormat sf)
        {
            bool esRaiz = nodo == _raiz;
            bool hallado = _encontrado.HasValue && _encontrado.Value == nodo.Valor;

            var rect = new RectangleF(c.X - radio, c.Y - radio, radio * 2, radio * 2);
            Color relleno, borde, texto;
            if (hallado)    { relleno = Paleta.Encontrado; borde = Paleta.EncontradoB; texto = Paleta.Texto; }
            else if (esRaiz){ relleno = Paleta.Raiz;       borde = Paleta.Raiz;        texto = Color.White; }
            else            { relleno = Color.White;       borde = Paleta.NodoBorde;   texto = Paleta.Texto; }

            using (var b = new SolidBrush(relleno)) g.FillEllipse(b, rect);
            using (var p = new Pen(borde, 3.2f)) g.DrawEllipse(p, rect);
            using (var b = new SolidBrush(texto)) g.DrawString(nodo.Valor.ToString(), f, b, rect, sf);
        }

        static void Posicionar(NodoArbol n, int nivel, ref int idx, ref int niveles, Dictionary<NodoArbol, Point> pos)
        {
            if (n == null) return;
            Posicionar(n.Izq, nivel + 1, ref idx, ref niveles, pos);
            pos[n] = new Point(idx++, nivel);
            if (nivel + 1 > niveles) niveles = nivel + 1;
            Posicionar(n.Der, nivel + 1, ref idx, ref niveles, pos);
        }

        void DibujarLeyenda(Graphics g, Rectangle r)
        {
            using (var f = new Font("Segoe UI", 9.5f))
            {
                string[] textos = { "Raíz", "Nodo", "Encontrado" };
                float ancho = 24;
                foreach (var t in textos) ancho += 14 + 8 + g.MeasureString(t, f).Width + 16;

                var pill = new Rectangle((int)(r.Right - ancho - 16), r.Y + 12, (int)ancho, 38);
                using (var path = Redondeado(pill, 19))
                {
                    using (var b = new SolidBrush(Color.White)) g.FillPath(b, path);
                    using (var p = new Pen(Paleta.Borde)) g.DrawPath(p, path);
                }

                float x = pill.X + 18, cy = pill.Y + pill.Height / 2f;
                for (int i = 0; i < 3; i++)
                {
                    var dot = new RectangleF(x, cy - 7, 14, 14);
                    if (i == 0) using (var b = new SolidBrush(Paleta.Raiz)) g.FillEllipse(b, dot);
                    if (i == 1) using (var p = new Pen(Paleta.NodoBorde, 2.2f)) g.DrawEllipse(p, dot.X + 1, dot.Y + 1, 12, 12);
                    if (i == 2) using (var b = new SolidBrush(Paleta.Encontrado)) g.FillEllipse(b, dot);
                    x += 14 + 8;
                    var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                    using (var b = new SolidBrush(Paleta.Texto)) g.DrawString(textos[i], f, b, x, cy, sf);
                    x += g.MeasureString(textos[i], f).Width + 16;
                }
            }
        }

        void DibujarResultado(Graphics g, Rectangle r, List<int> valores, int porFila)
        {
            using (var path = Redondeado(r, 22))
            {
                using (var b = new SolidBrush(Color.White)) g.FillPath(b, path);
                using (var p = new Pen(Paleta.Borde)) g.DrawPath(p, path);
            }

            using (var f = new Font("Segoe UI Semibold", 8.5f))
            using (var b = new SolidBrush(Paleta.TextoSuave))
                g.DrawString("RESULTADO", f, b, r.X + 26, r.Y + 18);
            using (var f = new Font("Segoe UI", 11.5f, FontStyle.Bold))
            using (var b = new SolidBrush(Paleta.Texto))
                g.DrawString(NombreRecorrido(_recorrido), f, b, r.X + 26, r.Y + 36);

            using (var f = new Font("Segoe UI", 11f, FontStyle.Bold))
            using (var fc = new Font("Segoe UI", 11f))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                for (int i = 0; i < valores.Count; i++)
                {
                    int fila = i / porFila, col = i % porFila;
                    int x = r.X + ChipsX + col * (ChipW + Sep);
                    int y = r.Y + 14 + fila * (ChipH + 10);
                    var chip = new Rectangle(x, y, ChipW, ChipH);

                    bool hallado = _encontrado.HasValue && _encontrado.Value == valores[i];
                    using (var path = Redondeado(chip, 12))
                    using (var b = new SolidBrush(hallado ? Paleta.Encontrado : Paleta.Chip))
                        g.FillPath(b, path);
                    using (var b = new SolidBrush(Paleta.Texto))
                        g.DrawString(valores[i].ToString(), f, b, chip, sf);

                    if (i < valores.Count - 1 && col < porFila - 1)
                        using (var b = new SolidBrush(Paleta.TextoSuave))
                            g.DrawString(">", fc, b, new Rectangle(chip.Right, y, Sep, ChipH), sf);
                }
            }
        }

        static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
