namespace Main
{
    partial class Ejercicio1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnBegin = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            label4 = new Label();
            label3 = new Label();
            rtbEmpty = new Sunny.UI.UIRichTextBox();
            label7 = new Label();
            label6 = new Label();
            rtbSize = new Sunny.UI.UIRichTextBox();
            label9 = new Label();
            lblSize = new Label();
            btnEmpty = new Sunny.UI.UIButton();
            btnSize = new Sunny.UI.UIButton();
            btnPeek = new Sunny.UI.UIButton();
            txtElementos = new AntdUI.Input();
            btnDequeue = new Sunny.UI.UIButton();
            label2 = new Label();
            pnlCola = new Sunny.UI.UIPanel();
            label8 = new Label();
            uiPanel3 = new Sunny.UI.UIPanel();
            rtbLeyenda = new Sunny.UI.UIRichTextBox();
            label10 = new Label();
            label11 = new Label();
            label5 = new Label();
            uiPanel1.SuspendLayout();
            rtbEmpty.SuspendLayout();
            rtbSize.SuspendLayout();
            pnlCola.SuspendLayout();
            uiPanel3.SuspendLayout();
            rtbLeyenda.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 94, 85);
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "Operaciones";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnBegin
            // 
            btnBegin.FillColor = Color.FromArgb(19, 68, 64);
            btnBegin.FillColor2 = Color.FromArgb(19, 68, 64);
            btnBegin.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnBegin.FillPressColor = Color.FromArgb(22, 94, 85);
            btnBegin.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnBegin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBegin.Location = new Point(13, 116);
            btnBegin.MinimumSize = new Size(1, 1);
            btnBegin.Name = "btnBegin";
            btnBegin.Radius = 10;
            btnBegin.RectColor = Color.FromArgb(19, 68, 64);
            btnBegin.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnBegin.RectPressColor = Color.Silver;
            btnBegin.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnBegin.Size = new Size(228, 35);
            btnBegin.TabIndex = 5;
            btnBegin.Text = "Comenzar";
            btnBegin.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBegin.Click += btnBegin_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(label4);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(rtbEmpty);
            uiPanel1.Controls.Add(rtbSize);
            uiPanel1.Controls.Add(btnEmpty);
            uiPanel1.Controls.Add(btnSize);
            uiPanel1.Controls.Add(btnPeek);
            uiPanel1.Controls.Add(txtElementos);
            uiPanel1.Controls.Add(btnDequeue);
            uiPanel1.Controls.Add(btnBegin);
            uiPanel1.Controls.Add(label2);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(11, 14);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 20;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(258, 422);
            uiPanel1.TabIndex = 6;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 94, 85);
            label4.Location = new Point(141, 309);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 12;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 94, 85);
            label3.Location = new Point(13, 309);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 11;
            label3.Text = "Tamaño";
            // 
            // rtbEmpty
            // 
            rtbEmpty.Controls.Add(label7);
            rtbEmpty.Controls.Add(label6);
            rtbEmpty.FillColor = Color.White;
            rtbEmpty.Font = new Font("Microsoft Sans Serif", 12F);
            rtbEmpty.Location = new Point(141, 335);
            rtbEmpty.Margin = new Padding(4, 5, 4, 5);
            rtbEmpty.MinimumSize = new Size(1, 1);
            rtbEmpty.Name = "rtbEmpty";
            rtbEmpty.Padding = new Padding(2);
            rtbEmpty.Radius = 10;
            rtbEmpty.ReadOnly = true;
            rtbEmpty.RectColor = Color.FromArgb(224, 224, 224);
            rtbEmpty.ShowText = false;
            rtbEmpty.Size = new Size(100, 63);
            rtbEmpty.TabIndex = 8;
            rtbEmpty.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 94, 85);
            label7.Location = new Point(19, 18);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 13;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 94, 85);
            label6.Location = new Point(5, 18);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 13;
            label6.Text = "Estado";
            // 
            // rtbSize
            // 
            rtbSize.Controls.Add(label9);
            rtbSize.Controls.Add(lblSize);
            rtbSize.FillColor = Color.White;
            rtbSize.Font = new Font("Microsoft Sans Serif", 12F);
            rtbSize.Location = new Point(13, 335);
            rtbSize.Margin = new Padding(4, 5, 4, 5);
            rtbSize.MinimumSize = new Size(1, 1);
            rtbSize.Name = "rtbSize";
            rtbSize.Padding = new Padding(2);
            rtbSize.Radius = 10;
            rtbSize.ReadOnly = true;
            rtbSize.RectColor = Color.FromArgb(224, 224, 224);
            rtbSize.ShowText = false;
            rtbSize.Size = new Size(100, 63);
            rtbSize.TabIndex = 7;
            rtbSize.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 94, 85);
            label9.Location = new Point(18, 18);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 13;
            label9.Text = "Tamaño";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.FromArgb(22, 94, 85);
            lblSize.Location = new Point(7, 18);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(66, 21);
            lblSize.TabIndex = 13;
            lblSize.Text = "Tamaño";
            // 
            // btnEmpty
            // 
            btnEmpty.FillColor = Color.White;
            btnEmpty.FillColor2 = Color.White;
            btnEmpty.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnEmpty.FillPressColor = Color.Silver;
            btnEmpty.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnEmpty.Font = new Font("Microsoft Sans Serif", 12F);
            btnEmpty.ForeColor = Color.FromArgb(19, 68, 64);
            btnEmpty.Location = new Point(143, 248);
            btnEmpty.MinimumSize = new Size(1, 1);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Radius = 10;
            btnEmpty.RectColor = Color.FromArgb(19, 68, 64);
            btnEmpty.RectHoverColor = Color.White;
            btnEmpty.RectPressColor = Color.White;
            btnEmpty.RectSelectedColor = Color.White;
            btnEmpty.Size = new Size(100, 35);
            btnEmpty.TabIndex = 10;
            btnEmpty.Text = "Empty?";
            btnEmpty.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEmpty.Click += btnEmpty_Click;
            // 
            // btnSize
            // 
            btnSize.FillColor = Color.White;
            btnSize.FillColor2 = Color.White;
            btnSize.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnSize.FillPressColor = Color.Silver;
            btnSize.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnSize.Font = new Font("Microsoft Sans Serif", 12F);
            btnSize.ForeColor = Color.FromArgb(19, 68, 64);
            btnSize.Location = new Point(12, 248);
            btnSize.MinimumSize = new Size(1, 1);
            btnSize.Name = "btnSize";
            btnSize.Radius = 10;
            btnSize.RectColor = Color.FromArgb(19, 68, 64);
            btnSize.RectHoverColor = Color.White;
            btnSize.RectPressColor = Color.White;
            btnSize.RectSelectedColor = Color.White;
            btnSize.Size = new Size(100, 35);
            btnSize.TabIndex = 9;
            btnSize.Text = "Size";
            btnSize.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSize.Click += btnSize_Click;
            // 
            // btnPeek
            // 
            btnPeek.FillColor = Color.White;
            btnPeek.FillColor2 = Color.White;
            btnPeek.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnPeek.FillPressColor = Color.Silver;
            btnPeek.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnPeek.Font = new Font("Microsoft Sans Serif", 12F);
            btnPeek.ForeColor = Color.FromArgb(19, 68, 64);
            btnPeek.Location = new Point(141, 191);
            btnPeek.MinimumSize = new Size(1, 1);
            btnPeek.Name = "btnPeek";
            btnPeek.Radius = 10;
            btnPeek.RectColor = Color.FromArgb(19, 68, 64);
            btnPeek.RectHoverColor = Color.White;
            btnPeek.RectPressColor = Color.White;
            btnPeek.RectSelectedColor = Color.White;
            btnPeek.Size = new Size(100, 35);
            btnPeek.TabIndex = 8;
            btnPeek.Text = "Peek";
            btnPeek.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnPeek.Click += btnPeek_Click;
            // 
            // txtElementos
            // 
            txtElementos.BadgeBack = Color.FromArgb(19, 68, 64);
            txtElementos.BadgeBorderColor = Color.AliceBlue;
            txtElementos.BorderActive = Color.FromArgb(19, 68, 64);
            txtElementos.BorderHover = Color.FromArgb(19, 68, 64);
            txtElementos.Location = new Point(12, 58);
            txtElementos.Name = "txtElementos";
            txtElementos.PlaceholderText = "Ej: 1";
            txtElementos.SelectionColor = Color.White;
            txtElementos.Size = new Size(231, 48);
            txtElementos.TabIndex = 7;
            // 
            // btnDequeue
            // 
            btnDequeue.FillColor = Color.White;
            btnDequeue.FillColor2 = Color.White;
            btnDequeue.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnDequeue.FillPressColor = Color.Silver;
            btnDequeue.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnDequeue.Font = new Font("Microsoft Sans Serif", 12F);
            btnDequeue.ForeColor = Color.FromArgb(19, 68, 64);
            btnDequeue.Location = new Point(13, 191);
            btnDequeue.MinimumSize = new Size(1, 1);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Radius = 10;
            btnDequeue.RectColor = Color.FromArgb(19, 68, 64);
            btnDequeue.RectHoverColor = Color.White;
            btnDequeue.RectPressColor = Color.White;
            btnDequeue.RectSelectedColor = Color.White;
            btnDequeue.Size = new Size(100, 35);
            btnDequeue.TabIndex = 7;
            btnDequeue.Text = "Dequeue";
            btnDequeue.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDequeue.Click += btnDequeue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 94, 85);
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el elemento";
            // 
            // pnlCola
            // 
            pnlCola.Anchor = AnchorStyles.Top;
            pnlCola.Controls.Add(label8);
            pnlCola.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCola.Location = new Point(277, 14);
            pnlCola.Margin = new Padding(4, 5, 4, 5);
            pnlCola.MinimumSize = new Size(1, 1);
            pnlCola.Name = "pnlCola";
            pnlCola.Radius = 20;
            pnlCola.RectColor = Color.FromArgb(224, 224, 224);
            pnlCola.Size = new Size(510, 226);
            pnlCola.TabIndex = 7;
            pnlCola.Text = null;
            pnlCola.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 94, 85);
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(224, 20);
            label8.TabIndex = 2;
            label8.Text = "Cola (Demostracion Grafica)";
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top;
            uiPanel3.Controls.Add(rtbLeyenda);
            uiPanel3.Controls.Add(label5);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(277, 262);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 20;
            uiPanel3.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel3.Size = new Size(510, 174);
            uiPanel3.TabIndex = 8;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // rtbLeyenda
            // 
            rtbLeyenda.Controls.Add(label10);
            rtbLeyenda.Controls.Add(label11);
            rtbLeyenda.FillColor = Color.White;
            rtbLeyenda.Font = new Font("Microsoft Sans Serif", 12F);
            rtbLeyenda.Location = new Point(17, 56);
            rtbLeyenda.Margin = new Padding(4, 5, 4, 5);
            rtbLeyenda.MinimumSize = new Size(1, 1);
            rtbLeyenda.Name = "rtbLeyenda";
            rtbLeyenda.Padding = new Padding(2);
            rtbLeyenda.Radius = 10;
            rtbLeyenda.ReadOnly = true;
            rtbLeyenda.RectColor = Color.FromArgb(224, 224, 224);
            rtbLeyenda.ShowText = false;
            rtbLeyenda.Size = new Size(473, 94);
            rtbLeyenda.TabIndex = 9;
            rtbLeyenda.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(22, 94, 85);
            label10.Location = new Point(19, 18);
            label10.Name = "label10";
            label10.Size = new Size(56, 21);
            label10.TabIndex = 13;
            label10.Text = "Estado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(22, 94, 85);
            label11.Location = new Point(5, 18);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 13;
            label11.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 94, 85);
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 2;
            label5.Text = "Registro de operaciones";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCola);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel1);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            rtbEmpty.ResumeLayout(false);
            rtbEmpty.PerformLayout();
            rtbSize.ResumeLayout(false);
            rtbSize.PerformLayout();
            pnlCola.ResumeLayout(false);
            pnlCola.PerformLayout();
            uiPanel3.ResumeLayout(false);
            uiPanel3.PerformLayout();
            rtbLeyenda.ResumeLayout(false);
            rtbLeyenda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Sunny.UI.UIButton btnBegin;
        private Sunny.UI.UIPanel uiPanel1;
        private Label label2;
        private AntdUI.Input txtElementos;
        private Sunny.UI.UIButton btnDequeue;
        private Sunny.UI.UIButton btnEmpty;
        private Sunny.UI.UIButton btnSize;
        private Sunny.UI.UIButton btnPeek;
        private Sunny.UI.UIRichTextBox rtbEmpty;
        private Sunny.UI.UIRichTextBox rtbSize;
        private Label label3;
        private Label label4;
        private Sunny.UI.UIPanel pnlCola;
        private Label label8;
        private Sunny.UI.UIPanel uiPanel3;
        private Label label5;
        private Label label6;
        private Label lblSize;
        private Label label7;
        private Label label9;
        private Sunny.UI.UIRichTextBox rtbLeyenda;
        private Label label10;
        private Label label11;
    }
}