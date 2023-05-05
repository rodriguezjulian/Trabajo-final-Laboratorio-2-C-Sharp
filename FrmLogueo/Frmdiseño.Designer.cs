namespace WF_TransporteRodriguez
{
    partial class Frmdiseño
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
            panel1 = new Panel();
            lbl_NombreUsuarioCliente = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btn_CerrarSesion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lbl_NombreUsuarioCliente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(149, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 33);
            panel1.TabIndex = 0;
            // 
            // lbl_NombreUsuarioCliente
            // 
            lbl_NombreUsuarioCliente.AutoSize = true;
            lbl_NombreUsuarioCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuarioCliente.Location = new Point(348, 8);
            lbl_NombreUsuarioCliente.Name = "lbl_NombreUsuarioCliente";
            lbl_NombreUsuarioCliente.Size = new Size(64, 20);
            lbl_NombreUsuarioCliente.TabIndex = 35;
            lbl_NombreUsuarioCliente.Text = "Nombre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.persona;
            pictureBox2.Location = new Point(295, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 30;
            label1.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // btn_CerrarSesion
            // 
            btn_CerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
            btn_CerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CerrarSesion.ForeColor = Color.Black;
            btn_CerrarSesion.Location = new Point(508, 251);
            btn_CerrarSesion.Name = "btn_CerrarSesion";
            btn_CerrarSesion.Size = new Size(118, 29);
            btn_CerrarSesion.TabIndex = 7;
            btn_CerrarSesion.Text = "Cerrar sesion";
            btn_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Frmdiseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 302);
            Controls.Add(btn_CerrarSesion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmdiseño";
            Text = "diseño";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel1;
        protected Label label1;
        protected PictureBox pictureBox2;
        protected Label lbl_NombreUsuarioCliente;
        protected Button btn_CerrarSesion;
    }
}