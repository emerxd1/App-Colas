namespace Main
{
    partial class Ejercicio4
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
            pnlCola = new Sunny.UI.UIPanel();
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            label9 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtN = new Sunny.UI.UIUpDownTextBox();
            btnGenerar = new Sunny.UI.UIButton();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlResultado = new Sunny.UI.UIPanel();
            rtbLeyenda = new Sunny.UI.UIRichTextBox();
            label3 = new Label();
            pnlCola.SuspendLayout();
            uiPanel1.SuspendLayout();
            pnlResultado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCola
            // 
            pnlCola.Anchor = AnchorStyles.Top;
            pnlCola.Controls.Add(uiRichTextBox1);
            pnlCola.Controls.Add(label9);
            pnlCola.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCola.Location = new Point(17, 342);
            pnlCola.Margin = new Padding(4, 5, 4, 5);
            pnlCola.MinimumSize = new Size(1, 1);
            pnlCola.Name = "pnlCola";
            pnlCola.Radius = 20;
            pnlCola.RectColor = Color.FromArgb(224, 224, 224);
            pnlCola.Size = new Size(774, 96);
            pnlCola.TabIndex = 16;
            pnlCola.Text = null;
            pnlCola.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiRichTextBox1.Location = new Point(14, 29);
            uiRichTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(2);
            uiRichTextBox1.Radius = 10;
            uiRichTextBox1.ReadOnly = true;
            uiRichTextBox1.RectColor = Color.FromArgb(224, 224, 224);
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(744, 54);
            uiRichTextBox1.TabIndex = 11;
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 94, 85);
            label9.Location = new Point(6, 9);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 2;
            label9.Text = "Cola formada";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(label7);
            uiPanel1.Controls.Add(label6);
            uiPanel1.Controls.Add(label4);
            uiPanel1.Controls.Add(txtN);
            uiPanel1.Controls.Add(btnGenerar);
            uiPanel1.Controls.Add(label5);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(17, 48);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 20;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(774, 91);
            uiPanel1.TabIndex = 15;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 94, 85);
            label7.Location = new Point(627, 58);
            label7.Name = "label7";
            label7.Size = new Size(76, 17);
            label7.TabIndex = 20;
            label7.Text = "Binario: 111";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 94, 85);
            label6.Location = new Point(627, 36);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 19;
            label6.Text = "Numero: 7";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 94, 85);
            label4.Location = new Point(627, 13);
            label4.Name = "label4";
            label4.Size = new Size(112, 17);
            label4.TabIndex = 18;
            label4.Text = "Ejemplo de salida";
            // 
            // txtN
            // 
            txtN.DoubleStep = 1D;
            txtN.Font = new Font("Microsoft Sans Serif", 12F);
            txtN.Location = new Point(14, 37);
            txtN.Margin = new Padding(4, 5, 4, 5);
            txtN.MinimumSize = new Size(1, 16);
            txtN.Name = "txtN";
            txtN.Padding = new Padding(5);
            txtN.Radius = 10;
            txtN.RectColor = Color.FromArgb(19, 68, 64);
            txtN.ShowText = false;
            txtN.Size = new Size(150, 29);
            txtN.TabIndex = 9;
            txtN.Text = "0";
            txtN.TextAlignment = ContentAlignment.MiddleRight;
            txtN.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            txtN.Watermark = "";
            // 
            // btnGenerar
            // 
            btnGenerar.FillColor = Color.FromArgb(19, 68, 64);
            btnGenerar.FillColor2 = Color.FromArgb(19, 68, 64);
            btnGenerar.FillHoverColor = Color.FromArgb(22, 94, 85);
            btnGenerar.FillPressColor = Color.FromArgb(22, 94, 85);
            btnGenerar.FillSelectedColor = Color.FromArgb(22, 94, 85);
            btnGenerar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(201, 37);
            btnGenerar.MinimumSize = new Size(1, 1);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Radius = 10;
            btnGenerar.RectColor = Color.FromArgb(19, 68, 64);
            btnGenerar.RectHoverColor = Color.FromArgb(22, 94, 85);
            btnGenerar.RectPressColor = Color.Silver;
            btnGenerar.RectSelectedColor = Color.FromArgb(22, 94, 85);
            btnGenerar.Size = new Size(176, 35);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 94, 85);
            label5.Location = new Point(14, 13);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad de numeros";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 94, 85);
            label2.Location = new Point(31, 26);
            label2.Name = "label2";
            label2.Size = new Size(406, 17);
            label2.TabIndex = 14;
            label2.Text = "Genera los primeros n binarios positivos sin usar conversion directa";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 94, 85);
            label1.Location = new Point(25, 2);
            label1.Name = "label1";
            label1.Size = new Size(304, 25);
            label1.TabIndex = 13;
            label1.Text = "Numeros binarios con una cola";
            // 
            // pnlResultado
            // 
            pnlResultado.Anchor = AnchorStyles.Top;
            pnlResultado.Controls.Add(rtbLeyenda);
            pnlResultado.Controls.Add(label3);
            pnlResultado.Font = new Font("Microsoft Sans Serif", 12F);
            pnlResultado.Location = new Point(17, 147);
            pnlResultado.Margin = new Padding(4, 5, 4, 5);
            pnlResultado.MinimumSize = new Size(1, 1);
            pnlResultado.Name = "pnlResultado";
            pnlResultado.Radius = 20;
            pnlResultado.RectColor = Color.FromArgb(224, 224, 224);
            pnlResultado.Size = new Size(774, 185);
            pnlResultado.TabIndex = 17;
            pnlResultado.Text = null;
            pnlResultado.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // rtbLeyenda
            // 
            rtbLeyenda.FillColor = Color.White;
            rtbLeyenda.Font = new Font("Microsoft Sans Serif", 12F);
            rtbLeyenda.Location = new Point(14, 34);
            rtbLeyenda.Margin = new Padding(4, 5, 4, 5);
            rtbLeyenda.MinimumSize = new Size(1, 1);
            rtbLeyenda.Name = "rtbLeyenda";
            rtbLeyenda.Padding = new Padding(2);
            rtbLeyenda.Radius = 10;
            rtbLeyenda.ReadOnly = true;
            rtbLeyenda.RectColor = Color.FromArgb(224, 224, 224);
            rtbLeyenda.ShowText = false;
            rtbLeyenda.Size = new Size(744, 121);
            rtbLeyenda.TabIndex = 10;
            rtbLeyenda.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 94, 85);
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Resultado";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(pnlCola);
            Controls.Add(uiPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlResultado);
            Name = "Ejercicio4";
            Text = "Ejercicio4";
            Load += Ejercicio4_Load;
            pnlCola.ResumeLayout(false);
            pnlCola.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            pnlResultado.ResumeLayout(false);
            pnlResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIPanel pnlCola;
        private Label label9;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnGenerar;
        private Label label5;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIPanel pnlResultado;
        private Sunny.UI.UIUpDownTextBox txtN;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label4;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIRichTextBox rtbLeyenda;
    }
}