namespace Main
{
    partial class ArbolBinario
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
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            btnDelete = new Sunny.UI.UIButton();
            label3 = new AntdUI.Label();
            btnBuscar = new Sunny.UI.UIButton();
            txtElementos = new AntdUI.Input();
            btnBegin = new Sunny.UI.UIButton();
            label4 = new Label();
            uiPanel2 = new Sunny.UI.UIPanel();
            btnNiveles = new Sunny.UI.UIButton();
            btnPostOrden = new Sunny.UI.UIButton();
            btnInOrden = new Sunny.UI.UIButton();
            label5 = new AntdUI.Label();
            btnPreOrden = new Sunny.UI.UIButton();
            uiPanel3 = new Sunny.UI.UIPanel();
            label10 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            lblNodoRaiz = new AntdUI.Label();
            lblTotalNiveles = new AntdUI.Label();
            lblTotalNodo = new AntdUI.Label();
            PanelDibujo = new Sunny.UI.UIPanel();
            label11 = new AntdUI.Label();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel3.SuspendLayout();
            PanelDibujo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 59, 46);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 1;
            label1.Text = "Arbol Binario de Busqueda";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(94, 105, 99);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(555, 23);
            label2.TabIndex = 2;
            label2.Text = "Inserta, busca y elimina valores y observa los recorridos en tiempo real.";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnDelete);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(btnBuscar);
            uiPanel1.Controls.Add(txtElementos);
            uiPanel1.Controls.Add(btnBegin);
            uiPanel1.Controls.Add(label4);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(13, 91);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(242, 219);
            uiPanel1.TabIndex = 3;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.White;
            btnDelete.FillColor2 = Color.FromArgb(19, 68, 64);
            btnDelete.FillHoverColor = Color.FromArgb(255, 128, 128);
            btnDelete.FillPressColor = Color.Gray;
            btnDelete.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(178, 56, 43);
            btnDelete.Location = new Point(125, 161);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 10;
            btnDelete.RectColor = Color.FromArgb(178, 56, 43);
            btnDelete.RectHoverColor = Color.Red;
            btnDelete.RectPressColor = Color.White;
            btnDelete.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnDelete.Size = new Size(110, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Eliminar";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(94, 105, 99);
            label3.Location = new Point(14, 4);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 3;
            label3.Text = "OPERACIONES";
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.White;
            btnBuscar.FillColor2 = Color.FromArgb(19, 68, 64);
            btnBuscar.FillHoverColor = Color.FromArgb(15, 122, 92);
            btnBuscar.FillPressColor = Color.Gray;
            btnBuscar.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(15, 122, 92);
            btnBuscar.Location = new Point(6, 161);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 10;
            btnBuscar.RectColor = Color.FromArgb(15, 122, 92);
            btnBuscar.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnBuscar.RectPressColor = Color.Silver;
            btnBuscar.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnBuscar.Size = new Size(110, 35);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtElementos
            // 
            txtElementos.BadgeBack = Color.FromArgb(19, 68, 64);
            txtElementos.BadgeBorderColor = Color.AliceBlue;
            txtElementos.BorderActive = Color.FromArgb(22, 165, 117);
            txtElementos.BorderColor = Color.FromArgb(15, 122, 92);
            txtElementos.BorderHover = Color.FromArgb(19, 68, 64);
            txtElementos.BorderWidth = 2F;
            txtElementos.Location = new Point(6, 48);
            txtElementos.Name = "txtElementos";
            txtElementos.PlaceholderText = "Ej: 1";
            txtElementos.PrefixFormat = AntdUI.FormatFlags.HorizontalCenter;
            txtElementos.SelectionColor = Color.Turquoise;
            txtElementos.Size = new Size(231, 48);
            txtElementos.TabIndex = 10;
            // 
            // btnBegin
            // 
            btnBegin.FillColor = Color.FromArgb(15, 122, 92);
            btnBegin.FillColor2 = Color.FromArgb(19, 68, 64);
            btnBegin.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnBegin.FillPressColor = Color.FromArgb(22, 94, 85);
            btnBegin.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnBegin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBegin.Location = new Point(7, 106);
            btnBegin.MinimumSize = new Size(1, 1);
            btnBegin.Name = "btnBegin";
            btnBegin.Radius = 10;
            btnBegin.RectColor = Color.White;
            btnBegin.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnBegin.RectPressColor = Color.Silver;
            btnBegin.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnBegin.Size = new Size(228, 35);
            btnBegin.TabIndex = 9;
            btnBegin.Text = "Insertar";
            btnBegin.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBegin.Click += btnBegin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(18, 33, 26);
            label4.Location = new Point(14, 30);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(btnNiveles);
            uiPanel2.Controls.Add(btnPostOrden);
            uiPanel2.Controls.Add(btnInOrden);
            uiPanel2.Controls.Add(label5);
            uiPanel2.Controls.Add(btnPreOrden);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(13, 320);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel2.Size = new Size(242, 177);
            uiPanel2.TabIndex = 13;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnNiveles
            // 
            btnNiveles.FillColor = Color.FromArgb(238, 243, 239);
            btnNiveles.FillColor2 = Color.FromArgb(19, 68, 64);
            btnNiveles.FillHoverColor = Color.FromArgb(15, 122, 92);
            btnNiveles.FillPressColor = Color.Gray;
            btnNiveles.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnNiveles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNiveles.ForeColor = Color.FromArgb(22, 94, 85);
            btnNiveles.Location = new Point(125, 98);
            btnNiveles.MinimumSize = new Size(1, 1);
            btnNiveles.Name = "btnNiveles";
            btnNiveles.Radius = 10;
            btnNiveles.RectColor = Color.FromArgb(224, 224, 224);
            btnNiveles.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnNiveles.RectPressColor = Color.Silver;
            btnNiveles.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnNiveles.Size = new Size(110, 35);
            btnNiveles.TabIndex = 16;
            btnNiveles.Text = "Niveles";
            btnNiveles.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNiveles.Click += btnNiveles_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.FillColor = Color.FromArgb(238, 243, 239);
            btnPostOrden.FillColor2 = Color.FromArgb(19, 68, 64);
            btnPostOrden.FillHoverColor = Color.FromArgb(15, 122, 92);
            btnPostOrden.FillPressColor = Color.Gray;
            btnPostOrden.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnPostOrden.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostOrden.ForeColor = Color.FromArgb(22, 94, 85);
            btnPostOrden.Location = new Point(6, 98);
            btnPostOrden.MinimumSize = new Size(1, 1);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Radius = 10;
            btnPostOrden.RectColor = Color.FromArgb(224, 224, 224);
            btnPostOrden.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnPostOrden.RectPressColor = Color.Silver;
            btnPostOrden.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnPostOrden.Size = new Size(110, 35);
            btnPostOrden.TabIndex = 15;
            btnPostOrden.Text = "PostOrden";
            btnPostOrden.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.FillColor = Color.FromArgb(238, 243, 239);
            btnInOrden.FillColor2 = Color.FromArgb(19, 68, 64);
            btnInOrden.FillHoverColor = Color.FromArgb(15, 122, 92);
            btnInOrden.FillPressColor = Color.Gray;
            btnInOrden.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnInOrden.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInOrden.ForeColor = Color.FromArgb(22, 94, 85);
            btnInOrden.Location = new Point(124, 57);
            btnInOrden.MinimumSize = new Size(1, 1);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Radius = 10;
            btnInOrden.RectColor = Color.FromArgb(224, 224, 224);
            btnInOrden.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnInOrden.RectPressColor = Color.Silver;
            btnInOrden.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnInOrden.Size = new Size(110, 35);
            btnInOrden.TabIndex = 14;
            btnInOrden.Text = "InOrden";
            btnInOrden.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInOrden.Click += btnInOrden_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(94, 105, 99);
            label5.Location = new Point(13, 14);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 13;
            label5.Text = "RECORRIDOS";
            // 
            // btnPreOrden
            // 
            btnPreOrden.FillColor = Color.FromArgb(238, 243, 239);
            btnPreOrden.FillColor2 = Color.FromArgb(19, 68, 64);
            btnPreOrden.FillHoverColor = Color.FromArgb(15, 122, 92);
            btnPreOrden.FillPressColor = Color.Gray;
            btnPreOrden.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnPreOrden.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreOrden.ForeColor = Color.FromArgb(22, 94, 85);
            btnPreOrden.Location = new Point(5, 57);
            btnPreOrden.MinimumSize = new Size(1, 1);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Radius = 10;
            btnPreOrden.RectColor = Color.FromArgb(224, 224, 224);
            btnPreOrden.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnPreOrden.RectPressColor = Color.Silver;
            btnPreOrden.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnPreOrden.Size = new Size(110, 35);
            btnPreOrden.TabIndex = 11;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreOrden.Click += uiButton2_Click;
            // 
            // uiPanel3
            // 
            uiPanel3.BackColor = Color.White;
            uiPanel3.Controls.Add(label10);
            uiPanel3.Controls.Add(label9);
            uiPanel3.Controls.Add(label8);
            uiPanel3.Controls.Add(lblNodoRaiz);
            uiPanel3.Controls.Add(lblTotalNiveles);
            uiPanel3.Controls.Add(lblTotalNodo);
            uiPanel3.FillColor = Color.FromArgb(10, 61, 46);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(13, 507);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 15;
            uiPanel3.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel3.Size = new Size(242, 98);
            uiPanel3.TabIndex = 14;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel3.Click += uiPanel3_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(129, 177, 161);
            label10.Location = new Point(165, 55);
            label10.Name = "label10";
            label10.Size = new Size(69, 23);
            label10.TabIndex = 16;
            label10.Text = "Nodo Raiz";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(129, 177, 161);
            label9.Location = new Point(93, 55);
            label9.Name = "label9";
            label9.Size = new Size(56, 23);
            label9.TabIndex = 15;
            label9.Text = "Niveles";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(129, 177, 161);
            label8.Location = new Point(15, 54);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 14;
            label8.Text = "Nodos";
            // 
            // lblNodoRaiz
            // 
            lblNodoRaiz.BackColor = Color.Transparent;
            lblNodoRaiz.Enabled = false;
            lblNodoRaiz.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNodoRaiz.ForeColor = Color.White;
            lblNodoRaiz.Location = new Point(177, 21);
            lblNodoRaiz.Name = "lblNodoRaiz";
            lblNodoRaiz.Size = new Size(39, 38);
            lblNodoRaiz.TabIndex = 6;
            lblNodoRaiz.Text = "7";
            // 
            // lblTotalNiveles
            // 
            lblTotalNiveles.BackColor = Color.Transparent;
            lblTotalNiveles.Enabled = false;
            lblTotalNiveles.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNiveles.ForeColor = Color.White;
            lblTotalNiveles.Location = new Point(100, 21);
            lblTotalNiveles.Name = "lblTotalNiveles";
            lblTotalNiveles.Size = new Size(39, 38);
            lblTotalNiveles.TabIndex = 5;
            lblTotalNiveles.Text = "7";
            // 
            // lblTotalNodo
            // 
            lblTotalNodo.BackColor = Color.Transparent;
            lblTotalNodo.Enabled = false;
            lblTotalNodo.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNodo.ForeColor = Color.White;
            lblTotalNodo.Location = new Point(24, 21);
            lblTotalNodo.Name = "lblTotalNodo";
            lblTotalNodo.Size = new Size(39, 38);
            lblTotalNodo.TabIndex = 4;
            lblTotalNodo.Text = "7";
            // 
            // PanelDibujo
            // 
            PanelDibujo.Controls.Add(label11);
            PanelDibujo.Font = new Font("Microsoft Sans Serif", 12F);
            PanelDibujo.Location = new Point(286, 91);
            PanelDibujo.Margin = new Padding(4, 5, 4, 5);
            PanelDibujo.MinimumSize = new Size(1, 1);
            PanelDibujo.Name = "PanelDibujo";
            PanelDibujo.Radius = 15;
            PanelDibujo.RectColor = Color.FromArgb(224, 224, 224);
            PanelDibujo.Size = new Size(854, 525);
            PanelDibujo.TabIndex = 15;
            PanelDibujo.Text = null;
            PanelDibujo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(94, 105, 99);
            label11.Location = new Point(14, 4);
            label11.Name = "label11";
            label11.Size = new Size(115, 23);
            label11.TabIndex = 3;
            label11.Text = "VISTA DEL ARBOL";
            // 
            // ArbolBinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 630);
            Controls.Add(PanelDibujo);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ArbolBinario";
            Text = "ArbolBinario";
            Load += ArbolBinario_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            PanelDibujo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private Sunny.UI.UIPanel uiPanel1;
        private AntdUI.Label label3;
        private AntdUI.Input txtElementos;
        private Sunny.UI.UIButton btnBegin;
        private Label label4;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnBuscar;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnPreOrden;
        private AntdUI.Label label5;
        private Sunny.UI.UIButton btnNiveles;
        private Sunny.UI.UIButton btnPostOrden;
        private Sunny.UI.UIButton btnInOrden;
        private Sunny.UI.UIPanel uiPanel3;
        private AntdUI.Label lblTotalNodo;
        private AntdUI.Label label8;
        private AntdUI.Label lblNodoRaiz;
        private AntdUI.Label lblTotalNiveles;
        private AntdUI.Label label10;
        private AntdUI.Label label9;
        private Sunny.UI.UIPanel PanelDibujo;
        private AntdUI.Label label11;
    }
}