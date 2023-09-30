using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
  
        private void BUSCAR_Click(object sender, EventArgs e)
        {
            //Botón Buscar por Id

            Cliente pCliente = new Cliente();
            //Creamos una instancia vacía de Estudiante

            //pasamos el contenido de los Text a las a las propiedades

            // de la instancia que hemos creado

            pCliente.IDfactura = Convert.ToInt32(textBox1.Text);
            Cliente resultado = ClienteBL.BuscarPorId(pCliente);
            textBox2.Text = resultado.Nombre;
            textBox3.Text = resultado.Producto;
            textBox4.Text = resultado.cantidad;
            textBox5.Text = resultado.precio;
            textBox6.Text = resultado.Total;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Boton agregar
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" ||
            textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" ||
            textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "")

            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                if (MessageBox.Show("Seguro desea guardar los datos.", "Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)

                {

                    Cliente _clientes = new Cliente();
                    _clientes.Nombre = textBox2.Text.Trim().ToUpper();
                    _clientes.Producto = textBox3.Text.Trim().ToUpper();
                    _clientes.precio = textBox4.Text.Trim().ToUpper();
                    _clientes.cantidad = textBox5.Text.Trim().ToUpper();
                    _clientes.Total = textBox6.Text.Trim().ToUpper();

                    //Mandamos a llamar el método INSERTAR de la capa de Negocios
                    //y le pasamos la instancia ya con datos para que se guarde

                    int resultado = ClienteBL.Insertar(_clientes);

                    //Mandamos Información del éxito de la operación.

                    MessageBox.Show("Se ha Guardado " + resultado + " Registro(s) con éxito ",

                    " Registro de clientes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    //Limpiamos los controles y enviamos el enfoque a txtNombre

                    LimpiarTextos();
                }
            }
        }
        public void LimpiarTextos()
        {
            //Función limpiar
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;

            textBox1.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            LimpiarTextos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            // boton salir 

            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente _Clientes = new Cliente();
            _Clientes.Nombre = textBox1.Text;
            _Clientes.Producto = textBox2.Text;
            _Clientes.cantidad = textBox4.Text;
            _Clientes.precio = textBox3.Text;
            _Clientes.Total = textBox5.Text;
            _Clientes.IDfactura = Convert.ToInt32(textBox6.Text);

            int resultado = ClienteBL.Modificar(_Clientes);
            MessageBox.Show("Registro modificado : " + resultado);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente _Cliente = new Cliente();
            _Cliente.IDfactura = Convert.ToInt32(textBox1.Text);
            if (MessageBox.Show("Seguro Desea Borrar el registro.", "Registro de Estudiantes",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                int resultado = ClienteBL.Borrar(_Cliente);
                //Mandamos Información del éxito de la operación.
                MessageBox.Show("Se ha Borrado " + resultado + " Registro(s) con éxito ", "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpiamos los controles y enviamos el enfoque a Nombre
                textBox1.Text = string.Empty;
                LimpiarTextos();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento KeyPress programar si presiona <Enter> mostrar Grid
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Form3 xform = new Form3();
                if (xform.ShowDialog() == DialogResult.OK)
                    textBox1.Text = xform.Xvalor;
                /* Creamos una instancia vacía de cliente y
                pasamos el contenido de los Text a las  propiedades
                de la instancia que hemos creado */
                Cliente _Cliente = new Cliente();
                _Cliente.IDfactura = Convert.ToInt32(textBox1.Text);
                Cliente resultado = ClienteBL.BuscarPorId(_Cliente);
                textBox2.Text = resultado.Nombre;
                textBox3.Text = resultado.Producto;
                textBox4.Text = resultado.cantidad;
                textBox5.Text = resultado.precio;
                textBox6.Text = resultado.Total;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double num1, num2, r;
            num1 = double.Parse(textBox4.Text);
            num2 = double.Parse(textBox5.Text);
            r = num1 * num2;
            textBox6.Text = r.ToString();
        }
    }
}





