using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Estructuras;

namespace Main
{
    public partial class Ejercicio4 : Form
    {
        private readonly QueueView _colaGrafica;

        public Ejercicio4()
        {
            InitializeComponent();

            // Reemplaza el cuadro de texto "Cola formada" por el control grafico
            _colaGrafica = new QueueView
            {
                Location = uiRichTextBox1.Location,
                Size = new Size(744, 110),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            pnlCola.Controls.Remove(uiRichTextBox1);
            uiRichTextBox1.Dispose();
            pnlCola.Controls.Add(_colaGrafica);

            // QueueView necesita mas alto que el cuadro original (54 px)
            pnlCola.Height = 150;
            ClientSize = new Size(ClientSize.Width, 510);

            _colaGrafica.Mostrar(new List<string>());
            btnGenerar.Click += btnGenerar_Click;
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Ingrese un entero mayor que 0.", "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbLeyenda.Text = "";
                _colaGrafica.Mostrar(new List<string>());
                return;
            }

            // Cola con lo que queda pendiente luego de generar los n numeros
            Queue<string> colaFinal;
            List<string> binarios = GenerarBinarios(n, out colaFinal);

            rtbLeyenda.Text = string.Join(", ", binarios.ConvertAll(b => "\"" + b + "\""));
            _colaGrafica.Mostrar(binarios);
        }

        /// Devuelve los primeros n binarios positivos usando una Queue,
        /// sin usar Convert.ToString(x, 2) ni conversion directa.
        /// Idea: sacar "s" de la cola, emitirlo y encolar s+"0" y s+"1".
        private static List<string> GenerarBinarios(int n, out Queue<string> cola)
        {
            var resultado = new List<string>();
            cola = new Queue<string>();
            cola.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string actual = cola.Dequeue();
                resultado.Add(actual);
                cola.Enqueue(actual + "0");
                cola.Enqueue(actual + "1");
            }

            return resultado;
        }
    }
}