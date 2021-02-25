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
    public partial class RegistroLogin : Form
    {
        String bas = "proyecto";
        public RegistroLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_user.Text.Equals("") || t_contraseña.Text.Equals("") || t_contraseña1.Text.Equals(""))
            {
                MessageBox.Show("Uno de los campos se encuentra vacio.");
            }
            else
            if (t_contraseña1.Text.Equals(t_contraseña.Text)&& t_user.Text != "")
            {
                string sentencia = "insert into login values('" + t_user.Text + "','" + t_contraseña.Text + "')";
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();

                t_user.Text = "";
                t_contraseña.Text = "";
                t_contraseña1.Text = "";
                conexion.Close();
                MessageBox.Show("Los datos se guardaron correctamente");
            }
            else
                MessageBox.Show("Contraseñas no coinciden, Intentelo nuevamente");
        }

        public void ValidarUsuario()
        {
            string sentencia = "select usuario from login ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                string user = registros[0].ToString();
                if (t_user.Text.Equals(user))
                {
                    MessageBox.Show("El usuario ''"+user+"'' ya existe en el sistema, Intente nuevamente.");
                    t_user.Text = "";
                }
            }
            conexion.Close();
        }

        private void t_user_Validating(object sender, CancelEventArgs e)
        {
            ValidarUsuario();
        }
    }
}
