namespace Main
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarFormulario(Form formulario)
        {
            if (this.Contenedor.Controls.Count > 0)// para que no se repita el formulario y se muestre en el panel contenedor
                this.Contenedor.Controls.RemoveAt(0);//elimina el formulario que se encuentra en el panel contenedor
            {
                Form frm = formulario;//crea una instancia del formulario que se va a mostrar
                formulario.TopLevel = false;//para que el formulario se muestre dentro del panel contenedor
                formulario.FormBorderStyle = FormBorderStyle.None;//para que el formulario no tenga bordes
                formulario.BackColor = Color.White;//para que el formulario tenga el mismo color que el panel contenedor
                Contenedor.Controls.Add(formulario);//agrega el formulario al panel contenedor


                formulario.Dock = DockStyle.Fill;//para que el formulario se ajuste al tamaño del panel contenedor
                Contenedor.Tag = formulario;//para que el formulario se pueda identificar dentro del panel contenedor
                formulario.Show();//para que el formulario se muestre
                formulario.BringToFront();//para que el formulario se muestre al frente de los demás controles del panel contenedor
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Ejercicio1());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Ejercicio2());
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Ejercicio3());
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Ejercicio4());
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Ejercicio5());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PnlMenu.Width == 200)
            {
                lblInfo.Text = "CP"!;
                PnlMenu.Width = 40;
            }
            else
            {
                lblInfo.Text = "Clase Practica | Colas"!;
                PnlMenu.Width = 200;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new ArbolBinario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Asistencia());
        }
    }
}
