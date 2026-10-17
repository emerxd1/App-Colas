using Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Ejercicio2 : Form
    {
        private readonly LinkedListAndQueue.Queue<string> _cola = new();   // la cola q

        private readonly QueueView vistaOriginal = new();    // cola antes de invertir
        private readonly QueueView vistaInvertida = new();   // cola mientras se invierte y ya invertida
        private readonly PilaVisual pilaAux = new();         // pila auxiliar

        public Ejercicio2()
        {
            InitializeComponent();

            Colocar(vistaOriginal, pnlCola);
            Colocar(vistaInvertida, pnlColainvertida);
            Colocar(pilaAux, pnlPilaAux);

            pilaAux.Punteado = true;                 // borde punteado = pila auxiliar
            pilaAux.Establecer(Array.Empty<string>());

            vistaOriginal.Mostrar(_cola);            // al abrir: "La cola está siempre vacía"
            vistaInvertida.Mostrar(_cola);
        }

        // Pone un dibujo dentro de su panel, debajo del título, y lo ajusta al tamaño del panel
        private void Colocar(Control control, Control panel)
        {
            control.Dock = DockStyle.None;
            control.Location = new Point(10, 40);
            control.Size = new Size(panel.Width - 20, panel.Height - 50);
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                           | AnchorStyles.Left | AnchorStyles.Right;
            control.BackColor = panel.BackColor = Color.White;

            panel.Controls.Add(control);
            control.BringToFront();
        }

        // Crea la cola 
        private void btnCrearCola_Click(object sender, EventArgs e)
        {
            var elementos = txtElementos.Text
                .Split(',')
                .Select(s => s.Trim())
                .Where(s => s != "")   // ignora vacíos
                .ToList();

            if (elementos.Count == 0)
            {
                Registrar("AVISO", "No ingresaste ningún elemento", Color.Crimson);
                return;
            }

            foreach (var elemento in elementos)
            {
                _cola.Enqueue(elemento);
                Registrar("ENQUEUE", $"\"{elemento}\" agregado al final", Color.RoyalBlue);
            }

            txtElementos.Clear();
            txtElementos.Focus();

            vistaOriginal.Mostrar(_cola);
            Registrar("PEEK", $"el frente es \"{_cola.Peek()}\"", Color.SeaGreen);
        }

        //  Registro de operaciones (leyenda)
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

        //  invertir(q)
        // Deja la cola q en orden inverso usando una pila auxiliar (solo Push y Pop)
        // y las operaciones de la cola (Enqueue, Dequeue). Dibuja cada paso.
        private async Task InvertirAsync(LinkedListAndQueue.Queue<string> q)
        {
            if (q.IsEmpty)
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var aux = new Pila<string>(q.Size);// pila auxiliar para invertir la cola
            pilaAux.Capacidad = q.Size;// para que se vea la pila completa
            pilaAux.Establecer(aux.ToArray());// queda vacía al inicio

            vistaOriginal.Mostrar(q);    // queda fija: así estaba la cola antes de invertir
            vistaInvertida.Mostrar(q);   // esta se irá moviendo
            Registrar("INVERTIR", "Inicio: la cola pasa a la pila auxiliar", Color.Purple);
            await Task.Delay(600);

            //pars sacar del frente de la cola y apilar
            while (!q.IsEmpty)
            {
                var valor = q.Dequeue()!;//saca el primer elemento de la cola
                aux.Push(valor);//lo mete a la pila auxiliar 

                Registrar("PUSH", $"\"{valor}\" pasa de la cola a la pila", Color.DarkOrange);
                vistaInvertida.Mostrar(q);
                pilaAux.Establecer(aux.ToArray());
                await Task.Delay(600);
            }

            // desapila y meter al final de la cola
            while (!aux.IsEmpty())
            {
                var valor = aux.Pop();//saca el elemento de la pila auxiliar el que esta en el tope
                q.Enqueue(valor);

                Registrar("POP", $"\"{valor}\" vuelve de la pila a la cola", Color.SeaGreen);
                vistaInvertida.Mostrar(q);
                pilaAux.Establecer(aux.ToArray());
                await Task.Delay(600);
            }

            Registrar("INVERTIR", "La cola ha sido invertida.", Color.Purple);
        }

        private async void btnInvertir_Click(object sender, EventArgs e)
        {
            //para bloquear los botones mientras se ejecuta la tarea asincrona
            btnInvertir.Enabled = false;
            btnCrearCola.Enabled = false;

            await InvertirAsync(_cola);

            btnInvertir.Enabled = true;
            btnCrearCola.Enabled = true;
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }
    }
}