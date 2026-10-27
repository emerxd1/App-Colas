using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Ejercicio5 : Form
    {
        private readonly CirculoJugadores _circulo;
        private bool _cerrando;

        public Ejercicio5()
        {
            InitializeComponent();

            // Control grafico dentro del panel "Circulo de jugadores"
            _circulo = new CirculoJugadores
            {
                Location = new Point(10, 36),
                Size = new Size(pnlDraw.Width - 20, pnlDraw.Height - 46)
            };
            pnlDraw.Controls.Add(_circulo);

            btnAdd.Click += (s, e) => AgregarParticipante();
            btnDelete.Click += (s, e) => EliminarParticipante();
            btnBegin.Click += btnBegin_Click;
            txtElementos.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    AgregarParticipante();
                }
            };
            FormClosing += (s, e) => _cerrando = true;

            RefrescarVista();
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }

        // ---------- Participantes ----------

        private List<string> ObtenerNombres()
        {
            return uiListBox1.Items.Cast<object>().Select(o => o.ToString()).ToList();
        }

        private void RefrescarVista()
        {
            _circulo.Mostrar(ObtenerNombres());
            rtbLeyenda.Text = "";
            uiRichTextBox1.Text = "";
        }

        private void AgregarParticipante()
        {
            string nombre = (txtElementos.Text ?? "").Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Escriba el nombre del participante.", "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ObtenerNombres().Any(x => string.Equals(x, nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ese participante ya existe.", "Dato repetido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uiListBox1.Items.Add(nombre);
            txtElementos.Text = "";
            RefrescarVista();
        }

        private void EliminarParticipante()
        {
            int idx = uiListBox1.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Seleccione un participante de la lista.", "Sin seleccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            uiListBox1.Items.RemoveAt(idx);
            RefrescarVista();
        }

        // ---------- Juego ----------

        /// <summary>
        /// Version "pura" del ejercicio: devuelve el nombre de la ganadora.
        /// La papa la tiene siempre el primero de la cola: pasar = sacar del frente y
        /// mandarlo al final; tras n pases, quien queda al frente sale.
        /// </summary>
        public static string PapaCaliente(List<string> nombres, int n)
        {
            var cola = new Queue<string>(nombres);
            while (cola.Count > 1)
            {
                for (int i = 0; i < n % cola.Count; i++)
                    cola.Enqueue(cola.Dequeue());
                cola.Dequeue(); // sale quien tiene la papa
            }
            return cola.Dequeue();
        }

        private void Bloquear(bool bloquear)
        {
            btnBegin.Enabled = !bloquear;
            btnAdd.Enabled = !bloquear;
            btnDelete.Enabled = !bloquear;
            txtN.Enabled = !bloquear;
            txtElementos.Enabled = !bloquear;
            uiListBox1.Enabled = !bloquear;
        }

        private async void btnBegin_Click(object sender, EventArgs e)
        {
            List<string> nombres = ObtenerNombres();

            if (nombres.Count < 2)
            {
                MessageBox.Show("Agregue al menos 2 participantes.", "Faltan participantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Los pases por ronda deben ser un entero mayor que 0.", "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bloquear(true);
            try
            {
                _circulo.Mostrar(nombres);
                rtbLeyenda.Text = "";
                uiRichTextBox1.Text = "";

                // La cola guarda posiciones (asi funciona aunque haya nombres iguales)
                var cola = new Queue<int>(Enumerable.Range(0, nombres.Count));
                int orden = 0;

                _circulo.Holder = cola.Peek();
                _circulo.Estado = "Empieza " + nombres[cola.Peek()];
                await Task.Delay(700);
                if (_cerrando) return;

                while (cola.Count > 1)
                {
                    // n pases (n % tamano da el mismo resultado y evita vueltas inutiles)
                    int pases = n % cola.Count;
                    for (int i = 0; i < pases; i++)
                    {
                        cola.Enqueue(cola.Dequeue());
                        _circulo.Holder = cola.Peek();
                        _circulo.Estado = "Pase " + (i + 1) + " de " + pases;
                        await Task.Delay(350);
                        if (_cerrando) return;
                    }

                    // Sale quien tiene la papa
                    int sale = cola.Dequeue();
                    orden++;
                    _circulo.Eliminar(sale);
                    _circulo.Estado = "Sale " + nombres[sale];
                    rtbLeyenda.Text += (orden > 1 ? Environment.NewLine : "") + orden + ". " + nombres[sale];
                    await Task.Delay(700);
                    if (_cerrando) return;

                    _circulo.Holder = cola.Peek();
                }

                int ganadora = cola.Dequeue();
                _circulo.Holder = -1;
                _circulo.Ganador = ganadora;
                _circulo.Estado = "Ganadora: " + nombres[ganadora];
                uiRichTextBox1.Text = "Ganadora: " + nombres[ganadora];
            }
            finally
            {
                if (!_cerrando) Bloquear(false);
            }
        }
    }

    /// <summary>
    /// Dibuja a los jugadores sentados en circulo. Resalta quien tiene la papa,
    /// atenua a los eliminados y marca a la ganadora.
    /// </summary>
    public class CirculoJugadores : Control
    {
        private List<string> _nombres = new List<string>();
        private readonly HashSet<int> _eliminados = new HashSet<int>();
        private int _holder = -1;
        private int _ganador = -1;
        private string _estado = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Holder { get { return _holder; } set { _holder = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Ganador { get { return _ganador; } set { _ganador = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Estado { get { return _estado; } set { _estado = value ?? ""; Invalidate(); } }

        public CirculoJugadores()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.Transparent;
        }

        public void Mostrar(IEnumerable<string> nombres)
        {
            _nombres = nombres.ToList();
            _eliminados.Clear();
            _holder = -1;
            _ganador = -1;
            _estado = "";
            Invalidate();
        }

        public void Eliminar(int indice)
        {
            _eliminados.Add(indice);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (var centro = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.NoWrap
            })
            {
                int n = _nombres.Count;
                if (n == 0)
                {
                    using (var f = new Font(Font.FontFamily, 10f, FontStyle.Italic))
                    using (var b = new SolidBrush(Color.FromArgb(120, 134, 155)))
                        g.DrawString("Agregue participantes", f, b, ClientRectangle, centro);
                    return;
                }

                float cx = Width / 2f;
                float cy = Height / 2f;
                float lado = Math.Min(Width, Height);
                float radioNodo = n == 1 ? 32f : Math.Max(12f, Math.Min(32f, lado * 0.5f * (float)Math.Sin(Math.PI / n) * 0.62f));
                float radio = lado / 2f - radioNodo - 18f;
                if (radio < 20f) radio = 20f;

                // Anillo guia
                using (var pen = new Pen(Color.FromArgb(214, 224, 235), 2f) { DashStyle = DashStyle.Dash })
                    g.DrawEllipse(pen, cx - radio, cy - radio, radio * 2, radio * 2);

                float tamFuente = Math.Max(7f, Math.Min(10.5f, radioNodo * 0.34f));
                using (var fuenteNodo = new Font(Font.FontFamily, tamFuente, FontStyle.Bold))
                {
                    for (int i = 0; i < n; i++)
                    {
                        double ang = -Math.PI / 2 + 2 * Math.PI * i / n;
                        float x = cx + radio * (float)Math.Cos(ang);
                        float y = cy + radio * (float)Math.Sin(ang);
                        var caja = new RectangleF(x - radioNodo, y - radioNodo, radioNodo * 2, radioNodo * 2);

                        bool eliminado = _eliminados.Contains(i);
                        bool tienePapa = i == _holder && !eliminado;
                        bool ganadora = i == _ganador;

                        Color baseColor = ganadora ? Color.FromArgb(245, 158, 11)
                                        : eliminado ? Color.FromArgb(203, 213, 225)
                                        : tienePapa ? Color.FromArgb(234, 88, 12)
                                        : Color.FromArgb(22, 94, 85);

                        // Halo para quien tiene la papa o gana
                        if (tienePapa || ganadora)
                        {
                            var halo = RectangleF.Inflate(caja, 7, 7);
                            using (var b = new SolidBrush(Color.FromArgb(60, baseColor)))
                                g.FillEllipse(b, halo);
                        }

                        // Sombra suave
                        if (!eliminado)
                        {
                            var sombra = caja;
                            sombra.Offset(0, 3);
                            using (var b = new SolidBrush(Color.FromArgb(28, 0, 0, 0)))
                                g.FillEllipse(b, sombra);
                        }

                        // Nodo con degradado
                        using (var deg = new LinearGradientBrush(caja,
                                   Mezclar(baseColor, Color.White, 0.2f),
                                   Mezclar(baseColor, Color.Black, 0.12f), 90f))
                        using (var borde = new Pen(Color.FromArgb(110, 255, 255, 255), 1.5f))
                        {
                            g.FillEllipse(deg, caja);
                            g.DrawEllipse(borde, caja);
                        }

                        // Nombre
                        Color colorTexto = eliminado ? Color.FromArgb(120, 134, 155) : Color.White;
                        using (var b = new SolidBrush(colorTexto))
                            g.DrawString(_nombres[i], fuenteNodo, b, RectangleF.Inflate(caja, -2, 0), centro);

                        // Tachado para eliminados
                        if (eliminado)
                        {
                            using (var pen = new Pen(Color.FromArgb(148, 163, 184), 2f))
                            {
                                float d = radioNodo * 0.55f;
                                g.DrawLine(pen, x - d, y - d, x + d, y + d);
                                g.DrawLine(pen, x - d, y + d, x + d, y - d);
                            }
                        }

                        // La papa, hacia el centro del circulo
                        if (tienePapa)
                        {
                            float px = x + (cx - x) * ((radioNodo + 16f) / radio);
                            float py = y + (cy - y) * ((radioNodo + 16f) / radio);
                            DibujarPapa(g, px, py);
                        }
                    }
                }

                // Texto de estado en el centro
                if (_estado.Length > 0)
                {
                    float w = Math.Max(60f, radio * 1.5f);
                    var zona = new RectangleF(cx - w / 2f, cy - 24f, w, 48f);
                    using (var f = new Font(Font.FontFamily, 11f, FontStyle.Bold))
                    using (var b = new SolidBrush(Color.FromArgb(22, 94, 85)))
                    using (var wrap = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center,
                        Trimming = StringTrimming.EllipsisWord
                    })
                        g.DrawString(_estado, f, b, zona, wrap);
                }
            }
        }

        private static void DibujarPapa(Graphics g, float x, float y)
        {
            var r = new RectangleF(x - 11, y - 8, 22, 16);
            using (var b = new SolidBrush(Color.FromArgb(190, 120, 55)))
            using (var borde = new Pen(Color.FromArgb(120, 70, 30), 1.5f))
            using (var punto = new SolidBrush(Color.FromArgb(120, 70, 30)))
            {
                g.FillEllipse(b, r);
                g.DrawEllipse(borde, r);
                g.FillEllipse(punto, x - 5, y - 3, 3, 3);
                g.FillEllipse(punto, x + 2, y + 1, 3, 3);
            }
        }

        private static Color Mezclar(Color a, Color b, float t)
        {
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * t),
                (int)(a.G + (b.G - a.G) * t),
                (int)(a.B + (b.B - a.B) * t));
        }
    }
}