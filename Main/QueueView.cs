using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Estructuras;

/// <summary>
/// Control de WinForms que dibuja una cola con estilo moderno: tarjetas redondeadas
/// con degradado y sombra, flechas suaves y etiquetas tipo "pastilla".
/// El tamaño de las tarjetas se adapta a la cantidad de elementos y al tamaño del
/// control; si aun así no caben (cola muy larga), aparece scroll horizontal.
/// </summary>
public class QueueView : Panel
{
    // Medidas base (a escala 1.0)
    private const float BoxW = 96f;
    private const float BoxH = 52f;
    private const float Gap = 44f;
    private const float Margin = 24f;
    private const float VMargin = 16f;
    private const float LabelGap = 12f;
    private const float PillH = 20f;

    // Límites de la escala automática
    private const float MinScale = 0.45f;  // más pequeño que esto => scroll
    private const float MaxScale = 1.3f;   // más grande que esto => se ve exagerado

    private List<string> _items = new();
    private float _scale = 1f;
    private float _offsetX = Margin;
    private bool _recalculando;

    // Colores personalizables
    public Color FrontColor { get; set; } = Color.FromArgb(16, 185, 129);  // frente (verde)
    public Color NodeColor { get; set; } = Color.FromArgb(59, 130, 246);   // intermedios (azul)
    public Color TailColor { get; set; } = Color.FromArgb(245, 158, 11);   // final (ámbar)
    public Color ArrowColor { get; set; } = Color.FromArgb(148, 163, 184); // flechas (gris azulado)

    public QueueView()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
        AutoScroll = true;
        BackColor = Color.White;
        MinimumSize = new Size(120, 100);
    }

    /// <summary>
    /// Actualiza el dibujo con el contenido actual de la cola (del frente al final).
    /// Llámalo después de cada Enqueue/Dequeue.
    /// </summary>
    public void Mostrar<T>(IEnumerable<T> elementos)
    {
        _items = elementos.Select(x => x?.ToString() ?? "null").ToList();
        Recalcular();
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        Recalcular();
    }

    protected override void OnScroll(ScrollEventArgs se)
    {
        base.OnScroll(se);
        Invalidate();
    }

    // Calcula la escala de las tarjetas según cuántas hay y cuánto espacio hay
    private void Recalcular()
    {
        if (_recalculando) return;
        _recalculando = true;
        try
        {
            int n = _items.Count;
            if (n == 0)
            {
                AutoScrollMinSize = Size.Empty;
            }
            else
            {
                float necesario = n * BoxW + (n - 1) * Gap;           // ancho a escala 1
                float anchoDisp = ClientSize.Width - 2 * Margin;
                // Se usa Height (no ClientSize.Height) para que la barra de scroll
                // no cambie la escala y provoque un bucle de recálculo.
                float altoDisp = Height - 2 * VMargin - LabelGap - PillH;

                float sAncho = anchoDisp / necesario;
                float sAlto = altoDisp / BoxH;
                _scale = Math.Max(MinScale, Math.Min(MaxScale, Math.Min(sAncho, sAlto)));

                float contenido = necesario * _scale;
                if (contenido + 2 * Margin > ClientSize.Width)
                {
                    AutoScrollMinSize = new Size((int)Math.Ceiling(contenido + 2 * Margin), 0);
                    _offsetX = Margin;
                }
                else
                {
                    AutoScrollMinSize = Size.Empty;
                    _offsetX = (ClientSize.Width - contenido) / 2f; // centrado
                }
            }
        }
        finally
        {
            _recalculando = false;
        }
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        using var centrado = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter,
            FormatFlags = StringFormatFlags.NoWrap
        };

        if (_items.Count == 0)
        {
            DibujarVacia(g, centrado);
            return;
        }

        g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

        float s = _scale;
        float bw = BoxW * s;
        float bh = BoxH * s;
        float gap = Gap * s;
        float radio = 10f * s;
        float contenidoAlto = bh + LabelGap + PillH;
        float top = Math.Max(VMargin, (ClientSize.Height - contenidoAlto) / 2f);
        int last = _items.Count - 1;

        using var fontNodo = new Font(Font.FontFamily, Math.Max(7f, 10.5f * s), FontStyle.Bold);
        using var fontPildora = new Font(Font.FontFamily, 8f, FontStyle.Bold);
        using var brushTexto = new SolidBrush(Color.White);
        using var penFlecha = new Pen(ArrowColor, Math.Max(1.5f, 2f * s))
        {
            StartCap = LineCap.Round,
            EndCap = LineCap.Round,
            LineJoin = LineJoin.Round
        };

        for (int i = 0; i <= last; i++)
        {
            float x = _offsetX + i * (bw + gap);
            var caja = new RectangleF(x, top, bw, bh);
            Color baseColor = i == 0 ? FrontColor : i == last ? TailColor : NodeColor;

            // Sombra suave (tres capas translúcidas)
            for (int k = 3; k >= 1; k--)
            {
                var sombra = RectangleF.Inflate(caja, k, k);
                sombra.Offset(0, 3);
                using var pathSombra = Redondeado(sombra, radio + k);
                using var brushSombra = new SolidBrush(Color.FromArgb(14, 0, 0, 0));
                g.FillPath(brushSombra, pathSombra);
            }

            // Tarjeta con degradado vertical
            using (var path = Redondeado(caja, radio))
            using (var degradado = new LinearGradientBrush(
                       caja, Mezclar(baseColor, Color.White, 0.18f), Mezclar(baseColor, Color.Black, 0.12f), 90f))
            using (var borde = new Pen(Color.FromArgb(90, 255, 255, 255), 1f))
            {
                g.FillPath(degradado, path);
                g.DrawPath(borde, path);
            }

            // Texto del elemento
            var zonaTexto = RectangleF.Inflate(caja, -4f * s, 0);
            g.DrawString(_items[i], fontNodo, brushTexto, zonaTexto, centrado);

            // Flecha hacia el siguiente
            if (i < last)
            {
                float y = top + bh / 2f;
                float x1 = x + bw + gap * 0.18f;
                float x2 = x + bw + gap * 0.82f;
                float h = 7f * s;
                g.DrawLine(penFlecha, x1, y, x2, y);
                g.DrawLine(penFlecha, x2, y, x2 - h, y - h * 0.7f);
                g.DrawLine(penFlecha, x2, y, x2 - h, y + h * 0.7f);
            }

            // Etiquetas tipo pastilla
            float cx = x + bw / 2f;
            float yPildora = top + bh + LabelGap;
            if (i == 0 && i == last)
                DibujarPildora(g, "FRENTE · FINAL", cx, yPildora, FrontColor, fontPildora, centrado);
            else if (i == 0)
                DibujarPildora(g, "FRENTE", cx, yPildora, FrontColor, fontPildora, centrado);
            else if (i == last)
                DibujarPildora(g, "FINAL", cx, yPildora, TailColor, fontPildora, centrado);
        }
    }

    // Estado vacío: recuadro punteado con mensaje
    private void DibujarVacia(Graphics g, StringFormat centrado)
    {
        float w = Math.Min(260f, ClientSize.Width - 2 * Margin);
        float h = 64f;
        var zona = new RectangleF(
            (ClientSize.Width - w) / 2f,
            (ClientSize.Height - h) / 2f,
            w, h);

        if (w > 40f && ClientSize.Height > h)
        {
            using var path = Redondeado(zona, 12f);
            using var pen = new Pen(Color.FromArgb(203, 213, 225), 1.5f) { DashStyle = DashStyle.Dash };
            g.DrawPath(pen, path);
        }

        using var font = new Font(Font.FontFamily, 10f, FontStyle.Italic);
        using var brush = new SolidBrush(Color.FromArgb(120, 134, 155));
        g.DrawString("La cola está vacía", font, brush, zona, centrado);
    }

    private static void DibujarPildora(Graphics g, string texto, float centroX, float y,
                                       Color color, Font font, StringFormat formato)
    {
        float w = g.MeasureString(texto, font).Width + 16f;
        var zona = new RectangleF(centroX - w / 2f, y, w, PillH);

        using var path = Redondeado(zona, PillH / 2f);
        using var fondo = new SolidBrush(Color.FromArgb(38, color));
        using var brushTexto = new SolidBrush(Mezclar(color, Color.Black, 0.35f));
        g.FillPath(fondo, path);
        g.DrawString(texto, font, brushTexto, zona, formato);
    }

    // Rectángulo con esquinas redondeadas
    private static GraphicsPath Redondeado(RectangleF r, float radio)
    {
        radio = Math.Max(0.5f, Math.Min(radio, Math.Min(r.Width, r.Height) / 2f));
        float d = radio * 2f;
        var p = new GraphicsPath();
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }

    // Mezcla dos colores: t = 0 devuelve a, t = 1 devuelve b
    private static Color Mezclar(Color a, Color b, float t)
    {
        return Color.FromArgb(
            (int)(a.R + (b.R - a.R) * t),
            (int)(a.G + (b.G - a.G) * t),
            (int)(a.B + (b.B - a.B) * t));
    }
}