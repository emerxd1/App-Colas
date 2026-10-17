namespace Main
{
    partial class Ejercicio3
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvClients = new Sunny.UI.UIDataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Espera = new DataGridViewTextBoxColumn();
            Inicio = new DataGridViewTextBoxColumn();
            Termina = new DataGridViewTextBoxColumn();
            uiPanel1 = new Sunny.UI.UIPanel();
            txtElementos = new AntdUI.Input();
            btnSimular = new Sunny.UI.UIButton();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlTimewait = new Sunny.UI.UIPanel();
            uiPanel6 = new Sunny.UI.UIPanel();
            label7 = new Label();
            label9 = new Label();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            uiPanel1.SuspendLayout();
            pnlTimewait.SuspendLayout();
            uiPanel6.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AllowUserToResizeColumns = false;
            dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClients.Anchor = AnchorStyles.Top;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(19, 68, 64);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvClients.ColumnHeadersHeight = 32;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { Cliente, Duracion, Espera, Inicio, Termina });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle8;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.Font = new Font("Microsoft Sans Serif", 12F);
            dgvClients.GridColor = Color.White;
            dgvClients.Location = new Point(7, 11);
            dgvClients.Name = "dgvClients";
            dgvClients.RectColor = Color.FromArgb(19, 68, 64);
            dgvClients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvClients.ScrollBarColor = Color.FromArgb(19, 68, 64);
            dgvClients.ScrollBarRectColor = Color.FromArgb(19, 68, 64);
            dgvClients.ScrollBars = ScrollBars.Horizontal;
            dgvClients.ScrollBarStyleInherited = false;
            dgvClients.SelectedIndex = -1;
            dgvClients.Size = new Size(561, 150);
            dgvClients.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvClients.TabIndex = 0;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            // 
            // Espera
            // 
            Espera.HeaderText = "Tiempo de espera";
            Espera.Name = "Espera";
            Espera.Width = 160;
            // 
            // Inicio
            // 
            Inicio.HeaderText = "Hora inicio";
            Inicio.Name = "Inicio";
            // 
            // Termina
            // 
            Termina.HeaderText = "Hora fin";
            Termina.Name = "Termina";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(txtElementos);
            uiPanel1.Controls.Add(btnSimular);
            uiPanel1.Controls.Add(label5);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(11, 50);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 20;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(774, 91);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtElementos
            // 
            txtElementos.BadgeBack = Color.FromArgb(19, 68, 64);
            txtElementos.BadgeBorderColor = Color.AliceBlue;
            txtElementos.BorderActive = Color.FromArgb(19, 68, 64);
            txtElementos.BorderHover = Color.FromArgb(19, 68, 64);
            txtElementos.Location = new Point(14, 33);
            txtElementos.Name = "txtElementos";
            txtElementos.PlaceholderText = "Ej: 1,2,3,4......";
            txtElementos.SelectionColor = Color.White;
            txtElementos.Size = new Size(565, 35);
            txtElementos.TabIndex = 7;
            // 
            // btnSimular
            // 
            btnSimular.FillColor = Color.FromArgb(19, 68, 64);
            btnSimular.FillColor2 = Color.FromArgb(19, 68, 64);
            btnSimular.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnSimular.FillPressColor = Color.FromArgb(22, 94, 85);
            btnSimular.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnSimular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimular.Location = new Point(585, 33);
            btnSimular.MinimumSize = new Size(1, 1);
            btnSimular.Name = "btnSimular";
            btnSimular.Radius = 10;
            btnSimular.RectColor = Color.FromArgb(19, 68, 64);
            btnSimular.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnSimular.RectPressColor = Color.Silver;
            btnSimular.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnSimular.Size = new Size(176, 35);
            btnSimular.TabIndex = 5;
            btnSimular.Text = "Simular";
            btnSimular.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 94, 85);
            label5.Location = new Point(22, 15);
            label5.Name = "label5";
            label5.Size = new Size(255, 15);
            label5.TabIndex = 3;
            label5.Text = "Duracion de cada cliente (separados por coma)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 94, 85);
            label2.Location = new Point(25, 28);
            label2.Name = "label2";
            label2.Size = new Size(493, 17);
            label2.TabIndex = 9;
            label2.Text = "Una sola caja, clientes atendidos en orden de llegada (todos llegan en el minuto 0)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 94, 85);
            label1.Location = new Point(19, 4);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 8;
            label1.Text = "Simulacion de un banco";
            // 
            // pnlTimewait
            // 
            pnlTimewait.Anchor = AnchorStyles.Top;
            pnlTimewait.Controls.Add(uiPanel6);
            pnlTimewait.Controls.Add(label9);
            pnlTimewait.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTimewait.Location = new Point(590, 151);
            pnlTimewait.Margin = new Padding(4, 5, 4, 5);
            pnlTimewait.MinimumSize = new Size(1, 1);
            pnlTimewait.Name = "pnlTimewait";
            pnlTimewait.Radius = 20;
            pnlTimewait.RectColor = Color.FromArgb(224, 224, 224);
            pnlTimewait.Size = new Size(201, 183);
            pnlTimewait.TabIndex = 11;
            pnlTimewait.Text = null;
            pnlTimewait.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            uiPanel6.Controls.Add(label7);
            uiPanel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel6.Location = new Point(263, 0);
            uiPanel6.Margin = new Padding(4, 5, 4, 5);
            uiPanel6.MinimumSize = new Size(1, 1);
            uiPanel6.Name = "uiPanel6";
            uiPanel6.Radius = 20;
            uiPanel6.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel6.Size = new Size(252, 226);
            uiPanel6.TabIndex = 8;
            uiPanel6.Text = null;
            uiPanel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 94, 85);
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(224, 20);
            label7.TabIndex = 2;
            label7.Text = "Cola (Demostracion Grafica)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 94, 85);
            label9.Location = new Point(6, 9);
            label9.Name = "label9";
            label9.Size = new Size(181, 15);
            label9.TabIndex = 2;
            label9.Text = "Tiempo de espera Promedio\r\n";
            // 
            // uiPanel2
            // 
            uiPanel2.Anchor = AnchorStyles.Top;
            uiPanel2.Controls.Add(dgvClients);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(11, 149);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 20;
            uiPanel2.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel2.Size = new Size(574, 185);
            uiPanel2.TabIndex = 12;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top;
            uiPanel3.Controls.Add(label4);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(11, 344);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 20;
            uiPanel3.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel3.Size = new Size(776, 138);
            uiPanel3.TabIndex = 12;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 94, 85);
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 2;
            label4.Text = "Simulacion";
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(uiPanel3);
            Controls.Add(pnlTimewait);
            Controls.Add(uiPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uiPanel2);
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            Load += Ejercicio3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            pnlTimewait.ResumeLayout(false);
            pnlTimewait.PerformLayout();
            uiPanel6.ResumeLayout(false);
            uiPanel6.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView dgvClients;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnCrearCola;
        private AntdUI.Input txtElementos;
        private Sunny.UI.UIButton btnSimular;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Espera;
        private DataGridViewTextBoxColumn Inicio;
        private DataGridViewTextBoxColumn Termina;
        private Sunny.UI.UIPanel pnlTimewait;
        private Sunny.UI.UIPanel uiPanel6;
        private Label label7;
        private Label label9;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private Label label4;
    }
}