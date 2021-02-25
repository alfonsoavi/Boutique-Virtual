using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Boutique_Virtual
{
    public partial class RegistroProducto : Form
    {
        String bas = "proyecto";
        int numero = 1;
        public RegistroProducto()
        {
            InitializeComponent();
            t_codigo.Text = Convert.ToString(numero);
            incremento();
        }
        public string operacion = "insertar";

        public void incremento()
        {
            string sentencia = "select codigo from producto ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database="+bas+";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                int fact = Convert.ToInt32(registros[0].ToString());
                numero = fact+1;
                t_codigo.Text = Convert.ToString(numero);
            }

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaProducto cp = new ConsultaProducto();
            cp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t_codigo.Text.Equals("") || t_producto.Text.Equals("") || t_precio.Text.Equals(""))
            {
                MessageBox.Show("Los campos se encuentran vacios para guardar.");
            }
            else
            {
                if(operacion=="insertar")
                { 
                string sentencia = "insert into producto values(" + t_codigo.Text + ",'"
               + t_producto.Text + "','" + t_talla.Text + "'," + t_precio.Text.Replace(",",".") + ")";
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();

                t_producto.Text = "";
                t_talla.Text = "";
                t_precio.Text = "";

                conexion.Close();

                MessageBox.Show("Los datos se guardaron correctamente");
                incremento();
                }else
                if (operacion=="actualizar"){
                    string sentencia = "update producto set producto= '" + t_producto.Text + " ',talla= '"
                                    + t_talla.Text + " ',precio= " + t_precio.Text.Replace(",", ".")
                                    + "  where codigo = " + t_codigo.Text;
                    //Console.WriteLine(sentencia);
                    SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    incremento();
                    t_producto.Text = "";
                    t_talla.Text = "";
                    t_precio.Text = "";

                    conexion.Close();
                    MessageBox.Show("Los datos se actulizaron correctamente");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t_codigo.Text.Equals("") || t_producto.Text.Equals("") || t_precio.Text.Equals(""))
            {
                MessageBox.Show("Los campos se encuentran vacios para actualizar.");
            }
            else
            {
                string sentencia = "update producto set producto= '" + t_producto.Text + " ',talla= '"
                                    + t_talla.Text + " ',precio= " + t_precio.Text.Replace(",", ".")
                                    + "  where codigo = " + t_codigo.Text ;
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();
                
                incremento();
                t_producto.Text = "";
                t_talla.Text = "";
                t_precio.Text = "";

                conexion.Close();
                MessageBox.Show("Los datos se actulizaron correctamente");
            }
        }
    }
}
