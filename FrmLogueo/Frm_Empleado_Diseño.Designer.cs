namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Diseño
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
            panel5 = new Panel();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 192);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(89, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(632, 33);
            panel5.TabIndex = 41;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.persona;
            pictureBox8.Location = new Point(406, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 58;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(7, 1);
            label7.Name = "label7";
            label7.Size = new Size(314, 32);
            label7.TabIndex = 30;
            label7.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 468);
            panel1.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 304);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 47;
            label9.Text = "Cancelar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 204);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 45;
            label8.Text = "Guardar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 36);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 43;
            label5.Text = "ACCIONES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(89, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 69;
            // 
            // Frm_Empleado_Diseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Diseño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private PictureBox pictureBox8;
        private Label label7;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label5;
        private Panel panel2;
    }
}