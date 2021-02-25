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
    public partial class Reporte_Talla : Form
    {
        public Reporte_Talla()
        {
            InitializeComponent();
        }
        public string talla;
        private void Reporte_Talla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.reporte_venta_filtro_talla' Puede moverla o quitarla según sea necesario.
            this.reporte_venta_filtro_tallaTableAdapter.Fill(this.DataSet.reporte_venta_filtro_talla,talla);

            this.reportViewer1.RefreshReport();
        }
    }
}
