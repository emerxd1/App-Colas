using Estructuras;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Ejercicio3 : Form
    {
        // Un cliente en la cola: su número de llegada y cuánto tarda en ser atendido
        private readonly record struct ClienteBanco(int Numero, int Duracion)
        {
            public override string ToString() => $"C{Numero} · {Duracion}m";
        }

        // Resultado de atender a un cliente (una fila de la tabla)
        private readonly record struct Atencion(int Numero, int Duracion, int Espera, int Inicio, int Fin);

        // Dibujo de la cola (se crea por código y va dentro del panel "Simulacion")
        private readonly QueueView vista = new();

        // Texto grande con el promedio (va dentro del panel "Tiempo de espera Promedio")
        private readonly Label lblPromedio = new()
        {
            AutoSize = false,
            Location = new Point(6, 40),
            Size = new Size(189, 80),
            Font = new Font("Segoe UI Symbol", 22F, FontStyle.Bold),
            ForeColor = Color.FromArgb(22, 94, 85),
            BackColor = Color.Transparent,
            TextAlign = ContentAlignment.MiddleCenter,
            Text = "—"
        };

        public Ejercicio3()
        {
            InitializeComponent();

            pnlTimewait.Controls.Add(lblPromedio);

            vista.Dock = DockStyle.None;
            vista.Location = new Point(10, 30);                       // debajo del título
            vista.Size = new Size(uiPanel3.Width - 20, uiPanel3.Height - 40);
            vista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                         | AnchorStyles.Left | AnchorStyles.Right;
            vista.BackColor = uiPanel3.FillColor;
            uiPanel3.Controls.Add(vista);
            vista.Mostrar(Array.Empty<ClienteBanco>());               // "La cola está vacía"

            dgvClients.ScrollBars = ScrollBars.Both;                  // para ver todas las filas
            btnSimular.Click += btnSimular_Click;                     // el diseñador no lo enlaza
        }

        // esperaPromedio(clientes):
        // Todos llegan en el minuto 0 y hay una sola caja que atiende en orden de llegada.
        // Cada cliente espera hasta que terminan de atenderse los que iban antes.
        // Usa una Queue: se encolan todos y se van sacando de uno en uno.
        // Llena 'detalle' con una fila por cliente y devuelve el tiempo de espera promedio.
        private double EsperaPromedio(int[] clientes, List<Atencion> detalle)
        {
            var cola = new LinkedListAndQueue.Queue<ClienteBanco>();
            for (int i = 0; i < clientes.Length; i++)
                cola.Enqueue(new ClienteBanco(i + 1, clientes[i]));

            int reloj = 0;      // minuto en que la caja queda libre
            long sumaEspera = 0;

            while (!cola.IsEmpty)
            {
                var c = cola.Dequeue();

                int espera = reloj;               // llegó en el minuto 0, espera hasta que la caja se libere
                int inicio = reloj;
                int fin = reloj + c.Duracion;

                detalle.Add(new Atencion(c.Numero, c.Duracion, espera, inicio, fin));

                sumaEspera += espera;
                reloj = fin;                      // la caja queda libre cuando termina este cliente
            }

            return clientes.Length == 0 ? 0 : (double)sumaEspera / clientes.Length;
        }

        private async void btnSimular_Click(object sender, EventArgs e)
        {
            // Se leen las duraciones: "5, 3, 2" -> [5, 3, 2]
            var partes = txtElementos.Text
                .Split(',')
                .Select(s => s.Trim())
                .Where(s => s != "")
                .ToList();

            if (partes.Count == 0)
            {
                MessageBox.Show("Ingresa la duración de cada cliente separada por comas. Ej: 5,3,2",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtElementos.Focus();
                txtElementos.Clear();
                return;
            }

            var duraciones = new int[partes.Count];
            for (int i = 0; i < partes.Count; i++)
            {
                if (!int.TryParse(partes[i], out duraciones[i]) || duraciones[i] <= 0)
                {
                    MessageBox.Show($"\"{partes[i]}\" no es una duración válida (debe ser un entero mayor que 0).",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtElementos.Focus();
                    txtElementos.Clear();

                    return;
                }
            }

            btnSimular.Enabled = false;
            try
            {
                dgvClients.Rows.Clear();
                lblPromedio.Text = "—";

                var detalle = new List<Atencion>();
                double promedio = EsperaPromedio(duraciones, detalle);

                // Demostración gráfica: la cola completa al inicio y se atiende de a uno
                var visual = new LinkedListAndQueue.Queue<ClienteBanco>();
                foreach (var a in detalle)
                    visual.Enqueue(new ClienteBanco(a.Numero, a.Duracion));
                vista.Mostrar(visual);

                int pausa = Math.Clamp(4000 / detalle.Count, 60, 5000);// entre 60 y 500 ms por cliente

                foreach (var a in detalle)
                {
                    await Task.Delay(pausa);

                    visual.Dequeue();             // pasa a la caja
                    vista.Mostrar(visual);
                    dgvClients.Rows.Add($"Cliente {a.Numero}", a.Duracion, a.Espera, a.Inicio, a.Fin);
                }
                txtElementos.Focus();
                txtElementos.Clear();
                lblPromedio.Text = $"{promedio:0.##} min";
            }
            finally
            {
                btnSimular.Enabled = true;
                txtElementos.Focus();
                txtElementos.Clear();
            }
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
        }
    }
}