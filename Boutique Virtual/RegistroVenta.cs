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
    public partial class RegistroVenta : Form
    {
        String bas = "proyecto";
        int numero = 1;
        public RegistroVenta()
        {
            InitializeComponent();
            t_factura.Text = Convert.ToString(numero);
            incremento();
            cargarproducto();
        }
        public void cargarproducto()
        {
            string sentencia = "select * from producto";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database="+bas+ ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                int cod = Convert.ToInt32(registros[0]);
                string producto = registros[1].ToString();
                string talla = registros[2].ToString();
                double valor = Convert.ToDouble(registros[3]);
                DatosProducto dp = new DatosProducto(cod, producto, talla, valor);
                c_productos.Items.Add(dp);
            }
            conexion.Close();
        }

        public void incremento()
        {
            string sentencia = "select factura from venta ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                int fact = Convert.ToInt32(registros[0].ToString());
                numero = fact + 1;
                t_factura.Text = Convert.ToString(numero);
            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentencia = "select nombre from cliente where cedula= '" + t_cedula.Text + "'";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                t_nombre.Text = registros[0].ToString();
            }
            else
            {
                t_cedula.Text = "";
                t_nombre.Text = "";
                MessageBox.Show("Cliente no esta registrado");
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(t_unidades.Text.Equals(""))
            {
                MessageBox.Show("Ingrese las unidades deseadas.");
            }
            else 
            { 
            DatosProducto dp = (DatosProducto)c_productos.SelectedItem;
            double total = dp.valor * Convert.ToInt32(t_unidades.Text);
            t_total.Text = Convert.ToString(total);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t_cedula.Text.Equals("") || t_nombre.Text.Equals("") || c_productos.Text.Equals("")
                || t_unidades.Text.Equals("") || t_total.Text.Equals(""))
            {
                MessageBox.Show("Uno de los campos se encuentra vacio");
            }
            else
            {
                DatosProducto dp = (DatosProducto)c_productos.SelectedItem;
                string sentencia = "insert into venta values (" + t_factura.Text + ",'" + t_cedula.Text + "',"
                    + dp.codigo + "," + t_unidades.Text + "," + t_total.Text.Replace(",", ".") + ")";
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();
                t_cedula.Text = "";
                t_nombre.Text = "";
                c_productos.Text = "";
                t_unidades.Text = "";
                t_total.Text = "";
                conexion.Close();
                MessageBox.Show("Los datos se guardaron correctamente");
                incremento();
            }
                
        }
    }
}
