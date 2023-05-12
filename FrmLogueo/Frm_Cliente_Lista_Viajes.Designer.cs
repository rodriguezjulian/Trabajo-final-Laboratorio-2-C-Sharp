namespace WF_TransporteRodriguez
{
    partial class Frm_Cliente_Lista_Viajes
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
            dgt_ListarViajes = new DataGridView();
            grp_ListarViajesCliente = new GroupBox();
            pic_Atras = new PictureBox();
            lbl_Volver = new Label();
            panel2 = new Panel();
            lbl_Listar = new Label();
            panel1 = new Panel();
            lbl_NombreCliente = new Label();
            pic_Persona = new PictureBox();
            lbl_TransporteRodriguez = new Label();
            ((System.ComponentModel.ISupportInitialize)dgt_ListarViajes).BeginInit();
            grp_ListarViajesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Atras).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            SuspendLayout();
            // 
            // dgt_ListarViajes
            // 
            dgt_ListarViajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgt_ListarViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgt_ListarViajes.BackgroundColor = Color.White;
            dgt_ListarViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgt_ListarViajes.Location = new Point(3, 114);
            dgt_ListarViajes.Name = "dgt_ListarViajes";
            dgt_ListarViajes.RowTemplate.Height = 25;
            dgt_ListarViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgt_ListarViajes.Size = new Size(717, 343);
            dgt_ListarViajes.TabIndex = 0;
            // 
            // grp_ListarViajesCliente
            // 
            grp_ListarViajesCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grp_ListarViajesCliente.Controls.Add(pic_Atras);
            grp_ListarViajesCliente.Controls.Add(lbl_Volver);
            grp_ListarViajesCliente.Controls.Add(panel2);
            grp_ListarViajesCliente.Controls.Add(panel1);
            grp_ListarViajesCliente.Controls.Add(dgt_ListarViajes);
            grp_ListarViajesCliente.Location = new Point(0, 0);
            grp_ListarViajesCliente.Name = "grp_ListarViajesCliente";
            grp_ListarViajesCliente.Size = new Size(738, 469);
            grp_ListarViajesCliente.TabIndex = 1;
            grp_ListarViajesCliente.TabStop = false;
            // 
            // pic_Atras
            // 
            pic_Atras.Image = Properties.Resources.volver;
            pic_Atras.Location = new Point(603, 63);
            pic_Atras.Name = "pic_Atras";
            pic_Atras.Size = new Size(59, 50);
            pic_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Atras.TabIndex = 107;
            pic_Atras.TabStop = false;
            pic_Atras.Click += pic_Atras_Click;
            // 
            // lbl_Volver
            // 
            lbl_Volver.AutoSize = true;
            lbl_Volver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Volver.Location = new Point(603, 39);
            lbl_Volver.Name = "lbl_Volver";
            lbl_Volver.Size = new Size(59, 21);
            lbl_Volver.TabIndex = 106;
            lbl_Volver.Text = "Volver";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(lbl_Listar);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 69;
            // 
            // lbl_Listar
            // 
            lbl_Listar.AutoSize = true;
            lbl_Listar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Listar.Location = new Point(0, 5);
            lbl_Listar.Name = "lbl_Listar";
            lbl_Listar.Size = new Size(158, 30);
            lbl_Listar.TabIndex = 68;
            lbl_Listar.Text = "LISTAR VIAJES";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(lbl_NombreCliente);
            panel1.Controls.Add(pic_Persona);
            panel1.Controls.Add(lbl_TransporteRodriguez);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 33);
            panel1.TabIndex = 68;
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(416, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(192, 30);
            lbl_NombreCliente.TabIndex = 86;
            lbl_NombreCliente.Text = "NOMBRE CLIENTE";
            // 
            // pic_Persona
            // 
            pic_Persona.Image = Properties.Resources.persona;
            pic_Persona.Location = new Point(376, 3);
            pic_Persona.Name = "pic_Persona";
            pic_Persona.Size = new Size(34, 27);
            pic_Persona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Persona.TabIndex = 34;
            pic_Persona.TabStop = false;
            // 
            // lbl_TransporteRodriguez
            // 
            lbl_TransporteRodriguez.AutoSize = true;
            lbl_TransporteRodriguez.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TransporteRodriguez.Location = new Point(3, 0);
            lbl_TransporteRodriguez.Name = "lbl_TransporteRodriguez";
            lbl_TransporteRodriguez.Size = new Size(275, 30);
            lbl_TransporteRodriguez.TabIndex = 30;
            lbl_TransporteRodriguez.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // Frm_Cliente_Lista_Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 469);
            Controls.Add(grp_ListarViajesCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cliente_Lista_Viajes";
            Text = "FrmListarViajesCliente";
            Load += FrmListarViajesCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgt_ListarViajes).EndInit();
            grp_ListarViajesCliente.ResumeLayout(false);
            grp_ListarViajesCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Atras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgt_ListarViajes;
        private GroupBox grp_ListarViajesCliente;
        protected Panel panel1;
        protected Label lbl_NombreCliente;
        protected PictureBox pic_Persona;
        protected Label lbl_TransporteRodriguez;
        private Panel panel2;
        protected Label lbl_Listar;
        protected Label lbl_Volver;
        private PictureBox pic_Atras;
    }
}