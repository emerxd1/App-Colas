using Sunny.UI;

namespace Main
{
    partial class Asistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelTime = new AntdUI.LabelTime();
            uiLabel2 = new UILabel();
            uiLabel1 = new UILabel();
            uiSymbolButton1 = new UISymbolButton();
            uiPanel1 = new UIPanel();
            label2 = new Label();
            label3 = new AntdUI.Label();
            txtCarnet = new AntdUI.Input();
            btnRegistrar = new UIButton();
            label4 = new Label();
            uiPanel2 = new UIPanel();
            label7 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            uiTextBox2 = new UITextBox();
            uiTextBox1 = new UITextBox();
            txtCarnetLeyenda = new UITextBox();
            label5 = new AntdUI.Label();
            lblEstudiante = new Label();
            uiPanel3 = new UIPanel();
            txtExit = new UIButton();
            modernGrid1 = new ModernControls.ModernGrid();
            Carnet = new DataGridViewTextBoxColumn();
            Estudiante = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtPendientes = new UITextBox();
            txtTardes = new UITextBox();
            label9 = new AntdUI.Label();
            txtPresentes = new UITextBox();
            panel1.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modernGrid1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 35, 60);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(uiLabel1);
            panel1.Controls.Add(uiSymbolButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 44);
            panel1.TabIndex = 0;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(872, 3);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(128, 35);
            labelTime.TabIndex = 3;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(61, 20);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(326, 23);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "Algoritmos y Estructura de Datos · Grupo 2S1";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(61, 3);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(180, 23);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Control de Asistencia";
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.FillColor = Color.FromArgb(11, 122, 113);
            uiSymbolButton1.FillDisableColor = Color.FromArgb(11, 122, 113);
            uiSymbolButton1.FillHoverColor = Color.White;
            uiSymbolButton1.FillPressColor = Color.White;
            uiSymbolButton1.FillSelectedColor = Color.White;
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton1.Location = new Point(29, 7);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 10;
            uiSymbolButton1.RectColor = Color.FromArgb(11, 122, 113);
            uiSymbolButton1.RectDisableColor = Color.FromArgb(11, 122, 113);
            uiSymbolButton1.RectHoverColor = Color.White;
            uiSymbolButton1.RectPressColor = Color.White;
            uiSymbolButton1.RectSelectedColor = Color.White;
            uiSymbolButton1.Size = new Size(28, 28);
            uiSymbolButton1.TabIndex = 0;
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(label2);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(txtCarnet);
            uiPanel1.Controls.Add(btnRegistrar);
            uiPanel1.Controls.Add(label4);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(13, 69);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(350, 186);
            uiPanel1.TabIndex = 4;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(14, 103);
            label2.Name = "label2";
            label2.Size = new Size(189, 17);
            label2.TabIndex = 12;
            label2.Text = " Tus datos se completan solos.";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(94, 105, 99);
            label3.Location = new Point(14, 4);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 3;
            label3.Text = "REGISTRAR ASISTENCIA";
            // 
            // txtCarnet
            // 
            txtCarnet.BadgeBack = Color.FromArgb(19, 68, 64);
            txtCarnet.BadgeBorderColor = Color.AliceBlue;
            txtCarnet.BorderActive = Color.FromArgb(22, 165, 117);
            txtCarnet.BorderColor = Color.FromArgb(15, 122, 92);
            txtCarnet.BorderHover = Color.FromArgb(19, 68, 64);
            txtCarnet.BorderWidth = 2F;
            txtCarnet.Location = new Point(6, 51);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.PlaceholderText = "Ej: C-030";
            txtCarnet.PrefixFormat = AntdUI.FormatFlags.HorizontalCenter;
            txtCarnet.SelectionColor = Color.Turquoise;
            txtCarnet.Size = new Size(325, 48);
            txtCarnet.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FillColor = Color.FromArgb(11, 122, 113);
            btnRegistrar.FillColor2 = Color.FromArgb(19, 68, 64);
            btnRegistrar.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnRegistrar.FillPressColor = Color.FromArgb(22, 94, 85);
            btnRegistrar.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(10, 133);
            btnRegistrar.MinimumSize = new Size(1, 1);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Radius = 10;
            btnRegistrar.RectColor = Color.White;
            btnRegistrar.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnRegistrar.RectPressColor = Color.Silver;
            btnRegistrar.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnRegistrar.Size = new Size(320, 35);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar asistencia";
            btnRegistrar.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(18, 33, 26);
            label4.Location = new Point(14, 30);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 8;
            label4.Text = "Ingresa tu carnet";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(label7);
            uiPanel2.Controls.Add(label6);
            uiPanel2.Controls.Add(label1);
            uiPanel2.Controls.Add(uiTextBox2);
            uiPanel2.Controls.Add(uiTextBox1);
            uiPanel2.Controls.Add(txtCarnetLeyenda);
            uiPanel2.Controls.Add(label5);
            uiPanel2.Controls.Add(lblEstudiante);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(13, 283);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RectColor = Color.FromArgb(11, 122, 113);
            uiPanel2.Size = new Size(350, 189);
            uiPanel2.TabIndex = 5;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(94, 105, 99);
            label7.Location = new Point(236, 79);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 14;
            label7.Text = "ESTADO";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(94, 105, 99);
            label6.Location = new Point(125, 79);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 13;
            label6.Text = "ENTRADA";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(94, 105, 99);
            label1.Location = new Point(14, 79);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 12;
            label1.Text = "CARNET";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Enabled = false;
            uiTextBox2.FillColor = Color.FromArgb(221, 243, 240);
            uiTextBox2.FillDisableColor = Color.FromArgb(221, 243, 240);
            uiTextBox2.FillReadOnlyColor = Color.FromArgb(221, 243, 240);
            uiTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox2.ForeColor = Color.FromArgb(13, 94, 87);
            uiTextBox2.ForeDisableColor = Color.FromArgb(13, 94, 87);
            uiTextBox2.ForeReadOnlyColor = Color.FromArgb(13, 94, 87);
            uiTextBox2.Location = new Point(236, 110);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.Radius = 15;
            uiTextBox2.ReadOnly = true;
            uiTextBox2.RectColor = Color.White;
            uiTextBox2.RectDisableColor = Color.White;
            uiTextBox2.RectReadOnlyColor = Color.White;
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(103, 48);
            uiTextBox2.TabIndex = 11;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Enabled = false;
            uiTextBox1.FillColor = Color.FromArgb(230, 235, 241);
            uiTextBox1.FillDisableColor = Color.FromArgb(230, 235, 241);
            uiTextBox1.FillReadOnlyColor = Color.FromArgb(230, 235, 241);
            uiTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox1.Location = new Point(125, 110);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.Radius = 15;
            uiTextBox1.ReadOnly = true;
            uiTextBox1.RectColor = Color.White;
            uiTextBox1.RectDisableColor = Color.White;
            uiTextBox1.RectReadOnlyColor = Color.White;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(103, 48);
            uiTextBox1.TabIndex = 10;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // txtCarnetLeyenda
            // 
            txtCarnetLeyenda.Enabled = false;
            txtCarnetLeyenda.FillColor = Color.FromArgb(230, 235, 241);
            txtCarnetLeyenda.FillDisableColor = Color.FromArgb(230, 235, 241);
            txtCarnetLeyenda.FillReadOnlyColor = Color.FromArgb(230, 235, 241);
            txtCarnetLeyenda.Font = new Font("Microsoft Sans Serif", 12F);
            txtCarnetLeyenda.Location = new Point(14, 110);
            txtCarnetLeyenda.Margin = new Padding(4, 5, 4, 5);
            txtCarnetLeyenda.MinimumSize = new Size(1, 16);
            txtCarnetLeyenda.Name = "txtCarnetLeyenda";
            txtCarnetLeyenda.Padding = new Padding(5);
            txtCarnetLeyenda.Radius = 15;
            txtCarnetLeyenda.ReadOnly = true;
            txtCarnetLeyenda.RectColor = Color.White;
            txtCarnetLeyenda.RectDisableColor = Color.White;
            txtCarnetLeyenda.RectReadOnlyColor = Color.White;
            txtCarnetLeyenda.ShowText = false;
            txtCarnetLeyenda.Size = new Size(103, 48);
            txtCarnetLeyenda.TabIndex = 9;
            txtCarnetLeyenda.TextAlignment = ContentAlignment.MiddleLeft;
            txtCarnetLeyenda.Watermark = "";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(94, 105, 99);
            label5.Location = new Point(14, 4);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 3;
            label5.Text = "VERIFICACION";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.BackColor = Color.Transparent;
            lblEstudiante.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiante.ForeColor = Color.FromArgb(17, 34, 59);
            lblEstudiante.Location = new Point(83, 30);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(120, 21);
            lblEstudiante.TabIndex = 8;
            lblEstudiante.Text = "LBLestudainte";
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(txtExit);
            uiPanel3.Controls.Add(modernGrid1);
            uiPanel3.Controls.Add(txtPendientes);
            uiPanel3.Controls.Add(txtTardes);
            uiPanel3.Controls.Add(label9);
            uiPanel3.Controls.Add(txtPresentes);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(402, 69);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 15;
            uiPanel3.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel3.RectDisableColor = Color.White;
            uiPanel3.Size = new Size(598, 403);
            uiPanel3.TabIndex = 6;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtExit
            // 
            txtExit.FillColor = Color.FromArgb(19, 35, 60);
            txtExit.FillColor2 = Color.FromArgb(19, 68, 64);
            txtExit.FillHoverColor = Color.FromArgb(224, 224, 224);
            txtExit.FillPressColor = Color.FromArgb(64, 64, 64);
            txtExit.FillSelectedColor = Color.FromArgb(22, 94, 85);
            txtExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExit.ForeHoverColor = Color.Black;
            txtExit.Location = new Point(267, 353);
            txtExit.MinimumSize = new Size(1, 1);
            txtExit.Name = "txtExit";
            txtExit.Radius = 10;
            txtExit.RectColor = Color.White;
            txtExit.RectHoverColor = Color.White;
            txtExit.RectPressColor = Color.Silver;
            txtExit.RectSelectedColor = Color.FromArgb(22, 94, 85);
            txtExit.Size = new Size(312, 35);
            txtExit.TabIndex = 22;
            txtExit.Text = "Cerrar lista del dia";
            txtExit.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // modernGrid1
            // 
            modernGrid1.AllowUserToAddRows = false;
            modernGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            modernGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            modernGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modernGrid1.BackgroundColor = Color.White;
            modernGrid1.BorderStyle = BorderStyle.None;
            modernGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            modernGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            modernGrid1.ColumnHeadersHeight = 44;
            modernGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            modernGrid1.Columns.AddRange(new DataGridViewColumn[] { Carnet, Estudiante, Hora, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            modernGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            modernGrid1.EnableHeadersVisualStyles = false;
            modernGrid1.Font = new Font("Segoe UI", 9.5F);
            modernGrid1.GridColor = Color.White;
            modernGrid1.Location = new Point(22, 53);
            modernGrid1.MultiSelect = false;
            modernGrid1.Name = "modernGrid1";
            modernGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            modernGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            modernGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            modernGrid1.RowTemplate.Height = 56;
            modernGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modernGrid1.ShowCellToolTips = false;
            modernGrid1.Size = new Size(557, 294);
            modernGrid1.TabIndex = 21;
            // 
            // Carnet
            // 
            Carnet.FillWeight = 74F;
            Carnet.HeaderText = "Carnet";
            Carnet.MinimumWidth = 74;
            Carnet.Name = "Carnet";
            Carnet.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Estudiante
            // 
            Estudiante.FillWeight = 98F;
            Estudiante.HeaderText = "Estudiante";
            Estudiante.MinimumWidth = 98;
            Estudiante.Name = "Estudiante";
            Estudiante.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Hora
            // 
            Hora.FillWeight = 115F;
            Hora.HeaderText = "Hora Ingreso";
            Hora.MinimumWidth = 115;
            Hora.Name = "Hora";
            Hora.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Estado
            // 
            Estado.FillWeight = 74F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 74;
            Estado.Name = "Estado";
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtPendientes
            // 
            txtPendientes.BackColor = Color.White;
            txtPendientes.Enabled = false;
            txtPendientes.FillColor = Color.FromArgb(230, 235, 241);
            txtPendientes.FillDisableColor = Color.FromArgb(230, 235, 241);
            txtPendientes.FillReadOnlyColor = Color.FromArgb(230, 235, 241);
            txtPendientes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtPendientes.ForeColor = Color.FromArgb(58, 80, 103);
            txtPendientes.ForeDisableColor = Color.FromArgb(58, 80, 103);
            txtPendientes.ForeReadOnlyColor = Color.FromArgb(58, 80, 103);
            txtPendientes.Location = new Point(482, 7);
            txtPendientes.Margin = new Padding(4, 5, 4, 5);
            txtPendientes.MinimumSize = new Size(1, 16);
            txtPendientes.Name = "txtPendientes";
            txtPendientes.Padding = new Padding(5);
            txtPendientes.Radius = 16;
            txtPendientes.ReadOnly = true;
            txtPendientes.RectColor = Color.White;
            txtPendientes.RectDisableColor = Color.White;
            txtPendientes.RectReadOnlyColor = Color.White;
            txtPendientes.ShowText = false;
            txtPendientes.Size = new Size(105, 23);
            txtPendientes.SymbolColor = Color.FromArgb(244, 161, 65);
            txtPendientes.TabIndex = 20;
            txtPendientes.Text = "Pendientes";
            txtPendientes.TextAlignment = ContentAlignment.MiddleLeft;
            txtPendientes.Watermark = "";
            // 
            // txtTardes
            // 
            txtTardes.BackColor = Color.White;
            txtTardes.Enabled = false;
            txtTardes.FillColor = Color.FromArgb(255, 242, 223);
            txtTardes.FillDisableColor = Color.FromArgb(255, 242, 223);
            txtTardes.FillReadOnlyColor = Color.FromArgb(255, 242, 223);
            txtTardes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTardes.ForeColor = Color.FromArgb(114, 84, 0);
            txtTardes.ForeDisableColor = Color.FromArgb(114, 84, 0);
            txtTardes.ForeReadOnlyColor = Color.FromArgb(114, 84, 0);
            txtTardes.Location = new Point(388, 7);
            txtTardes.Margin = new Padding(4, 5, 4, 5);
            txtTardes.MinimumSize = new Size(1, 16);
            txtTardes.Name = "txtTardes";
            txtTardes.Padding = new Padding(5);
            txtTardes.Radius = 16;
            txtTardes.ReadOnly = true;
            txtTardes.RectColor = Color.White;
            txtTardes.RectDisableColor = Color.White;
            txtTardes.RectReadOnlyColor = Color.White;
            txtTardes.ShowText = false;
            txtTardes.Size = new Size(82, 23);
            txtTardes.SymbolColor = Color.FromArgb(11, 127, 92);
            txtTardes.TabIndex = 19;
            txtTardes.Text = "Tardes";
            txtTardes.TextAlignment = ContentAlignment.MiddleLeft;
            txtTardes.Watermark = "";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(94, 105, 99);
            label9.Location = new Point(14, 4);
            label9.Name = "label9";
            label9.Size = new Size(153, 23);
            label9.TabIndex = 3;
            label9.Text = "Asistencia de hoy";
            // 
            // txtPresentes
            // 
            txtPresentes.BackColor = Color.White;
            txtPresentes.Enabled = false;
            txtPresentes.FillColor = Color.FromArgb(221, 243, 240);
            txtPresentes.FillDisableColor = Color.FromArgb(221, 243, 240);
            txtPresentes.FillReadOnlyColor = Color.FromArgb(221, 243, 240);
            txtPresentes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPresentes.ForeColor = Color.FromArgb(12, 92, 86);
            txtPresentes.ForeDisableColor = Color.FromArgb(12, 92, 86);
            txtPresentes.ForeReadOnlyColor = Color.FromArgb(12, 92, 86);
            txtPresentes.Location = new Point(275, 7);
            txtPresentes.Margin = new Padding(4, 5, 4, 5);
            txtPresentes.MinimumSize = new Size(1, 16);
            txtPresentes.Name = "txtPresentes";
            txtPresentes.Padding = new Padding(5);
            txtPresentes.Radius = 19;
            txtPresentes.ReadOnly = true;
            txtPresentes.RectColor = Color.White;
            txtPresentes.RectDisableColor = Color.White;
            txtPresentes.RectReadOnlyColor = Color.White;
            txtPresentes.ShowText = false;
            txtPresentes.Size = new Size(105, 23);
            txtPresentes.SymbolColor = Color.FromArgb(9, 57, 43);
            txtPresentes.TabIndex = 18;
            txtPresentes.Text = "Presentes";
            txtPresentes.TextAlignment = ContentAlignment.MiddleLeft;
            txtPresentes.Watermark = "";
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 511);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Asistencia";
            Text = "Asistenica";
            panel1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modernGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private AntdUI.LabelTime labelTime;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private AntdUI.Label label3;
        private AntdUI.Input txtCarnet;
        private Sunny.UI.UIButton btnRegistrar;
        private Label label4;
        private Label label2;
        private Sunny.UI.UIPanel uiPanel2;
        private AntdUI.Label label5;
        private Label lblEstudiante;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox txtCarnetLeyenda;
        private Sunny.UI.UITextBox uiTextBox1;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UIPanel uiPanel3;
        private AntdUI.Label label9;
        private Sunny.UI.UITextBox txtPendientes;
        private UITextBox txtTardes;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox txtPresentes;
        private ModernControls.ModernGrid modernGrid1;
        private DataGridViewTextBoxColumn Carnet;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Estado;
        private UIButton txtExit;
    }
}