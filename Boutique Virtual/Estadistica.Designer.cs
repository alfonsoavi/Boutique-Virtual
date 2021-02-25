
namespace Boutique_Virtual
{
    partial class Estadistica
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.t_cantidad = new System.Windows.Forms.TextBox();
            this.t_ventas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.talla = new System.Windows.Forms.RadioButton();
            this.Producto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(59, 167);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(445, 187);
            this.Tabla.TabIndex = 12;
            // 
            // t_cantidad
            // 
            this.t_cantidad.Enabled = false;
            this.t_cantidad.Location = new System.Drawing.Point(248, 77);
            this.t_cantidad.Name = "t_cantidad";
            this.t_cantidad.Size = new System.Drawing.Size(100, 20);
            this.t_cantidad.TabIndex = 11;
            // 
            // t_ventas
            // 
            this.t_ventas.Enabled = false;
            this.t_ventas.Location = new System.Drawing.Point(248, 37);
            this.t_ventas.Name = "t_ventas";
            this.t_ventas.Size = new System.Drawing.Size(100, 20);
            this.t_ventas.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad de Ventas Realizadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total de Ingreso de Venta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.talla);
            this.groupBox1.Controls.Add(this.Producto);
            this.groupBox1.Location = new System.Drawing.Point(77, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // talla
            // 
            this.talla.AutoSize = true;
            this.talla.Location = new System.Drawing.Point(161, 10);
            this.talla.Name = "talla";
            this.talla.Size = new System.Drawing.Size(48, 17);
            this.talla.TabIndex = 1;
            this.talla.TabStop = true;
            this.talla.Text = "Talla";
            this.talla.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(40, 10);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(68, 17);
            this.Producto.TabIndex = 0;
            this.Producto.TabStop = true;
            this.Producto.Text = "Producto";
            this.Producto.UseVisualStyleBackColor = true;
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.t_cantidad);
            this.Controls.Add(this.t_ventas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.TextBox t_cantidad;
        private System.Windows.Forms.TextBox t_ventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton talla;
        private System.Windows.Forms.RadioButton Producto;
    }
}