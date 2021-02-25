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
    public partial class Estadistica : Form
    {
        String bas = "proyecto";
        public Estadistica()
        {
            InitializeComponent();
            cargar();
            Producto.Checked = true;
            cargar_producto();
        }

        public void cargar()
        {
            string sentencia = "select sum(total) as total_venta, count(*) as cantidad_venta from venta where factura >0";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                t_ventas.Text = "$ " + registros[0].ToString();
                t_cantidad.Text = registros[1].ToString();
            }
        }


        public void cargar_producto()
        {
            Tabla.Rows.Clear();
            Tabla.Columns.Clear();
            Tabla.Columns.Add("columna0", "Producto");
            Tabla.Columns.Add("columna1", "Cantidad Ventas");
            Tabla.Columns.Add("columna2", "Unidades Vendidas");
            Tabla.Columns.Add("columna3", "Total Venta");

            string sentencia = "select p.producto, count(*) as cantidad_venta ,sum(v.unidades) as unidades_vendidas, sum(v.total) as total_venta"
                               + " from venta v, producto p"
                               + " where p.codigo = v.codigo and p.codigo > 0 group by p.producto";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string producto = registros[0].ToString();
                string cantidad_venta = registros[1].ToString();
                string unidades_vendidas = registros[2].ToString();
                string total_venta = "$ " + registros[3].ToString();

                Tabla.Rows.Add(producto, cantidad_venta, unidades_vendidas, total_venta);
            }
        }

        public void cargar_talla()
        {
            Tabla.Columns.Clear();
            Tabla.Rows.Clear();
            Tabla.Columns.Add("columna0", "Talla");
            Tabla.Columns.Add("columna1", "Cantidad Ventas");
            Tabla.Columns.Add("columna2", "Unidades Vendidas");
            Tabla.Columns.Add("columna3", "Total Venta");
            string sentencia = "select p.talla, count(*) as cantidad_ventas ,sum(v.unidades) as unidades_vendidas, sum(v.total) as total_venta"
                               + " from venta v, producto p"
                               + " where p.codigo = v.codigo and p.codigo > 0 group by p.talla";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string talla = registros[0].ToString();
                string cantidad_venta = registros[1].ToString();
                string unidades_vendidas = registros[2].ToString();
                string total_venta = "$ " + registros[3].ToString();

                Tabla.Rows.Add(talla, cantidad_venta, unidades_vendidas, total_venta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Producto.Checked == true)
            {
                cargar_producto();
            }
            if (talla.Checked == true)
            {
                cargar_talla();
            }
        }
    }
}
