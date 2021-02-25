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
    public partial class Reporte_General : Form
    {
        public Reporte_General()
        {
            InitializeComponent();
        }

        private void Reporte_General_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.reporte_venta' Puede moverla o quitarla según sea necesario.
            this.reporte_ventaTableAdapter.Fill(this.DataSet.reporte_venta);

            this.reportViewer1.RefreshReport();
        }
    }
}
