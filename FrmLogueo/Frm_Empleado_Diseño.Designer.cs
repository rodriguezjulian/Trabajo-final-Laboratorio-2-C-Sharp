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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Diseño));
            pnl_PanelSup = new Panel();
            lbl_Opcion = new Label();
            panel2 = new Panel();
            pic_Guardar = new PictureBox();
            pic_Cancelar = new PictureBox();
            lbl_Cancelar = new Label();
            lbl_Guardar = new Label();
            lbl_Acciones = new Label();
            panel1 = new Panel();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.BackColor = Color.FromArgb(255, 128, 0);
            pnl_PanelSup.Controls.Add(lbl_Opcion);
            pnl_PanelSup.Location = new Point(89, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 69;
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.AutoSize = true;
            lbl_Opcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Opcion.Location = new Point(6, 9);
            lbl_Opcion.Name = "lbl_Opcion";
            lbl_Opcion.Size = new Size(77, 30);
            lbl_Opcion.TabIndex = 72;
            lbl_Opcion.Text = "TEXTO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pic_Guardar);
            panel2.Controls.Add(pic_Cancelar);
            panel2.Controls.Add(lbl_Cancelar);
            panel2.Controls.Add(lbl_Guardar);
            panel2.Controls.Add(lbl_Acciones);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 468);
            panel2.TabIndex = 70;
            // 
            // pic_Guardar
            // 
            pic_Guardar.Image = Properties.Resources.guardar;
            pic_Guardar.Location = new Point(7, 135);
            pic_Guardar.Name = "pic_Guardar";
            pic_Guardar.Size = new Size(75, 75);
            pic_Guardar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Guardar.TabIndex = 72;
            pic_Guardar.TabStop = false;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Image = (Image)resources.GetObject("pic_Cancelar.Image");
            pic_Cancelar.Location = new Point(9, 256);
            pic_Cancelar.Name = "pic_Cancelar";
            pic_Cancelar.Size = new Size(70, 65);
            pic_Cancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Cancelar.TabIndex = 75;
            pic_Cancelar.TabStop = false;
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.AutoSize = true;
            lbl_Cancelar.Location = new Point(16, 324);
            lbl_Cancelar.Name = "lbl_Cancelar";
            lbl_Cancelar.Size = new Size(53, 15);
            lbl_Cancelar.TabIndex = 47;
            lbl_Cancelar.Text = "Cancelar";
            // 
            // lbl_Guardar
            // 
            lbl_Guardar.AutoSize = true;
            lbl_Guardar.Location = new Point(16, 213);
            lbl_Guardar.Name = "lbl_Guardar";
            lbl_Guardar.Size = new Size(49, 15);
            lbl_Guardar.TabIndex = 45;
            lbl_Guardar.Text = "Guardar";
            // 
            // lbl_Acciones
            // 
            lbl_Acciones.AutoSize = true;
            lbl_Acciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Acciones.Location = new Point(-2, 90);
            lbl_Acciones.Name = "lbl_Acciones";
            lbl_Acciones.Size = new Size(89, 21);
            lbl_Acciones.TabIndex = 43;
            lbl_Acciones.Text = "ACCIONES";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnl_PanelSup);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 469);
            panel1.TabIndex = 76;
            // 
            // Frm_Empleado_Diseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Diseño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba";
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel pnl_PanelSup;
        public Panel panel2;
        public PictureBox pic_Guardar;
        public PictureBox pic_Cancelar;
        public Label lbl_Cancelar;
        public Label lbl_Guardar;
        public Label lbl_Acciones;
        public Label lbl_Opcion;
        private Panel panel1;
    }
}