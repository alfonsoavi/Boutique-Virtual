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
    public partial class Reporte_Filtros : Form
    {
        public Reporte_Filtros()
        {
            InitializeComponent();
        }
        public string talla;
        public string producto;

        private void Reporte_Filtros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.reporte_venta_filtro' Puede moverla o quitarla según sea necesario.
            this.reporte_venta_filtroTableAdapter.Fill(this.DataSet.reporte_venta_filtro,talla,producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
