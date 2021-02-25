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
    public partial class ConsultaProducto : Form
    {
        String bas = "proyecto";
        public ConsultaProducto()
        {
            InitializeComponent();
            obtener_datos();
        }

        public void obtener_datos()
        {
            TablaProducto.Rows.Clear();
            string sentencia = "select * from producto ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                string cod = registros[0].ToString();
                string prod = registros[1].ToString();
                string tall = registros[2].ToString();
                string prec = registros[3].ToString();
                
                TablaProducto.Rows.Add(cod, prod, tall, prec);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n = (String)TablaProducto.CurrentRow.Cells[0].Value;
            string sentencia = "select * from producto where codigo= " + n;
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string cod = registros[0].ToString();
                string prod = registros[1].ToString();
                string tall = registros[2].ToString();
                string prec = registros[3].ToString();

                Hide();
                RegistroProducto rp = new RegistroProducto();
                rp.operacion = "actualizar";
                rp.t_codigo.Text = cod;
                rp.t_producto.Text = prod;
                rp.t_talla.Text = tall;
                rp.t_precio.Text = prec;
                rp.ShowDialog();
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String n = (String)TablaProducto.CurrentRow.Cells[0].Value;
            string sentencia = "delete from producto where codigo = " + n;
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se eliminaron correctamente");
            obtener_datos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            RegistroProducto rp = new RegistroProducto();
            rp.ShowDialog();
        }

        private void ConsultaProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            RegistroProducto rp = new RegistroProducto();
            rp.ShowDialog();
        }
    }
}
