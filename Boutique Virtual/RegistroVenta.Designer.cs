
namespace Boutique_Virtual
{
    partial class RegistroVenta
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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_unidades = new System.Windows.Forms.TextBox();
            this.c_productos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.t_cedula = new System.Windows.Forms.TextBox();
            this.t_factura = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Calcular Total";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total a Pagar:";
            // 
            // t_total
            // 
            this.t_total.Enabled = false;
            this.t_total.Location = new System.Drawing.Point(172, 280);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(65, 20);
            this.t_total.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Unidades:";
            // 
            // t_unidades
            // 
            this.t_unidades.Location = new System.Drawing.Point(172, 236);
            this.t_unidades.Name = "t_unidades";
            this.t_unidades.Size = new System.Drawing.Size(45, 20);
            this.t_unidades.TabIndex = 25;
            // 
            // c_productos
            // 
            this.c_productos.FormattingEnabled = true;
            this.c_productos.Location = new System.Drawing.Point(172, 197);
            this.c_productos.Name = "c_productos";
            this.c_productos.Size = new System.Drawing.Size(205, 21);
            this.c_productos.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cedula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "N° Factura";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_nombre
            // 
            this.t_nombre.Enabled = false;
            this.t_nombre.Location = new System.Drawing.Point(172, 147);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(175, 20);
            this.t_nombre.TabIndex = 18;
            // 
            // t_cedula
            // 
            this.t_cedula.Location = new System.Drawing.Point(172, 107);
            this.t_cedula.Name = "t_cedula";
            this.t_cedula.Size = new System.Drawing.Size(94, 20);
            this.t_cedula.TabIndex = 17;
            // 
            // t_factura
            // 
            this.t_factura.Enabled = false;
            this.t_factura.Location = new System.Drawing.Point(172, 62);
            this.t_factura.Name = "t_factura";
            this.t_factura.Size = new System.Drawing.Size(45, 20);
            this.t_factura.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Boutique_Virtual.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(297, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_unidades);
            this.Controls.Add(this.c_productos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_nombre);
            this.Controls.Add(this.t_cedula);
            this.Controls.Add(this.t_factura);
            this.Name = "RegistroVenta";
            this.Text = "Registro Venta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_unidades;
        private System.Windows.Forms.ComboBox c_productos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_nombre;
        private System.Windows.Forms.TextBox t_cedula;
        private System.Windows.Forms.TextBox t_factura;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}