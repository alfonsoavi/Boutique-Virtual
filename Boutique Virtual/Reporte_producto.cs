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
    public partial class Reporte_producto : Form
    {
        public Reporte_producto()
        {
            InitializeComponent();
        }

        public string producto;
        private void Reporte_producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.reporte_venta_filtro_producto' Puede moverla o quitarla según sea necesario.
            this.reporte_venta_filtro_productoTableAdapter.Fill(this.DataSet.reporte_venta_filtro_producto,producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
