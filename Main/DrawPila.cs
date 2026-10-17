using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
    public class PilaVisual : Control
    {
        // Datos a dibujar: índice 0 = fondo, último = tope.
        private List<string> datos = new List<string>();

        // Cantidad máxima de elementos de la pila (define la altura).
        private int capacidad = 5;

        // Texto que se dibuja centrado debajo de la pila.
        private string leyenda = "";

        // Medidas fijas de la pila.
        private int anchoPila = 120;
        private int espacioLeyenda = 40;
        private int margenInterno = 10;
        private int altoBloqueMaximo = 34;

        // Si es true, el borde se dibuja punteado (pila auxiliar).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Punteado { get; set; }

        // Capacidad de la pila. Al cambiarla se recalcula el dibujo.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Capacidad
        {
            get
            {
                return capacidad;
            }
            set
            {
                if (value < 1)
                {
                    capacidad = 1;
                }
                else
                {
                    capacidad = value;
                }
                Invalidate();
            }
        }

        // Texto de la leyenda. Al cambiarlo se vuelve a dibujar.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Leyenda
        {
            get
            {
                return leyenda;
            }
            set
            {
                leyenda = value;
                Invalidate();
            }
        }

        public PilaVisual()
        {
            DoubleBuffered = true;

            // Al cambiar de tamaño el control se redibuja y la pila se recentra sola.
            ResizeRedraw = true;

            Size = new Size(300, 300);
        }

        // Recibe los datos desde el formulario y se repinta.
        public void Establecer(string[] nuevos)
        {
            datos = new List<string>(nuevos);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Separación entre bloques: más pequeña si hay muchos.
            int separacion = 6;
            if (capacidad > 10)
            {
                separacion = 2;
            }

            // ---------- Altura de la pila según la capacidad ----------

            // Alto que ocupa la pila si todos los bloques tuvieran su tamaño máximo.
            int altoIdeal = 2 * margenInterno
                          + capacidad * altoBloqueMaximo
                          + (capacidad - 1) * separacion;

            // Alto que realmente hay libre en el control.
            int altoDisponible = Height - espacioLeyenda - 10;

            // La pila usa el ideal, pero nunca más de lo que hay disponible.
            int altoPila = altoIdeal;
            if (altoPila > altoDisponible)
            {
                altoPila = altoDisponible;
            }
            if (altoPila < 80)
            {
                altoPila = 80;
            }

            // ---------- Alto de cada bloque ----------

            // Se reparte el espacio interior entre todos los bloques posibles.
            int espacioInterior = altoPila - 2 * margenInterno - (capacidad - 1) * separacion;
            int altoBloque = espacioInterior / capacidad;

            if (altoBloque > altoBloqueMaximo)
            {
                altoBloque = altoBloqueMaximo;
            }
            if (altoBloque < 6)
            {
                altoBloque = 6;
            }

            // ---------- Posición centrada ----------

            // Se reparte el espacio sobrante a ambos lados: eso la centra.
            int x = (Width - anchoPila) / 2;
            int y = (altoDisponible - altoPila) / 2;
            if (y < 5)
            {
                y = 5;
            }

            Rectangle borde = new Rectangle(x, y, anchoPila, altoPila);

            DibujarBorde(g, borde);
            DibujarBloques(g, borde, altoBloque, separacion);
            DibujarLeyenda(g, borde);
        }

        // ---------- Borde en forma de U ----------
        private void DibujarBorde(Graphics g, Rectangle borde)
        {
            int r = 14;

            using (GraphicsPath u = new GraphicsPath())
            {
                u.AddLine(borde.Left, borde.Top, borde.Left, borde.Bottom - r);
                u.AddArc(borde.Left, borde.Bottom - 2 * r, 2 * r, 2 * r, 180, -90);
                u.AddLine(borde.Left + r, borde.Bottom, borde.Right - r, borde.Bottom);
                u.AddArc(borde.Right - 2 * r, borde.Bottom - 2 * r, 2 * r, 2 * r, 90, -90);
                u.AddLine(borde.Right, borde.Bottom - r, borde.Right, borde.Top);

                using (Pen lapiz = new Pen(Color.Gray, 2))
                {
                    if (Punteado)
                    {
                        lapiz.DashStyle = DashStyle.Dash;
                    }
                    g.DrawPath(lapiz, u);
                }
            }
        }

        // ---------- Bloques ----------
        private void DibujarBloques(Graphics g, Rectangle borde, int altoBloque, int separacion)
        {
            // El tamaño de la letra baja junto con el alto del bloque.
            float tamanoLetra = altoBloque * 0.4f;
            if (tamanoLetra > 12f)
            {
                tamanoLetra = 12f;
            }
            if (tamanoLetra < 6f)
            {
                tamanoLetra = 6f;
            }

            // Radio de las esquinas: más pequeño si el bloque es bajo.
            int radio = 6;
            if (altoBloque < 16)
            {
                radio = 3;
            }

            using (Font fuente = new Font("Segoe UI", tamanoLetra, FontStyle.Bold))
            using (StringFormat formato = new StringFormat())
            {
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;

                for (int i = 0; i < datos.Count; i++)
                {
                    bool esTope = (i == datos.Count - 1);

                    // La posición se calcula por índice: el bloque 0 queda abajo.
                    int y = borde.Bottom - margenInterno - altoBloque
                          - i * (altoBloque + separacion);

                    Rectangle rect = new Rectangle(borde.Left + margenInterno, y,
                                                   borde.Width - 2 * margenInterno,
                                                   altoBloque);

                    Color colorFondo;
                    Color colorTexto;

                    if (esTope)
                    {
                        colorFondo = Color.FromArgb(250, 199, 117);
                        colorTexto = Color.FromArgb(65, 36, 2);
                    }
                    else
                    {
                        colorFondo = Color.FromArgb(40, 90, 190);
                        colorTexto = Color.White;
                    }

                    using (SolidBrush pincelFondo = new SolidBrush(colorFondo))
                    using (SolidBrush pincelTexto = new SolidBrush(colorTexto))
                    using (GraphicsPath bloque = Redondeado(rect, radio))
                    {
                        g.FillPath(pincelFondo, bloque);
                        g.DrawString(datos[i], fuente, pincelTexto, rect, formato);
                    }
                }
            }
        }

        // ---------- Leyenda centrada debajo de la pila ----------
        private void DibujarLeyenda(Graphics g, Rectangle borde)
        {
            if (leyenda == "")
            {
                return;
            }

            // Rectángulo que ocupa todo el ancho del control, justo bajo la pila.
            Rectangle zona = new Rectangle(0, borde.Bottom + 6, Width, espacioLeyenda - 6);

            using (Font fuente = new Font("Segoe UI Semibold", 14, FontStyle.Bold))
            using (StringFormat formato = new StringFormat())
            using (SolidBrush pincel = new SolidBrush(Color.White))
            {
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;
                g.DrawString(leyenda, fuente, pincel, zona, formato);
            }
        }

        // Crea un rectángulo con esquinas redondeadas.
        private static GraphicsPath Redondeado(Rectangle rc, int radio)
        {
            int d = radio * 2;
            GraphicsPath p = new GraphicsPath();
            p.AddArc(rc.Left, rc.Top, d, d, 180, 90);
            p.AddArc(rc.Right - d, rc.Top, d, d, 270, 90);
            p.AddArc(rc.Right - d, rc.Bottom - d, d, d, 0, 90);
            p.AddArc(rc.Left, rc.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}