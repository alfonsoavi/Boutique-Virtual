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
    public partial class ConsultaVentas : Form
    {
        String bas = "proyecto";
        public ConsultaVentas()
        {
            InitializeComponent();
            cargartabla();
            cargartalla();
            cargarproducto();

        }

        public void cargarproducto()
        {
            string sentencia = "select producto from producto group by producto";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string producto = registros[0].ToString();
                c_producto.Items.Add(producto);
            }
            conexion.Close();
        }

        public void cargartalla()
        {
            string sentencia = "select talla from producto group by talla";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string talla = registros[0].ToString();
                c_talla.Items.Add(talla);

            }
            conexion.Close();
        }
        public void cargartabla()
        {
            tablaventa.Rows.Clear();
            string sentencia = "select ve.factura,cl.cedula, cl.nombre, pd.producto, pd.talla,ve.unidades, ve.total " +
                               "from venta ve, cliente cl, producto pd " +
                               "where ve.cedula = cl.cedula and ve.codigo = pd.codigo  ";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string factura = registros[0].ToString();
                string cedula = registros[1].ToString();
                string nombre = registros[2].ToString();
                string producto = registros[3].ToString();
                string talla = registros[4].ToString();
                string unidades = registros[5].ToString();
                string total = "$ " + registros[6].ToString();
                tablaventa.Rows.Add(factura, cedula, nombre, producto, talla, unidades, total);
            }
            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaventa.Rows.Clear();
            String produ = (String) c_producto.SelectedItem ;
            String tall = (String)c_talla.SelectedItem;
            String sentenciaProducto = "";
            String sentenciaTalla = "";
            if (c_producto.Text != "" )
            {
                sentenciaProducto = " and pd.producto= '"+ produ + "'";
            }
            if (c_talla.Text != "")
            {
                sentenciaTalla = " and pd.talla= '" + tall+"'";
            }

                string sentencia = "select ve.factura,cl.cedula, cl.nombre, pd.producto, pd.talla,ve.unidades, ve.total " +
                                   "from venta ve, cliente cl, producto pd " +
                                   "where ve.cedula = cl.cedula and ve.codigo = pd.codigo"+ sentenciaProducto + sentenciaTalla ;
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    string factura = registros[0].ToString();
                    string cedula = registros[1].ToString();
                    string nombre = registros[2].ToString();
                    string producto = registros[3].ToString();
                    string talla = registros[4].ToString();
                    string unidades = registros[5].ToString();
                    string total = "$ "+registros[6].ToString();
                    tablaventa.Rows.Add(factura, cedula, nombre, producto, talla, unidades, total);
                }
                conexion.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c_producto.Text.Equals("") && c_talla.Text.Equals(""))
            {
                Reporte_General rg = new Reporte_General();
                rg.ShowDialog();
            }
            if(c_producto.Text != "" && c_talla.Text.Equals(""))
            {
                Reporte_producto rp = new Reporte_producto();
                rp.producto = (String)c_producto.SelectedItem;
                rp.ShowDialog();
            }
            if(c_talla.Text != "" &&  c_producto.Text.Equals("") )
            {
                Reporte_Talla rt = new Reporte_Talla();
                rt.talla = (String)c_talla.SelectedItem;
                rt.ShowDialog();
            }
            if (c_producto.Text != "" && c_talla.Text != "")
            {
                Reporte_Filtros rf = new Reporte_Filtros();
                rf.talla = (String)c_talla.SelectedItem;
                rf.producto = (String)c_producto.SelectedItem;
                rf.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_factura rf = new Reporte_factura();
            rf.factura =Convert.ToInt32((String)tablaventa.CurrentRow.Cells[0].Value);
            rf.ShowDialog();
        }
    }
}
