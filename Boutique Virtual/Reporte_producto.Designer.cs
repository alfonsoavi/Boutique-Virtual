
namespace Boutique_Virtual
{
    partial class Reporte_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporte_venta_filtro_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new Boutique_Virtual.DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_venta_filtro_productoTableAdapter = new Boutique_Virtual.DataSetTableAdapters.reporte_venta_filtro_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_venta_filtro_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_venta_filtro_productoBindingSource
            // 
            this.reporte_venta_filtro_productoBindingSource.DataMember = "reporte_venta_filtro_producto";
            this.reporte_venta_filtro_productoBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteProducto";
            reportDataSource1.Value = this.reporte_venta_filtro_productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Boutique_Virtual.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte_venta_filtro_productoTableAdapter
            // 
            this.reporte_venta_filtro_productoTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_producto";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_venta_filtro_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_venta_filtro_productoBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.reporte_venta_filtro_productoTableAdapter reporte_venta_filtro_productoTableAdapter;
    }
}