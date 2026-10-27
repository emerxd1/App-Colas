using ArbolVisual;
using Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using static Main.ArbolClass;
namespace Main
{
    public partial class ArbolBinario : Form
    {
        private Node.ArbolBinario arbol = new Node.ArbolBinario();

        private readonly ArbolBinarioView vista = new()
        {
            Dock = DockStyle.Bottom,
            Height = 140
        };

        public ArbolBinario()
        {
            InitializeComponent();
        }

        private void Mostrorenpanel()
        {
            vista.Dock = DockStyle.Fill;
            vista.BackColor = PanelDibujo.BackColor = Paleta.Fondo;

            PanelDibujo.Controls.Add(vista);
            vista.BringToFront();
        }

        private void uiPanel3_Click(object sender, EventArgs e)
        {
        }

        public void txtClean()
        {
            txtElementos.Clear();
            txtElementos.Focus();
        }

        private void ArbolBinario_Load(object sender, EventArgs e)
        {
            Mostrorenpanel();
            ActualizarLeyenda();
        }

        public void ActualizarLeyenda()
        {
            lblNodoRaiz.Text = arbol.Raiz == null ? "-" : arbol.Raiz.Dato.ToString();
            lblTotalNodo.Text = arbol.ContarNodos(arbol.Raiz).ToString();
            lblTotalNiveles.Text = arbol.Altura(arbol.Raiz).ToString();
        }

        private void Mostrar(string titulo, string resultado)
        {
            if (string.IsNullOrWhiteSpace(resultado))
            {
                MessageBox.Show("El árbol está vacío", titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(resultado, titulo,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* INSERTAR */
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtElementos.Text, out int d))
            {
                if (arbol.Buscar(arbol.Raiz, d))
                {
                    MessageBox.Show($"El número {d} ya existe en el árbol", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, d);
                    vista.Insertar(d);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número entero", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtClean();
            ActualizarLeyenda();
        }

        /* ELIMINAR */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtElementos.Text, out int d))
            {
                if (arbol.Buscar(arbol.Raiz, d))
                {
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, d);
                    vista.Eliminar(d);
                    MessageBox.Show($"Se eliminó el número: {d}", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El número ingresado no existe", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtClean();
            ActualizarLeyenda();
        }

        /* BUSCAR */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtElementos.Text, out int d))
            {
                vista.Buscar(d);
                MessageBox.Show(arbol.Buscar(arbol.Raiz, d) ? "Existe" : "No existe", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtClean();
        }

        /* BOTON DE PREORDEN */
        private void uiButton2_Click(object sender, EventArgs e)
        {
            vista.Recorrido = TipoRecorrido.PreOrden;
        }

        /* BOTON DE INORDEN */
        private void btnInOrden_Click(object sender, EventArgs e)
        {
            vista.Recorrido = TipoRecorrido.InOrden;
        }

        /* BOTON DE POSTORDEN */
        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            vista.Recorrido = TipoRecorrido.PostOrden;
        }

        /* BOTON DE NIVELES (pendiente) */
        private void btnNiveles_Click(object sender, EventArgs e)
        {

        }
    }
}
