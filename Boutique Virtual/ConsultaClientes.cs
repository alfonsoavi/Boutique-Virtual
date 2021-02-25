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
    public partial class ConsultaClientes : Form
    {
        String bas = "proyecto";
        public ConsultaClientes()
        {
            InitializeComponent();
            obtener_datos();
        }
        public void obtener_datos()
        {
            TablaCliente.Rows.Clear();
            string sentencia = "select * from cliente ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                string ced = registros[0].ToString();
                string nom = registros[1].ToString();
                string telf = registros[2].ToString();
                string direc = registros[3].ToString();
                string correo = registros[4].ToString();

                TablaCliente.Rows.Add(ced, nom, telf, direc, correo);
            }
        }


            private void button1_Click(object sender, EventArgs e)
        {
            String n = (String)TablaCliente.CurrentRow.Cells[0].Value;
            string sentencia = "select * from cliente where cedula= '" + n +"'";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database="+bas+";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string cedula = registros[0].ToString();
                string nom = registros[1].ToString();
                string telf = registros[2].ToString();
                string direcc = registros[3].ToString();
                string correo = registros[4].ToString();

                Hide();
                RegistroCliente rc = new RegistroCliente ();
                rc.t_cedula.Text = cedula;
                rc.t_nombre.Text = nom;
                rc.t_telefono.Text = telf;
                rc.t_direccion.Text = direcc;
                rc.t_correo.Text = correo;
                rc.ShowDialog();
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String n = (String)TablaCliente.CurrentRow.Cells[0].Value;
            string sentencia = "delete from cliente where cedula = '" + n + "'";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database="+bas+";Trusted_Connection=True;");
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
            RegistroCliente rc = new RegistroCliente();
            rc.ShowDialog();
        }

        private void ConsultaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            RegistroCliente rc = new RegistroCliente();
            rc.ShowDialog();
        }
    }
}
