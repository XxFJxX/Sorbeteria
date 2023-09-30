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

namespace test
{
    public partial class Form2 : Form
    {
        //Declaramos varables 

        private SqlConnection Cnn;
        private SqlDataReader Leer;

        public string id;

        //Creamos el metodo o funcion LeerBD, para acceder a la BD
        public void LeerBD()
        {
            string CadenaConexion = @"Data Source=DESKTOP-N2S1HJB;Initial Catalog=Sorbeteria;Integrated Security=True";
            Cnn = new SqlConnection(CadenaConexion);
            Cnn.Open();

            string consulta = "SELECT * FROM Datos WHERE ID LIKE @tot";
            SqlCommand comando3 = new SqlCommand(consulta, Cnn);
            comando3.Parameters.AddWithValue("@tot", lblt.Text);
            Leer = comando3.ExecuteReader();
        }
        public Form2()
            InitializeComponent();
            textBox3.Text = DateTime.Today.Date.ToString("D");
        }

        double n, n1, n2, n3, n4, n5;
        int indice1, so;
        double r;
        int i;
        string a = "Wafle", b = "Wafle Doble", c = "Chocowafle", d = "Chovcowafle Doble", f = "Chocowafle Especial", g = "Chocowafle Especial Doble";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice1 = comboBox1.SelectedIndex;
            txt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty || txt.Text == string.Empty) { MessageBox.Show("No hay elementos"); }
            else
            {
                if (indice1 == 0)
                {
                    so = Convert.ToInt32(txt.Text);
                    n = so * 1.10;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = a;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = a;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = a;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = a;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = a;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = a;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
                if (indice1 == 1)
                {
                    so = Convert.ToInt32(txt.Text);
                    n1 = so * 1.50;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = b;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = b;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = b;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = b;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = b;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = b;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
                if (indice1 == 2)
                {
                    so = Convert.ToInt32(txt.Text);
                    n2 = so * 1.25;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = c;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = c;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = c;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = c;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = c;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = c;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
                if (indice1 == 3)
                {
                    so = Convert.ToInt32(txt.Text);
                    n3 = so * 1.65;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = d;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = d;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = d;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = d;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = d;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = d;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
                if (indice1 == 4)
                {
                    so = Convert.ToInt32(txt.Text);
                    n4 = so * 1.35;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = f;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = f;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = f;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = f;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = f;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = f;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
                if (indice1 == 5)
                {
                    so = Convert.ToInt32(txt.Text);
                    n5 = so * 1.75;
                    do
                    {
                        if (lbl1.Text == string.Empty)
                        {
                            lbl1.Text = g;
                            lbl01.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl2.Text == string.Empty)
                        {
                            lbl2.Text = g;
                            lbl02.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl3.Text == string.Empty)
                        {
                            lbl3.Text = g;
                            lbl03.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl4.Text == string.Empty)
                        {
                            lbl4.Text = g;
                            lbl04.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl5.Text == string.Empty)
                        {
                            lbl5.Text = g;
                            lbl05.Text = Convert.ToString(so);
                            break;
                        }
                        if (lbl6.Text == string.Empty)
                        {
                            lbl6.Text = g;
                            lbl06.Text = Convert.ToString(so);
                            break;
                        }
                    } while (false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty || txt.Text == string.Empty) { MessageBox.Show("No hay elementos"); }
            else
            {
                if (indice1 == 0)
                {
                    if (lbl1.Text == a || lbl2.Text == a || lbl3.Text == a || lbl4.Text == a || lbl5.Text == a || lbl6.Text == a)
                    {
                        so = Convert.ToInt32(txt.Text);
                        r = so * 1.10;
                        n = n - r;
                        do
                        {
                            if (lbl1.Text == a)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == a)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == a)
                            {
                                i = Convert.ToInt32(lbl03.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == a)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == a)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == a)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
                if (indice1 == 1)
                {
                    if (lbl1.Text == b || lbl2.Text == b || lbl3.Text == b || lbl4.Text == b || lbl5.Text == b || lbl6.Text == b)
                    {
                        so = Convert.ToInt32(txt.Text);
                        n1 = so * 1.50;
                        n = n - r;

                        do
                        {
                            if (lbl1.Text == b)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == b)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == b)
                            {
                                i = Convert.ToInt32(lbl03.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == b)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == b)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == b)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
                if (indice1 == 2)
                {
                    if (lbl1.Text == c || lbl2.Text == c || lbl3.Text == c || lbl4.Text == c || lbl5.Text == c || lbl6.Text == c)
                    {
                        so = Convert.ToInt32(txt.Text);
                        n2 = so * 1.25;
                        n = n - r;

                        do
                        {
                            if (lbl1.Text == c)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == c)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == c)
                            {
                                i = Convert.ToInt32(lbl03.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == c)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == c)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == c)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
                if (indice1 == 3)
                {
                    if (lbl1.Text == d || lbl2.Text == d || lbl3.Text == d || lbl4.Text == d || lbl5.Text == d || lbl6.Text == d)
                    {
                        so = Convert.ToInt32(txt.Text);
                        n3 = so * 1.65;
                        n = n - r;

                        do
                        {
                            if (lbl1.Text == d)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == d)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == d)
                            {
                                i = Convert.ToInt32(lbl03.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == d)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == d)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == d)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
                if (indice1 == 4)
                {
                    if (lbl1.Text == f || lbl2.Text == f || lbl3.Text == f || lbl4.Text == f || lbl5.Text == f || lbl6.Text == f)
                    {
                        so = Convert.ToInt32(txt.Text);
                        n4 = so * 1.35;
                        n = n - r;

                        do
                        {
                            if (lbl1.Text == f)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == f)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == f)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == f)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == f)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == f)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
                if (indice1 == 5)
                {
                    if (lbl1.Text == g || lbl2.Text == g || lbl3.Text == g || lbl4.Text == g || lbl5.Text == g || lbl6.Text == g)
                    {
                        so = Convert.ToInt32(txt.Text);
                        n5 = so * 1.75;
                        n = n - r;

                        do
                        {
                            if (lbl1.Text == g)
                            {
                                i = Convert.ToInt32(lbl01.Text);
                                so = i - so;
                                lbl01.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl2.Text == g)
                            {
                                i = Convert.ToInt32(lbl02.Text);
                                so = i - so;
                                lbl02.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl3.Text == g)
                            {
                                i = Convert.ToInt32(lbl03.Text);
                                so = i - so;
                                lbl03.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl4.Text == g)
                            {
                                i = Convert.ToInt32(lbl04.Text);
                                so = i - so;
                                lbl04.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl5.Text == g)
                            {
                                i = Convert.ToInt32(lbl05.Text);
                                so = i - so;
                                lbl05.Text = Convert.ToString(so);
                                break;
                            }
                            if (lbl6.Text == g)
                            {
                                i = Convert.ToInt32(lbl06.Text);
                                so = i - so;
                                lbl06.Text = Convert.ToString(so);
                                break;
                            }
                        } while (false);
                    }
                    else { MessageBox.Show("No hay elementos para eliminar"); }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblt.Text = Convert.ToString(n + n1 + n2 + n3 + n4 + n5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 0;
            n1 = 0;
            n2 = 0;
            n3 = 0;
            n4 = 0;
            n5 = 0;
            txt.Text = string.Empty;
            comboBox1.Text = string.Empty;
            lbl1.Text = string.Empty;
            lbl2.Text = string.Empty;
            lbl3.Text = string.Empty;
            lbl4.Text = string.Empty;
            lbl5.Text = string.Empty;
            lbl6.Text = string.Empty;
            lbl01.Text = string.Empty;
            lbl02.Text = string.Empty;
            lbl03.Text = string.Empty;
            lbl04.Text = string.Empty;
            lbl05.Text = string.Empty;
            lbl06.Text = string.Empty;
            lblt.Text = string.Empty;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
