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
    public partial class Reporte_factura : Form
    {
        public Reporte_factura()
        {
            InitializeComponent();
        }
        public int factura ;
        private void Reporte_factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.reporte_factura' Puede moverla o quitarla según sea necesario.
            this.reporte_facturaTableAdapter.Fill(this.DataSet.reporte_factura,factura);

            this.reportViewer1.RefreshReport();
        }
    }
}
