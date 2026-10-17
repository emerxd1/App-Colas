namespace Main
{
    partial class Ejercicio2
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
            label2 = new Label();
            label1 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            btnCrearCola = new Sunny.UI.UIButton();
            txtElementos = new AntdUI.Input();
            btnInvertir = new Sunny.UI.UIButton();
            label5 = new Label();
            pnlCola = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            label3 = new Label();
            label8 = new Label();
            pnlPilaAux = new Sunny.UI.UIPanel();
            uiPanel4 = new Sunny.UI.UIPanel();
            label4 = new Label();
            label6 = new Label();
            pnlColainvertida = new Sunny.UI.UIPanel();
            uiPanel6 = new Sunny.UI.UIPanel();
            label7 = new Label();
            label9 = new Label();
            uiPanel3 = new Sunny.UI.UIPanel();
            label12 = new Label();
            iconState2 = new AntdUI.IconState();
            label11 = new Label();
            iconState1 = new AntdUI.IconState();
            label10 = new Label();
            uiPanel5 = new Sunny.UI.UIPanel();
            rtbLeyenda = new Sunny.UI.UIRichTextBox();
            label14 = new Label();
            uiPanel1.SuspendLayout();
            pnlCola.SuspendLayout();
            uiPanel2.SuspendLayout();
            pnlPilaAux.SuspendLayout();
            uiPanel4.SuspendLayout();
            pnlColainvertida.SuspendLayout();
            uiPanel6.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 94, 85);
            label2.Location = new Point(27, 22);
            label2.Name = "label2";
            label2.Size = new Size(337, 17);
            label2.TabIndex = 5;
            label2.Text = "Usa una pila auxiliar: el que estaba al final pasa al frente";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 94, 85);
            label1.Location = new Point(21, -2);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 4;
            label1.Text = "Invertir una cola";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(btnCrearCola);
            uiPanel1.Controls.Add(txtElementos);
            uiPanel1.Controls.Add(btnInvertir);
            uiPanel1.Controls.Add(label5);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(13, 44);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 20;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(774, 91);
            uiPanel1.TabIndex = 7;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCrearCola
            // 
            btnCrearCola.FillColor = Color.White;
            btnCrearCola.FillColor2 = Color.White;
            btnCrearCola.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnCrearCola.FillPressColor = Color.Silver;
            btnCrearCola.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnCrearCola.Font = new Font("Microsoft Sans Serif", 12F);
            btnCrearCola.ForeColor = Color.FromArgb(19, 68, 64);
            btnCrearCola.Location = new Point(516, 33);
            btnCrearCola.MinimumSize = new Size(1, 1);
            btnCrearCola.Name = "btnCrearCola";
            btnCrearCola.Radius = 10;
            btnCrearCola.RectColor = Color.FromArgb(19, 68, 64);
            btnCrearCola.RectHoverColor = Color.White;
            btnCrearCola.RectPressColor = Color.White;
            btnCrearCola.RectSelectedColor = Color.White;
            btnCrearCola.Size = new Size(100, 35);
            btnCrearCola.TabIndex = 8;
            btnCrearCola.Text = "Crear";
            btnCrearCola.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCrearCola.Click += btnCrearCola_Click;
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
            txtElementos.Size = new Size(496, 35);
            txtElementos.TabIndex = 7;
            // 
            // btnInvertir
            // 
            btnInvertir.FillColor = Color.FromArgb(19, 68, 64);
            btnInvertir.FillColor2 = Color.FromArgb(19, 68, 64);
            btnInvertir.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnInvertir.FillPressColor = Color.FromArgb(22, 94, 85);
            btnInvertir.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnInvertir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvertir.Location = new Point(622, 33);
            btnInvertir.MinimumSize = new Size(1, 1);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Radius = 10;
            btnInvertir.RectColor = Color.FromArgb(19, 68, 64);
            btnInvertir.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnInvertir.RectPressColor = Color.Silver;
            btnInvertir.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnInvertir.Size = new Size(139, 35);
            btnInvertir.TabIndex = 5;
            btnInvertir.Text = "Invertir cola";
            btnInvertir.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvertir.Click += btnInvertir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 94, 85);
            label5.Location = new Point(22, 15);
            label5.Name = "label5";
            label5.Size = new Size(233, 15);
            label5.TabIndex = 3;
            label5.Text = "Elementos de la cola (separados por coma)";
            // 
            // pnlCola
            // 
            pnlCola.Anchor = AnchorStyles.Top;
            pnlCola.Controls.Add(uiPanel2);
            pnlCola.Controls.Add(label8);
            pnlCola.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCola.Location = new Point(13, 145);
            pnlCola.Margin = new Padding(4, 5, 4, 5);
            pnlCola.MinimumSize = new Size(1, 1);
            pnlCola.Name = "pnlCola";
            pnlCola.Radius = 20;
            pnlCola.RectColor = Color.FromArgb(224, 224, 224);
            pnlCola.Size = new Size(255, 226);
            pnlCola.TabIndex = 8;
            pnlCola.Text = null;
            pnlCola.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(label3);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(263, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 20;
            uiPanel2.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel2.Size = new Size(252, 226);
            uiPanel2.TabIndex = 8;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 94, 85);
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 2;
            label3.Text = "Cola (Demostracion Grafica)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 94, 85);
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 2;
            label8.Text = "Cola original";
            // 
            // pnlPilaAux
            // 
            pnlPilaAux.Anchor = AnchorStyles.Top;
            pnlPilaAux.Controls.Add(uiPanel4);
            pnlPilaAux.Controls.Add(label6);
            pnlPilaAux.Font = new Font("Microsoft Sans Serif", 12F);
            pnlPilaAux.Location = new Point(276, 145);
            pnlPilaAux.Margin = new Padding(4, 5, 4, 5);
            pnlPilaAux.MinimumSize = new Size(1, 1);
            pnlPilaAux.Name = "pnlPilaAux";
            pnlPilaAux.Radius = 20;
            pnlPilaAux.RectColor = Color.FromArgb(224, 224, 224);
            pnlPilaAux.Size = new Size(252, 226);
            pnlPilaAux.TabIndex = 9;
            pnlPilaAux.Text = null;
            pnlPilaAux.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(label4);
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel4.Location = new Point(263, 0);
            uiPanel4.Margin = new Padding(4, 5, 4, 5);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.Radius = 20;
            uiPanel4.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel4.Size = new Size(252, 226);
            uiPanel4.TabIndex = 8;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 94, 85);
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(224, 20);
            label4.TabIndex = 2;
            label4.Text = "Cola (Demostracion Grafica)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 94, 85);
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 2;
            label6.Text = "Pila auxiliar";
            // 
            // pnlColainvertida
            // 
            pnlColainvertida.Anchor = AnchorStyles.Top;
            pnlColainvertida.Controls.Add(uiPanel6);
            pnlColainvertida.Controls.Add(label9);
            pnlColainvertida.Font = new Font("Microsoft Sans Serif", 12F);
            pnlColainvertida.Location = new Point(536, 145);
            pnlColainvertida.Margin = new Padding(4, 5, 4, 5);
            pnlColainvertida.MinimumSize = new Size(1, 1);
            pnlColainvertida.Name = "pnlColainvertida";
            pnlColainvertida.Radius = 20;
            pnlColainvertida.RectColor = Color.FromArgb(224, 224, 224);
            pnlColainvertida.Size = new Size(251, 226);
            pnlColainvertida.TabIndex = 9;
            pnlColainvertida.Text = null;
            pnlColainvertida.TextAlignment = ContentAlignment.MiddleCenter;
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
            label9.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 94, 85);
            label9.Location = new Point(6, 9);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 2;
            label9.Text = "Cola invertida";
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top;
            uiPanel3.Controls.Add(label12);
            uiPanel3.Controls.Add(iconState2);
            uiPanel3.Controls.Add(label11);
            uiPanel3.Controls.Add(iconState1);
            uiPanel3.Controls.Add(label10);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(13, 387);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 20;
            uiPanel3.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel3.Size = new Size(456, 148);
            uiPanel3.TabIndex = 9;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(22, 94, 85);
            label12.Location = new Point(76, 95);
            label12.Name = "label12";
            label12.Size = new Size(298, 17);
            label12.TabIndex = 12;
            label12.Text = "Desapila con pop y vuelve a encolar con enqueue";
            // 
            // iconState2
            // 
            iconState2.Location = new Point(36, 89);
            iconState2.Name = "iconState2";
            iconState2.Size = new Size(48, 28);
            iconState2.TabIndex = 11;
            iconState2.Text = "iconState2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(22, 94, 85);
            label11.Location = new Point(76, 61);
            label11.Name = "label11";
            label11.Size = new Size(365, 17);
            label11.TabIndex = 10;
            label11.Text = "Saca cada elemento de la cola con dequeue y apila con push";
            // 
            // iconState1
            // 
            iconState1.Location = new Point(36, 55);
            iconState1.Name = "iconState1";
            iconState1.Size = new Size(48, 28);
            iconState1.TabIndex = 4;
            iconState1.Text = "iconState1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(22, 94, 85);
            label10.Location = new Point(22, 15);
            label10.Name = "label10";
            label10.Size = new Size(166, 21);
            label10.TabIndex = 3;
            label10.Text = "Pasos del algoritmo";
            // 
            // uiPanel5
            // 
            uiPanel5.Anchor = AnchorStyles.Top;
            uiPanel5.Controls.Add(rtbLeyenda);
            uiPanel5.Controls.Add(label14);
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel5.Location = new Point(481, 387);
            uiPanel5.Margin = new Padding(4, 5, 4, 5);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.Radius = 20;
            uiPanel5.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel5.Size = new Size(310, 152);
            uiPanel5.TabIndex = 10;
            uiPanel5.Text = null;
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // rtbLeyenda
            // 
            rtbLeyenda.FillColor = Color.White;
            rtbLeyenda.Font = new Font("Microsoft Sans Serif", 12F);
            rtbLeyenda.Location = new Point(20, 34);
            rtbLeyenda.Margin = new Padding(4, 5, 4, 5);
            rtbLeyenda.MinimumSize = new Size(1, 1);
            rtbLeyenda.Name = "rtbLeyenda";
            rtbLeyenda.Padding = new Padding(2);
            rtbLeyenda.Radius = 10;
            rtbLeyenda.ReadOnly = true;
            rtbLeyenda.RectColor = Color.FromArgb(224, 224, 224);
            rtbLeyenda.ShowText = false;
            rtbLeyenda.Size = new Size(273, 103);
            rtbLeyenda.TabIndex = 10;
            rtbLeyenda.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(22, 94, 85);
            label14.Location = new Point(6, 9);
            label14.Name = "label14";
            label14.Size = new Size(193, 20);
            label14.TabIndex = 2;
            label14.Text = "Registro de operaciones";
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 546);
            Controls.Add(uiPanel5);
            Controls.Add(uiPanel3);
            Controls.Add(pnlColainvertida);
            Controls.Add(pnlPilaAux);
            Controls.Add(pnlCola);
            Controls.Add(uiPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio2";
            Text = "Ejercicio2";
            Load += Ejercicio2_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            pnlCola.ResumeLayout(false);
            pnlCola.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            pnlPilaAux.ResumeLayout(false);
            pnlPilaAux.PerformLayout();
            uiPanel4.ResumeLayout(false);
            uiPanel4.PerformLayout();
            pnlColainvertida.ResumeLayout(false);
            pnlColainvertida.PerformLayout();
            uiPanel6.ResumeLayout(false);
            uiPanel6.PerformLayout();
            uiPanel3.ResumeLayout(false);
            uiPanel3.PerformLayout();
            uiPanel5.ResumeLayout(false);
            uiPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnCrearCola;
        private AntdUI.Input txtElementos;
        private Sunny.UI.UIButton btnInvertir;
        private Label label5;
        private Sunny.UI.UIPanel pnlCola;
        private Sunny.UI.UIPanel uiPanel2;
        private Label label3;
        private Label label8;
        private Sunny.UI.UIPanel pnlPilaAux;
        private Sunny.UI.UIPanel uiPanel4;
        private Label label4;
        private Label label6;
        private Sunny.UI.UIPanel pnlColainvertida;
        private Sunny.UI.UIPanel uiPanel6;
        private Label label7;
        private Label label9;
        private Sunny.UI.UIPanel uiPanel3;
        private Label label10;
        private Label label11;
        private AntdUI.IconState iconState1;
        private Label label12;
        private AntdUI.IconState iconState2;
        private Sunny.UI.UIPanel uiPanel5;
        private Label label14;
        private Sunny.UI.UIRichTextBox rtbLeyenda;
    }
}