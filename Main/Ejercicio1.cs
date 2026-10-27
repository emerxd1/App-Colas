
using Estructuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main
{
    public partial class Ejercicio1 : Form
    {

        private readonly LinkedListAndQueue.Queue<string> _cola = new();

        public Ejercicio1()
        {
            InitializeComponent();

        }
        private void Mostrorenpanel()
        {

            vista.Dock = DockStyle.None;
            vista.Location = new Point(10, 40);
            vista.Size = new Size(pnlCola.Width - 20, pnlCola.Height - 50);
            vista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                         | AnchorStyles.Left | AnchorStyles.Right;
            vista.BackColor = pnlCola.BackColor = Color.White;

            pnlCola.Controls.Add(vista);
            vista.BringToFront();
            vista.Mostrar(_cola);
        }
        private readonly QueueView vista = new()
        {
            Dock = DockStyle.Bottom,
            Height = 140
        };

        // Agrega al final uno o varios elementos separados por comas: a, b, c
        private void btnBegin_Click(object sender, EventArgs e)
        {
            rtbEmpty.Clear();
            rtbLeyenda.Clear();
            rtbSize.Clear();

            var elementos = txtElementos.Text
                .Split(',')
                .Select(s => s.Trim())
                .Where(s => s != ""); // ignora vacíos

            foreach (var elemento in elementos)
            {
                _cola.Enqueue(elemento);
                Registrar("ENQUEUE", $"\"{elemento}\" agregado al final", Color.RoyalBlue);
            }

            txtElementos.Clear();
            txtElementos.Focus();
            vista.Mostrar(_cola);
            Mostrorenpanel();
        }

        // Saca el elemento del frente
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (_cola.IsEmpty)
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var valor = _cola.Dequeue();   // se saca UNA sola vez y se guarda
            Registrar("DEQUEUE", $"salió \"{valor}\" del frente", Color.DarkOrange);

            vista.Mostrar(_cola);
            Mostrorenpanel();              // para que Tamaño y Estado también se actualicen
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (!_cola.IsEmpty)
            {
                var elemento = _cola.Peek();
                rtbLeyenda.Clear();
                Registrar("PEEK", $"el frente es \"{_cola.Peek()}\"", Color.SeaGreen); 
                vista.Mostrar(_cola);

            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (_cola.IsEmpty)
            {
                rtbEmpty.Clear();
                rtbEmpty.AppendText("Vacia.\n");
                rtbEmpty.ForeColor = Color.Red;

            }
            else
            {
                rtbEmpty.Clear();
                rtbEmpty.ForeColor = Color.Green;
                rtbEmpty.AppendText("No está vacía.\n");
            }
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if(_cola.IsEmpty)
            {
                rtbSize.Clear();
                rtbSize.AppendText("La cola está vacía.\n");
                rtbSize.ForeColor = Color.Red;
            }
            else
            {
                rtbSize.Clear();
                rtbSize.AppendText($"{_cola.Size}\n");
                rtbSize.ForeColor = Color.Green;
            }
        }

        private void Registrar(string tipo, string mensaje, Color color)
        {
            void Escribir(string texto, Color c, FontStyle estilo)
            {
                rtbLeyenda.SelectionStart = rtbLeyenda.TextLength;
                rtbLeyenda.SelectionLength = 0;
                using var fuente = new Font(rtbLeyenda.Font, estilo);
                rtbLeyenda.SelectionFont = fuente;
                rtbLeyenda.SelectionColor = c;
                rtbLeyenda.AppendText(texto);
            }

            Escribir($"{tipo}: ", color, FontStyle.Bold);
            Escribir(mensaje + Environment.NewLine, rtbLeyenda.ForeColor, FontStyle.Regular);
            rtbLeyenda.ScrollToCaret();
        }
    }
}
        