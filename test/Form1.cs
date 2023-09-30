using System.Data.SqlClient;

namespace test
{
    public partial class Form1 : Form
    {
        //Declaramos varables 

        private SqlConnection Cnn;
        private SqlDataReader Leer;

        
        public string xclave;
        public string usuario;

        //Creamos el metodo o funcion LeerBD, para acceder a la BD
        public void LeerBD()
        {
            string CadenaConexion = @"Data Source=DESKTOP-N2S1HJB;Initial Catalog=PruebaSorbeteria3;Integrated Security=True";
            Cnn = new SqlConnection(CadenaConexion);
            Cnn.Open();

            string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE @usu";
            SqlCommand comando3 = new SqlCommand(consulta, Cnn);
            comando3.Parameters.AddWithValue("@usu", txbU.Text);
            Leer = comando3.ExecuteReader();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            LeerBD();
            while (Leer.Read())
            {
                usuario = Convert.ToString(Leer["usuario"]);
                xclave = Convert.ToString(Leer["clave"]);
            }

            if (usuario == txbU.Text && xclave == txbC.Text)
            {
                MessageBox.Show("Ingreso al programa");

                btnCerrar.Visible = true;
                btnfactura.Visible = true;
                txbC.Visible = false;
                txbU.Visible = false;
                btnInicio.Visible = false;
                txtU.Text = "Bienvenido";
                txtC.Text = "A sorbeteria Riki's";
               
            }
            else
            {
                MessageBox.Show("Intente Nuevamente");
                txbU.Text = string.Empty;
                txbC.Text = string.Empty;
            }
            Leer.Close();
            Cnn.Close();
        }


        private void btnfactura_Click(object sender, EventArgs e)
        {
            //1-Instanciar el formulario propietario

            Form2 factura = new Form2();

            //2-Indicar cual es el propietario

            AddOwnedForm(factura);

            //3-Se accede al control deseado

            //FHPP.textBox2.Text = this.textBox1.Text;

            //4-Se muestra el formulario

            factura.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar.Visible = false;
            btnfactura.Visible = false;
       
            txbC.Visible = true;
            txbU.Visible = true;
            btnInicio.Visible = true;
            txtU.Text = "Ingrese Usuario";
            txtC.Text = "Ingrese Contraseña";
            txbU.Text = string.Empty;
            txbC.Text = string.Empty;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}