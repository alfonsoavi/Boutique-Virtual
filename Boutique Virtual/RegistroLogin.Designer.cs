
namespace Boutique_Virtual
{
    partial class RegistroLogin
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
            this.t_user = new System.Windows.Forms.TextBox();
            this.t_contraseña1 = new System.Windows.Forms.TextBox();
            this.t_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_user
            // 
            this.t_user.Location = new System.Drawing.Point(197, 91);
            this.t_user.Name = "t_user";
            this.t_user.Size = new System.Drawing.Size(130, 20);
            this.t_user.TabIndex = 0;
            this.t_user.Validating += new System.ComponentModel.CancelEventHandler(this.t_user_Validating);
            // 
            // t_contraseña1
            // 
            this.t_contraseña1.Location = new System.Drawing.Point(197, 163);
            this.t_contraseña1.Name = "t_contraseña1";
            this.t_contraseña1.Size = new System.Drawing.Size(130, 20);
            this.t_contraseña1.TabIndex = 2;
            this.t_contraseña1.UseSystemPasswordChar = true;
            // 
            // t_contraseña
            // 
            this.t_contraseña.Location = new System.Drawing.Point(197, 128);
            this.t_contraseña.Name = "t_contraseña";
            this.t_contraseña.Size = new System.Drawing.Size(130, 20);
            this.t_contraseña.TabIndex = 1;
            this.t_contraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Contraseña :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_contraseña);
            this.Controls.Add(this.t_contraseña1);
            this.Controls.Add(this.t_user);
            this.Name = "RegistroLogin";
            this.Text = "Registro Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_user;
        private System.Windows.Forms.TextBox t_contraseña1;
        private System.Windows.Forms.TextBox t_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}