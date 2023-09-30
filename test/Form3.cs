using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Declaramos una variable publica para pasar el valor del grid
        public string Xvalor { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            // El evento Load del formulario
            //llamamos el método de la clase EstudianteBL
            List<Cliente> resultado = ClienteBL.RellenarGRID();
            //Rellenamos el grid
            dataGridView1.DataSource = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Código al botón Aceptar
            Xvalor = (dataGridView1.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }
    }
}
