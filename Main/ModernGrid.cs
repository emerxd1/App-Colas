// ModernGrid.cs — DataGridView moderno y EDITABLE en un solo archivo (estilo verde, sin avatares).
// Sin dependencias de otras clases: copie este archivo a su proyecto (.NET Framework 4.7+ o .NET 6/8, WinForms).
//
// NAMESPACE: ModernControls  ->  agregue  using ModernControls;  donde lo use.
//
// SIN LÍNEAS: el control impone CellBorderStyle = None, AdvancedCellBorderStyle = None,
//   ColumnHeadersBorderStyle = None y GridColor = Color.White en el constructor, al crear el handle,
//   cuando cambian esas propiedades y justo antes de cada pintado (EnforceNoLines). Así ningún código
//   del diseñador o del formulario puede volver a activar las líneas.
//
// FUNCIONA IGUAL si el grid se arrastra desde el diseñador o se crea por código:
//   - El estilo de cada columna se decide AL DIBUJAR (no al agregarla), porque el diseñador agrega las
//     columnas al grid ANTES de asignarles Name y HeaderText:
//       DNI, teléfono, RUC, fecha...  -> texto gris   (Kind.Muted)
//       nombre, cliente, apellido...  -> negrita      (Kind.Bold)
//       "Estado"                      -> píldora de color (badge)
//       el resto                      -> texto normal (Kind.Text)
//     Para forzar otro estilo:  col.Tag = ModernGrid.Kind.Bold;   o   grid.BadgeColumnNames.Add("MiColumna");
//   - Los encabezados se muestran en MAYÚSCULAS al dibujarlos; el HeaderText real no se modifica.
//
// USO POR CÓDIGO:
//   var grid = new ModernGrid { Dock = DockStyle.Fill };
//   grid.AddTextColumn("dni",    "DNI",      ModernGrid.Kind.Muted, 110);
//   grid.AddTextColumn("nombre", "Cliente",  ModernGrid.Kind.Bold,  160);
//   grid.AddTextColumn("correo", "Correo",   ModernGrid.Kind.Text,  170);
//   grid.AddTextColumn("tel",    "Teléfono", ModernGrid.Kind.Muted, 100);
//   grid.AddBadgeColumn("estado","Estado",   new[] { "Activo", "No Activo" }, 100);
//   grid.Rows.Add("001-020202-1800A", "Cliente Insert", "cliente1@gmail.com", "89074056", "No Activo");
//   Controls.Add(grid);
//
// COLUMNAS: se ajustan solas al contenido (AutoFitColumns = true). También puede llamar grid.FitColumns().
//
// FILTRAR: grid.FilterRows("DNI", texto)  (una columna)  o  grid.FilterRows(null, texto)  (todas),
//          grid.ClearFilter() para mostrar todo,  grid.FilterRows(row => /* condición */).
//
// EDICIÓN: doble clic o F2 / escribir sobre la celda; Enter confirma, Esc cancela;
//          clic en la columna "badge" abre la lista; Supr elimina la fila (si AllowDeleteKey = true);
//          grid.ReadOnly = true lo vuelve de solo lectura; col.ReadOnly = true bloquea una columna.
//
// RADIOS (editables también desde la ventana de Propiedades):
//   grid.RowRadius    = 10;  // esquinas de la cabecera y de la fila seleccionada/hover (0 = rectas)
//   grid.CornerRadius = 0;   // esquinas del control completo (0 = rectas)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ModernControls
{
    [ToolboxItem(true)]
    [DesignerCategory("Component")]
    [DefaultEvent("CellValueChanged")]
    public class ModernGrid : DataGridView
    {
        public enum Kind { Text, Muted, Bold }

        // ---- Paleta (editable desde fuera) ----
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color AccentColor { get; set; } = Color.FromArgb(15, 123, 90);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SelectionColor { get; set; } = Color.FromArgb(228, 243, 234);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverColor { get; set; } = Color.FromArgb(244, 249, 246);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color LineColor { get; set; } = Color.FromArgb(228, 233, 230);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HeaderBack { get; set; } = Color.FromArgb(241, 245, 243);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TextColor { get; set; } = Color.FromArgb(16, 30, 24);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color MutedColor { get; set; } = Color.FromArgb(100, 116, 146);
        [DefaultValue(true)]
        public bool AllowDeleteKey { get; set; } = true;

        /// <summary>
        /// Este control no usa las líneas de celda del DataGridView (dibuja sus propios separadores),
        /// así que cualquier valor que asigne el diseñador se ignora y queda siempre en None.
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataGridViewCellBorderStyle CellBorderStyle
        {
            get => base.CellBorderStyle;
            set => base.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        // ---- Ajuste automático de columnas ----
        private bool _autoFit = true;

        [Category("Behavior")]
        [DefaultValue(true)]
        [Description("Ajusta el ancho de las columnas al contenido cada vez que cambian los datos.")]
        public bool AutoFitColumns
        {
            get => _autoFit;
            set { _autoFit = value; if (value) ScheduleFit(); }
        }

        // ---- Radio de la cabecera y de la fila seleccionada/hover ----
        private int _rowRadius = 10;

        [Category("Appearance")]
        [DefaultValue(10)]
        [Description("Radio de las esquinas de la cabecera y de la fila seleccionada (0 = esquinas rectas).")]
        public int RowRadius
        {
            get => _rowRadius;
            set
            {
                _rowRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        // ---- Radio de las esquinas del control completo ----
        private int _cornerRadius = 0;

        [Category("Appearance")]
        [DefaultValue(0)]
        [Description("Radio de las esquinas del grid completo en píxeles (0 = esquinas rectas).")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = Math.Max(0, value);
                UpdateRegion();
                Invalidate();
            }
        }

        /// <summary>Colores (fondo, texto) por valor de badge. Puede agregar los suyos.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, Color[]> BadgeColors { get; } = new Dictionary<string, Color[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "Activo",    new[] { Color.FromArgb(221, 243, 232), Color.FromArgb(19, 122, 75) } },
            { "Completado",new[] { Color.FromArgb(221, 243, 232), Color.FromArgb(19, 122, 75) } },
            { "Pendiente", new[] { Color.FromArgb(255, 241, 219), Color.FromArgb(154, 91, 0) } },
            { "No Activo", new[] { Color.FromArgb(253, 231, 233), Color.FromArgb(180, 35, 47) } },
            { "Inactivo",  new[] { Color.FromArgb(253, 231, 233), Color.FromArgb(180, 35, 47) } },
            { "Cancelado", new[] { Color.FromArgb(253, 231, 233), Color.FromArgb(180, 35, 47) } },
        };

        /// <summary>
        /// Nombres de columna que se dibujan como píldora de estado aunque la columna se haya creado
        /// en el diseñador o sin AddBadgeColumn.
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HashSet<string> BadgeColumnNames { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Estado" };

        private int _hotRow = -1;
        private bool _fitPending;
        private bool _enforcing;
        private const int PadLeft = 14;
        private const int MaxAutoWidth = 320;
        private const int RowHeight = 56;
        private const int HeaderHeight = 44;

        public ModernGrid()
        {
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.5f);
            ApplyModernStyle();
        }

        // ------------------------------------------------------------------ sin líneas
        /// <summary>
        /// Garantiza que el grid no dibuje NINGUNA línea propia (ni entre celdas, ni en la cabecera).
        /// Es barato: solo escribe si alguna propiedad tiene un valor distinto del esperado.
        /// </summary>
        private void EnforceNoLines()
        {
            if (_enforcing) return;
            _enforcing = true;
            try
            {
                if (base.CellBorderStyle != DataGridViewCellBorderStyle.None)
                    base.CellBorderStyle = DataGridViewCellBorderStyle.None;

                if (AdvancedCellBorderStyle.All != DataGridViewAdvancedCellBorderStyle.None)
                    AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

                if (ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                if (RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                if (GridColor != Color.White)
                    GridColor = Color.White;      // si alguna línea se colara, sería blanca sobre blanco

                // Divisores de columna/fila (el diseñador o el código pueden dejarlos > 0)
                foreach (DataGridViewColumn col in Columns)
                    if (col.DividerWidth != 0) col.DividerWidth = 0;

                if (RowTemplate.DividerHeight != 0) RowTemplate.DividerHeight = 0;
                if (RowCount > 0 && RowCount < 2000)
                    foreach (DataGridViewRow row in Rows)
                        if (row.DividerHeight != 0) row.DividerHeight = 0;
            }
            finally
            {
                _enforcing = false;
            }
        }

        protected override void OnCellBorderStyleChanged(EventArgs e)
        {
            base.OnCellBorderStyleChanged(e);
            EnforceNoLines();
        }

        protected override void OnColumnHeadersBorderStyleChanged(EventArgs e)
        {
            base.OnColumnHeadersBorderStyleChanged(e);
            EnforceNoLines();
        }

        protected override void OnRowHeadersBorderStyleChanged(EventArgs e)
        {
            base.OnRowHeadersBorderStyleChanged(e);
            EnforceNoLines();
        }

        protected override void OnGridColorChanged(EventArgs e)
        {
            base.OnGridColorChanged(e);
            EnforceNoLines();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            EnforceNoLines();         // red de seguridad: si alguien lo cambió, se corrige antes de dibujar
            base.OnPaint(e);
            EraseCellEdges(e.Graphics);
        }

        /// <summary>
        /// El pintado base del grid deja una línea oscura translúcida de 1 px en el borde superior e izquierdo
        /// de cada celda (se comprobó con una prueba: desaparece al repintar después de base.OnPaint).
        /// Aquí se repinta ese borde con los mismos colores que usa OnCellPainting, de modo que no se vea.
        /// </summary>
        private void EraseCellEdges(Graphics g)
        {
            if (ColumnCount == 0) return;

            var oldSmooth = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.None;
            int fullWidth = ClientSize.Width;

            // Columnas visibles en pantalla (se omite la primera: su borde izquierdo no se dibuja)
            var xs = new List<int>();
            bool firstSkipped = false;
            foreach (DataGridViewColumn col in Columns)
            {
                if (!col.Visible || !col.Displayed) continue;
                if (!firstSkipped) { firstSkipped = true; continue; }
                xs.Add(GetColumnDisplayRectangle(col.Index, true).Left);
            }

            using (var white = new SolidBrush(Color.White))
            using (var headBr = new SolidBrush(HeaderBack))
            using (var selBr = new SolidBrush(SelectionColor))
            using (var hotBr = new SolidBrush(HoverColor))
            using (var lineBr = new SolidBrush(LineColor))
            {
                // Cabecera
                if (ColumnHeadersVisible)
                {
                    int top = 0, h = ColumnHeadersHeight;
                    g.FillRectangle(white, 0, top, fullWidth, 1);
                    foreach (int x in xs) VerticalEdge(g, x, top, h, white, headBr, null);
                }

                // Filas
                for (int i = 0; i < RowCount; i++)
                {
                    var row = Rows[i];
                    if (!row.Visible || !row.Displayed) continue;

                    var rr = GetRowDisplayRectangle(i, true);
                    if (rr.Height <= 0) continue;

                    g.FillRectangle(white, 0, rr.Y, fullWidth, 1);   // borde superior: siempre blanco (margen)

                    bool selected = row.Selected;
                    bool hot = i == _hotRow;
                    Brush band = selected ? selBr : hot ? hotBr : white;
                    Brush sep = (selected || hot) ? null : lineBr;   // línea separadora solo en filas normales

                    foreach (int x in xs) VerticalEdge(g, x, rr.Y, rr.Height, white, band, sep);
                }

                // Borde izquierdo de la PRIMERA columna: aquí la forma tiene esquinas redondeadas,
                // así que se borra la tira de 1 px y se vuelve a dibujar la forma recortada a esa tira.
                var firstCol = Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                if (firstCol != null && firstCol.Displayed)
                {
                    var lastCol = Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                    bool onlyOne = firstCol == lastCol;
                    var cr = GetColumnDisplayRectangle(firstCol.Index, true);

                    if (ColumnHeadersVisible)
                        RepaintFirstEdge(g, cr, 0, ColumnHeadersHeight, white, headBr, null, onlyOne);

                    for (int i = 0; i < RowCount; i++)
                    {
                        var row = Rows[i];
                        if (!row.Visible || !row.Displayed) continue;

                        var rr = GetRowDisplayRectangle(i, true);
                        if (rr.Height <= 0) continue;

                        bool selected = row.Selected;
                        bool hot = i == _hotRow;
                        Brush shape = selected ? selBr : hot ? hotBr : null;
                        Brush sep = shape == null ? lineBr : null;

                        RepaintFirstEdge(g, cr, rr.Y, rr.Height, white, shape, sep, onlyOne);
                    }
                }
            }

            g.SmoothingMode = oldSmooth;
        }

        // Repinta la tira de 1 px del borde izquierdo de la primera columna: la deja en blanco y, si la fila
        // tiene forma (cabecera, seleccionada o hover), dibuja la forma redondeada recortada a esa tira.
        private void RepaintFirstEdge(Graphics g, Rectangle col, int top, int height, Brush white, Brush shape, Brush separator, bool onlyOne)
        {
            if (height < 6) return;

            var strip = new Rectangle(col.Left, top, 1, height);
            var state = g.Save();
            g.SetClip(strip, CombineMode.Intersect);

            g.SmoothingMode = SmoothingMode.None;
            g.FillRectangle(white, strip);

            if (shape != null)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                FillRowShape(g, shape, new Rectangle(col.X, top + 2, col.Width, height - 4), _rowRadius, true, onlyOne);
            }
            else if (separator != null)
            {
                g.SmoothingMode = SmoothingMode.None;
                g.FillRectangle(separator, col.Left, top + height - 1, 1, 1);
            }

            g.Restore(state);
        }

        // Repinta 1 px de ancho en x: 2 px de margen blanco arriba y abajo, la franja de color en medio
        // y, si corresponde, el último píxel con el color de la línea separadora.
        private static void VerticalEdge(Graphics g, int x, int top, int height, Brush margin, Brush band, Brush separator)
        {
            if (height < 6) return;
            g.FillRectangle(margin, x, top + 1, 1, 1);                         // (top ya lo cubre la línea horizontal)
            g.FillRectangle(band, x, top + 2, 1, height - 4);
            g.FillRectangle(margin, x, top + height - 2, 1, 2);
            if (separator != null) g.FillRectangle(separator, x, top + height - 1, 1, 1);
        }

        /// <summary>
        /// Impone el aspecto del control. Se llama en el constructor y otra vez al crear el control,
        /// porque el diseñador de formularios guarda sus propios valores (bordes, encabezado de fila,
        /// alturas...) y los aplica DESPUÉS del constructor.
        /// </summary>
        private void ApplyModernStyle()
        {
            BorderStyle = BorderStyle.None;
            BackgroundColor = Color.White;
            EnforceNoLines();
            EnableHeadersVisualStyles = false;
            RowHeadersVisible = false;
            AllowUserToAddRows = false;
            AllowUserToResizeRows = false;
            MultiSelect = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = HeaderHeight;
            RowTemplate.Height = RowHeight;
            ShowCellToolTips = false;

            ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = HeaderBack,
                ForeColor = MutedColor,
                Font = new Font("Segoe UI Semibold", 8.5f),
                SelectionBackColor = HeaderBack,
                SelectionForeColor = MutedColor,
                Padding = new Padding(PadLeft, 0, 0, 0),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
            DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = TextColor,
                Font = Font,
                SelectionBackColor = SelectionColor,
                SelectionForeColor = TextColor,
                Padding = new Padding(PadLeft, 0, 0, 0)
            };
            AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle(DefaultCellStyle);
            RowsDefaultCellStyle = new DataGridViewCellStyle(DefaultCellStyle);

            // Filas que ya existan (por ejemplo, cargadas antes de crear el control)
            if (RowCount > 0 && RowCount < 2000)
                foreach (DataGridViewRow row in Rows)
                    if (row.Height != RowHeight) row.Height = RowHeight;

            // Columnas que ya existan (creadas en el diseñador)
            foreach (DataGridViewColumn col in Columns)
                StyleColumn(col);
        }

        // ------------------------------------------------------------------ columnas
        public DataGridViewTextBoxColumn AddTextColumn(string name, string header, Kind kind = Kind.Text, float weight = 100, int minWidth = 60)
        {
            var c = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                Tag = kind,
                FillWeight = weight,
                MinimumWidth = minWidth,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            Columns.Add(c);
            return c;
        }

        /// <summary>Columna de estado: se dibuja como píldora de color y se edita con una lista desplegable.</summary>
        public DataGridViewComboBoxColumn AddBadgeColumn(string name, string header, string[] items, float weight = 100, int minWidth = 90)
        {
            var c = new DataGridViewComboBoxColumn
            {
                Name = name,
                HeaderText = header,
                Tag = "badge",
                FillWeight = weight,
                MinimumWidth = minWidth,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                DisplayStyleForCurrentCellOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            c.Items.AddRange(items);
            Columns.Add(c);
            return c;
        }

        /// <summary>Agrega una fila vacía y deja la primera celda editable (útil para un botón "Nuevo").</summary>
        public int AddBlankRow()
        {
            var vals = new object[Columns.Count];
            for (int i = 0; i < vals.Length; i++)
                vals[i] = Columns[i] is DataGridViewComboBoxColumn cc && cc.Items.Count > 0 ? cc.Items[0] : "";
            int idx = Rows.Add(vals);
            CurrentCell = this[0, idx];
            BeginEdit(true);
            return idx;
        }

        public void DeleteSelectedRow()
        {
            if (CurrentRow != null && !CurrentRow.IsNewRow) Rows.Remove(CurrentRow);
        }

        // Cualquier columna que llegue sin pasar por AddTextColumn/AddBadgeColumn (diseñador, DataSource...)
        // también recibe el estilo del control. OJO: el diseñador agrega las columnas ANTES de asignarles
        // Name y HeaderText, por eso aquí no se decide nada que dependa de esos valores.
        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            StyleColumn(e.Column);
            ScheduleFit();
        }

        private static void StyleColumn(DataGridViewColumn c)
        {
            c.SortMode = DataGridViewColumnSortMode.NotSortable;
            c.DefaultCellStyle = new DataGridViewCellStyle();     // quita estilos propios del diseñador
        }

        // El tipo de columna se resuelve al dibujar, cuando Name y HeaderText ya tienen su valor final.
        private bool IsBadge(DataGridViewColumn c)
        {
            if (c.Tag is string s) return s == "badge";
            return c.Tag == null && BadgeColumnNames.Contains(c.Name ?? "");
        }

        private static Kind ResolveKind(DataGridViewColumn c)
        {
            return c.Tag is Kind k ? k : GuessKind(c);
        }

        private static Kind GuessKind(DataGridViewColumn c)
        {
            string key = ((c.Name ?? "") + " " + (c.HeaderText ?? "")).ToLowerInvariant();

            string[] muted = { "dni", "tel", "ruc", "codigo", "código", "fecha", "cedula", "cédula" };
            string[] bold = { "nombre", "name", "cliente", "proveedor", "razon", "razón", "apellido", "producto", "usuario", "empleado" };

            foreach (var m in muted) if (key.Contains(m)) return Kind.Muted;
            foreach (var b in bold) if (key.Contains(b)) return Kind.Bold;
            return Kind.Text;
        }

        // ------------------------------------------------------------------ ajuste de columnas
        /// <summary>
        /// Calcula el ancho mínimo de cada columna visible según su contenido (cabecera y celdas) y reparte
        /// el espacio sobrante en proporción. Así ningún texto queda cortado con "...".
        /// </summary>
        public void FitColumns()
        {
            if (Columns.Count == 0 || IsDisposed) return;

            using (var g = CreateGraphics())
            using (var fNorm = new Font("Segoe UI", 9.5f))
            using (var fBold = new Font("Segoe UI Semibold", 9.5f))
            using (var fHead = new Font("Segoe UI Semibold", 8.5f))
            {
                int sample = Math.Min(RowCount, 500);

                foreach (DataGridViewColumn col in Columns)
                {
                    if (!col.Visible) continue;

                    bool badge = IsBadge(col);
                    var font = ResolveKind(col) == Kind.Bold ? fBold : fNorm;

                    float header = g.MeasureString((col.HeaderText ?? "").ToUpperInvariant(), fHead).Width + PadLeft + 12;
                    float body = 0;

                    for (int i = 0; i < sample; i++)
                    {
                        string text = Rows[i].Cells[col.Index].Value?.ToString() ?? "";
                        if (text.Length == 0) continue;

                        float w = badge
                            ? g.MeasureString(text, fHead).Width + 34 + PadLeft + 8   // píldora: punto + márgenes
                            : g.MeasureString(text, font).Width + PadLeft + 12;

                        if (w > body) body = w;
                    }

                    int width = (int)Math.Ceiling(Math.Max(header, body));
                    width = Math.Max(60, Math.Min(MaxAutoWidth, width));

                    col.MinimumWidth = width;
                    col.FillWeight = width;      // el espacio sobrante se reparte proporcional al contenido
                }
            }
        }

        private void ScheduleFit()
        {
            if (!_autoFit || _fitPending || !IsHandleCreated || IsDisposed) return;

            _fitPending = true;
            BeginInvoke(new Action(() =>
            {
                _fitPending = false;
                if (!IsDisposed) FitColumns();
            }));
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e) { base.OnRowsAdded(e); ScheduleFit(); }
        protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e) { base.OnRowsRemoved(e); ScheduleFit(); }
        protected override void OnCellValueChanged(DataGridViewCellEventArgs e) { base.OnCellValueChanged(e); ScheduleFit(); }
        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e) { base.OnDataBindingComplete(e); ScheduleFit(); }

        // ------------------------------------------------------------------ filtrado
        /// <summary>
        /// Muestra solo las filas que cumplen la condición (null = mostrar todas). Oculta/muestra las filas
        /// sin reconstruir el grid, por lo que el estilo y las columnas no se pierden.
        /// </summary>
        public void FilterRows(Func<DataGridViewRow, bool> predicate)
        {
            // Una fila no puede ocultarse mientras es la fila actual: se suelta la selección primero.
            if (IsCurrentCellInEditMode) EndEdit();
            CurrentCell = null;
            ClearSelection();
            _hotRow = -1;

            SuspendLayout();
            foreach (DataGridViewRow row in Rows)
                row.Visible = predicate == null || predicate(row);
            ResumeLayout();

            Invalidate();
        }

        /// <summary>
        /// Filtra por texto (contiene, sin distinguir mayúsculas). columnName = nombre de la columna;
        /// null o vacío = busca en todas las columnas visibles. Texto vacío = mostrar todo.
        /// </summary>
        public void FilterRows(string columnName, string text)
        {
            text = (text ?? "").Trim();
            if (text.Length == 0) { FilterRows((Func<DataGridViewRow, bool>)null); return; }

            FilterRows(row =>
            {
                if (!string.IsNullOrEmpty(columnName))
                    return ContainsText(row.Cells[columnName].Value, text);

                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.OwningColumn.Visible && ContainsText(cell.Value, text)) return true;

                return false;
            });
        }

        public void ClearFilter() { FilterRows((Func<DataGridViewRow, bool>)null); }

        private static bool ContainsText(object value, string text)
        {
            return value != null && value.ToString().IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }

        // ------------------------------------------------------------------ interacción
        protected override void OnCellMouseEnter(DataGridViewCellEventArgs e) { base.OnCellMouseEnter(e); SetHot(e.RowIndex); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); SetHot(-1); }

        private void SetHot(int row)
        {
            if (row == _hotRow) return;
            int old = _hotRow; _hotRow = row;
            if (old >= 0 && old < RowCount) InvalidateRow(old);
            if (row >= 0 && row < RowCount) InvalidateRow(row);
        }

        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e)
        {
            base.OnCellDoubleClick(e);
            if (!ReadOnly && e.RowIndex >= 0 && e.ColumnIndex >= 0 && !Columns[e.ColumnIndex].ReadOnly)
                BeginEdit(true);
        }

        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);
            // La lista de estados se abre con un solo clic
            if (!ReadOnly && e.RowIndex >= 0 && e.ColumnIndex >= 0 && Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && !Columns[e.ColumnIndex].ReadOnly)
            {
                CurrentCell = this[e.ColumnIndex, e.RowIndex];
                BeginEdit(true);
                if (EditingControl is ComboBox cb) cb.DroppedDown = true;
            }
        }

        protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
        {
            base.OnEditingControlShowing(e);
            e.CellStyle.BackColor = Color.White;
            e.CellStyle.ForeColor = TextColor;
            if (e.Control is TextBox tb)
            {
                tb.BorderStyle = BorderStyle.None;
                tb.BackColor = Color.White;
                tb.Font = Font;
            }
            else if (e.Control is ComboBox cb)
            {
                cb.FlatStyle = FlatStyle.Flat;
                cb.BackColor = Color.White;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Font = Font;
                // Al elegir un valor, confirma de inmediato
                cb.SelectionChangeCommitted -= CommitCombo;
                cb.SelectionChangeCommitted += CommitCombo;
            }
        }

        private void CommitCombo(object sender, EventArgs e) { CommitEdit(DataGridViewDataErrorContexts.Commit); EndEdit(); }

        protected override void OnCellEndEdit(DataGridViewCellEventArgs e) { base.OnCellEndEdit(e); InvalidateRow(e.RowIndex); }

        protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;      // evita el cuadro de error del DataGridView por valores fuera de lista
            e.Cancel = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (AllowDeleteKey && keyData == Keys.Delete && !IsCurrentCellInEditMode && !ReadOnly && CurrentRow != null)
            {
                DeleteSelectedRow();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ------------------------------------------------------------------ radio del control
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyModernStyle();       // vuelve a imponer el estilo por encima de lo que haya guardado el diseñador
            UpdateRegion();
            ScheduleFit();
        }

        private void UpdateRegion()
        {
            if (Width <= 0 || Height <= 0) return;

            var old = Region;

            if (_cornerRadius <= 0)
            {
                Region = null;
            }
            else
            {
                using (var path = Round(new Rectangle(0, 0, Width, Height), _cornerRadius))
                    Region = new Region(path);
            }

            old?.Dispose();
        }

        // ------------------------------------------------------------------ dibujo
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            // Cabecera propia: barra gris-verdosa con los extremos redondeados
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                PaintHeaderCell(e);
                return;
            }

            if (e.RowIndex < 0 || e.ColumnIndex < 0) { base.OnCellPainting(e); return; }

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var b = e.CellBounds;
            var column = Columns[e.ColumnIndex];
            bool selected = Rows[e.RowIndex].Selected;
            bool hot = e.RowIndex == _hotRow;
            bool editing = IsCurrentCellInEditMode && CurrentCell != null &&
                           CurrentCell.RowIndex == e.RowIndex && CurrentCell.ColumnIndex == e.ColumnIndex;

            // Fondo blanco base
            using (var white = new SolidBrush(Color.White)) g.FillRectangle(white, b);

            if (editing)
            {
                // Anillo del color de acento alrededor de la celda en edición (el control de edición se dibuja encima)
                var r = new Rectangle(b.X + 3, b.Y + 6, b.Width - 7, b.Height - 13);
                using (var glow = new SolidBrush(Color.FromArgb(36, AccentColor))) FillRound(g, glow, Rectangle.Inflate(r, 2, 2), 8);
                using (var w2 = new SolidBrush(Color.White)) FillRound(g, w2, r, 6);
                using (var pen = new Pen(AccentColor, 1.5f)) DrawRound(g, pen, r, 6);
                e.Handled = true;
                return;
            }

            if (selected || hot)
            {
                // Fila seleccionada/hover: bloque redondeado que cubre toda la fila
                bool first = column == Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                bool last = column == Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                using (var br = new SolidBrush(selected ? SelectionColor : HoverColor))
                    FillRowShape(g, br, new Rectangle(b.X, b.Y + 2, b.Width, b.Height - 4), _rowRadius, first, last);
            }
            else
            {
                // Línea separadora entre filas
                using (var pen = new Pen(LineColor)) g.DrawLine(pen, b.Left, b.Bottom - 1, b.Right, b.Bottom - 1);
            }

            string text = e.FormattedValue?.ToString() ?? "";

            if (IsBadge(column))
            {
                DrawBadge(g, new Rectangle(b.X + PadLeft, b.Y + (b.Height - 26) / 2, 0, 26), text);
            }
            else
            {
                var textRect = new Rectangle(b.X + PadLeft, b.Y, b.Width - PadLeft - 4, b.Height);
                switch (ResolveKind(column))
                {
                    case Kind.Muted:
                        DrawText(g, text, "Segoe UI", 9.5f, MutedColor, textRect, StringAlignment.Near);
                        break;
                    case Kind.Bold:
                        DrawText(g, text, "Segoe UI Semibold", 9.5f, TextColor, textRect, StringAlignment.Near);
                        break;
                    default:
                        DrawText(g, text, "Segoe UI", 9.5f, TextColor, textRect, StringAlignment.Near);
                        break;
                }
            }
            e.Handled = true;
        }

        private void PaintHeaderCell(DataGridViewCellPaintingEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var b = e.CellBounds;
            var col = Columns[e.ColumnIndex];
            bool first = col == Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            bool last = col == Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None);

            using (var white = new SolidBrush(Color.White)) g.FillRectangle(white, b);
            using (var br = new SolidBrush(HeaderBack))
                FillRowShape(g, br, new Rectangle(b.X, b.Y + 2, b.Width, b.Height - 4), _rowRadius, first, last);

            DrawText(g, (col.HeaderText ?? "").ToUpperInvariant(), "Segoe UI Semibold", 8.5f, MutedColor,
                     new Rectangle(b.X + PadLeft, b.Y, b.Width - PadLeft - 4, b.Height), StringAlignment.Near);
            e.Handled = true;
        }

        // ------------------------------------------------------------------ utilidades privadas
        private void DrawBadge(Graphics g, Rectangle r, string text)
        {
            Color bg = Color.FromArgb(238, 241, 247), fg = MutedColor;
            if (BadgeColors.TryGetValue(text, out var c)) { bg = c[0]; fg = c[1]; }
            using (var f = new Font("Segoe UI Semibold", 8.5f))
            {
                int w = (int)Math.Ceiling(g.MeasureString(text, f).Width) + 34;
                r.Width = w;
                using (var br = new SolidBrush(bg)) FillRound(g, br, r, r.Height / 2);
                using (var dot = new SolidBrush(fg)) g.FillEllipse(dot, r.X + 12, r.Y + (r.Height - 7) / 2, 7, 7);
                DrawText(g, text, "Segoe UI Semibold", 8.5f, fg, new Rectangle(r.X + 24, r.Y, r.Width - 26, r.Height), StringAlignment.Near);
            }
        }

        private static void DrawText(Graphics g, string text, string family, float size, Color color, Rectangle r, StringAlignment h)
        {
            if (string.IsNullOrEmpty(text)) return;
            using (var f = new Font(family, size))
            using (var br = new SolidBrush(color))
            using (var sf = new StringFormat(StringFormatFlags.NoWrap) { Alignment = h, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter })
                g.DrawString(text, f, br, r, sf);
        }

        /// <summary>
        /// Rellena la parte de una celda que le toca a una "barra" redondeada que cruza toda la fila:
        /// la primera celda redondea su lado izquierdo, la última el derecho y las del medio quedan rectas.
        /// </summary>
        private static void FillRowShape(Graphics g, Brush br, Rectangle cell, int radius, bool first, bool last)
        {
            int ext = Math.Max(radius, 1) * 2;
            var shape = new Rectangle(
                cell.X - (first ? 0 : ext),
                cell.Y,
                cell.Width + (first ? 0 : ext) + (last ? 0 : ext),
                cell.Height);

            var state = g.Save();
            g.SetClip(cell, CombineMode.Intersect);
            using (var p = Round(shape, radius)) g.FillPath(br, p);
            g.Restore(state);
        }

        private static GraphicsPath Round(Rectangle r, int radius)
        {
            var p = new GraphicsPath();
            int d = Math.Max(1, Math.Min(radius * 2, Math.Min(r.Width, r.Height)));
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
        private static void FillRound(Graphics g, Brush b, Rectangle r, int radius) { using (var p = Round(r, radius)) g.FillPath(b, p); }
        private static void DrawRound(Graphics g, Pen pen, Rectangle r, int radius) { using (var p = Round(r, radius)) g.DrawPath(pen, p); }
    }
}