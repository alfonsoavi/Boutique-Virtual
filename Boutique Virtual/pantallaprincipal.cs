using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique_Virtual
{
    public partial class pantallaprincipal : Form
    {
        public pantallaprincipal()
        {
            InitializeComponent();
        }

        private void pantallaprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente rc = new RegistroCliente();
            rc.ShowDialog();
        }

        private void registroDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto rp = new RegistroProducto();
            rp.ShowDialog();
        }

        private void registroDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVenta rv = new RegistroVenta();
            rv.ShowDialog();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVentas cv = new ConsultaVentas();
            cv.ShowDialog();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadistica est = new Estadistica();
            est.ShowDialog();
        }
    }
}
