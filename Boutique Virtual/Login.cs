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
    public partial class Login : Form
    {
        String bas = "proyecto";
        public Login()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {

            Boolean credenciales_correctas = false;
            string sentencia = "select * from login where usuario='" + t_usuario.Text + "' and contraseña='" + t_contraseña.Text + "'";
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=" + bas + ";Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                credenciales_correctas = true;

            }
            conexion.Close();

            if (credenciales_correctas)
            {
                Hide();
                pantallaprincipal fo = new pantallaprincipal();
                fo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta, verifique");
            }

        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroLogin rl = new RegistroLogin();
            rl.ShowDialog();
        }
    }
}
