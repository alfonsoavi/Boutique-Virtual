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
    public partial class RegistroCliente : Form
    {
        String bas = "proyecto";
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaClientes cc = new ConsultaClientes();
            cc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_cedula.Text.Equals("")|| t_nombre.Text.Equals("") ||t_telefono.Text.Equals("")
                || t_direccion.Text.Equals("") || t_correo.Text.Equals(""))
            {
                MessageBox.Show("Los campos se encuentran vacios para guardar.");
            }
            else
            { 
            string sentencia = "insert into cliente values('" + t_cedula.Text + "','"
           + t_nombre.Text + "','" + t_telefono.Text + "','" + t_direccion.Text + "','" + t_correo.Text+ "')";
            //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();

                t_cedula.Text = "";
                t_nombre.Text = "";
                t_telefono.Text = "";
                t_direccion.Text = "";
                t_correo.Text = "";
                conexion.Close();

                MessageBox.Show("Los datos se guardaron correctamente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t_cedula.Text.Equals("") || t_nombre.Text.Equals("") || t_telefono.Text.Equals("")
                || t_direccion.Text.Equals("") || t_correo.Text.Equals(""))
            {
                MessageBox.Show("Los campos se encuentran vacios para actualizar.");
            }
            else
            {
                string sentencia = "update cliente set nombre= '" + t_nombre.Text + " ',telefono= '"
                                    + t_telefono.Text + " ',direccion= '" + t_direccion.Text
                                    + " ',correo= '" + t_correo.Text
                                    + " ' where cedula = '" + t_cedula.Text + "'";
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();
                t_cedula.Text = "";
                t_nombre.Text = "";
                t_telefono.Text = "";
                t_direccion.Text = "";
                t_correo.Text = "";
                conexion.Close();
                MessageBox.Show("Los datos se actulizaron correctamente");
            }
        }

        private void t_cedula_Validating(object sender, CancelEventArgs e)
        {
            string sentencia = "select cedula from cliente ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                string cedula = registros[0].ToString();
                if (t_cedula.Text.Equals(cedula))
                {
                    MessageBox.Show("El usuario con cedula ''" + cedula + "'' ya existe en el sistema.");
                    t_cedula.Text = "";
                }
            }
            conexion.Close();
        }
    }
}
