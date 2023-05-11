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
            panel1 = new Panel();
            pic_ReservarViajar = new PictureBox();
            pic_Cancelar = new PictureBox();
            lbl_Cancelar = new Label();
            lbl_Guardar = new Label();
            lbl_Acciones = new Label();
            pnl_PanelSup = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pic_ReservarViajar);
            panel1.Controls.Add(pic_Cancelar);
            panel1.Controls.Add(lbl_Cancelar);
            panel1.Controls.Add(lbl_Guardar);
            panel1.Controls.Add(lbl_Acciones);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 468);
            panel1.TabIndex = 42;
            // 
            // pic_ReservarViajar
            // 
            pic_ReservarViajar.Image = Properties.Resources.guardar;
            pic_ReservarViajar.Location = new Point(7, 135);
            pic_ReservarViajar.Name = "pic_ReservarViajar";
            pic_ReservarViajar.Size = new Size(75, 75);
            pic_ReservarViajar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ReservarViajar.TabIndex = 72;
            pic_ReservarViajar.TabStop = false;
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
            // pnl_PanelSup
            // 
            pnl_PanelSup.BackColor = Color.FromArgb(255, 128, 0);
            pnl_PanelSup.Location = new Point(89, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 69;
            // 
            // Frm_Empleado_Diseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(pnl_PanelSup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Diseño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbl_Cancelar;
        private Label lbl_Guardar;
        private Label lbl_Acciones;
        private Panel pnl_PanelSup;
        protected PictureBox pic_Cancelar;
        protected PictureBox pic_ReservarViajar;
    }
}