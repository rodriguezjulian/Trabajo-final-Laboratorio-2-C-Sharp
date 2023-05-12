namespace WF_TransporteRodriguez
{
    partial class Frm_Cliente_Cancelacion_Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente_Cancelacion_Viaje));
            lbl_NombreClient = new Label();
            pic_IconoPersona = new PictureBox();
            lbl_TransporteRodriguez = new Label();
            pnl_CancelarViaje = new Panel();
            pln_CancelarViaje = new Panel();
            lbl_Cancelar = new Label();
            label6 = new Label();
            dtg_ListaViajes = new DataGridView();
            lbl_IdCancelarViaje = new Label();
            txt_IdDeViajeACancelar = new TextBox();
            pic_EliminarViaje = new PictureBox();
            pic_Id = new PictureBox();
            pic_Cancelar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).BeginInit();
            pnl_CancelarViaje.SuspendLayout();
            pln_CancelarViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_NombreClient
            // 
            lbl_NombreClient.AutoSize = true;
            lbl_NombreClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreClient.Location = new Point(500, 2);
            lbl_NombreClient.Name = "lbl_NombreClient";
            lbl_NombreClient.Size = new Size(192, 30);
            lbl_NombreClient.TabIndex = 88;
            lbl_NombreClient.Text = "NOMBRE CLIENTE";
            // 
            // pic_IconoPersona
            // 
            pic_IconoPersona.Image = Properties.Resources.persona;
            pic_IconoPersona.Location = new Point(460, 3);
            pic_IconoPersona.Name = "pic_IconoPersona";
            pic_IconoPersona.Size = new Size(34, 27);
            pic_IconoPersona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_IconoPersona.TabIndex = 34;
            pic_IconoPersona.TabStop = false;
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
            // pnl_CancelarViaje
            // 
            pnl_CancelarViaje.BackColor = Color.FromArgb(255, 128, 0);
            pnl_CancelarViaje.Controls.Add(pln_CancelarViaje);
            pnl_CancelarViaje.Controls.Add(label6);
            pnl_CancelarViaje.Location = new Point(0, 29);
            pnl_CancelarViaje.Name = "pnl_CancelarViaje";
            pnl_CancelarViaje.Size = new Size(315, 40);
            pnl_CancelarViaje.TabIndex = 69;
            // 
            // pln_CancelarViaje
            // 
            pln_CancelarViaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pln_CancelarViaje.Controls.Add(lbl_Cancelar);
            pln_CancelarViaje.Location = new Point(0, -29);
            pln_CancelarViaje.Name = "pln_CancelarViaje";
            pln_CancelarViaje.Size = new Size(706, 432);
            pln_CancelarViaje.TabIndex = 93;
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.AutoSize = true;
            lbl_Cancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cancelar.Location = new Point(0, 36);
            lbl_Cancelar.Name = "lbl_Cancelar";
            lbl_Cancelar.Size = new Size(185, 30);
            lbl_Cancelar.TabIndex = 89;
            lbl_Cancelar.Text = "CANCELAR VIAJE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(185, 30);
            label6.TabIndex = 68;
            label6.Text = "CANCELAR VIAJE";
            // 
            // dtg_ListaViajes
            // 
            dtg_ListaViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_ListaViajes.BackgroundColor = Color.White;
            dtg_ListaViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListaViajes.Location = new Point(0, 155);
            dtg_ListaViajes.Name = "dtg_ListaViajes";
            dtg_ListaViajes.RowTemplate.Height = 25;
            dtg_ListaViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListaViajes.Size = new Size(721, 318);
            dtg_ListaViajes.TabIndex = 70;
            dtg_ListaViajes.CellClick += dtg_ListarViajes_CellClick;
            // 
            // lbl_IdCancelarViaje
            // 
            lbl_IdCancelarViaje.AutoSize = true;
            lbl_IdCancelarViaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IdCancelarViaje.Location = new Point(66, 88);
            lbl_IdCancelarViaje.Name = "lbl_IdCancelarViaje";
            lbl_IdCancelarViaje.Size = new Size(165, 17);
            lbl_IdCancelarViaje.TabIndex = 79;
            lbl_IdCancelarViaje.Text = "ID DE VIAJE A CANCELAR";
            // 
            // txt_IdDeViajeACancelar
            // 
            txt_IdDeViajeACancelar.BackColor = Color.FromArgb(224, 224, 224);
            txt_IdDeViajeACancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdDeViajeACancelar.Location = new Point(66, 108);
            txt_IdDeViajeACancelar.Name = "txt_IdDeViajeACancelar";
            txt_IdDeViajeACancelar.ReadOnly = true;
            txt_IdDeViajeACancelar.Size = new Size(162, 25);
            txt_IdDeViajeACancelar.TabIndex = 85;
            txt_IdDeViajeACancelar.TextAlign = HorizontalAlignment.Center;
            // 
            // pic_EliminarViaje
            // 
            pic_EliminarViaje.Image = Properties.Resources.eliminar;
            pic_EliminarViaje.Location = new Point(426, 87);
            pic_EliminarViaje.Name = "pic_EliminarViaje";
            pic_EliminarViaje.Size = new Size(68, 61);
            pic_EliminarViaje.SizeMode = PictureBoxSizeMode.Zoom;
            pic_EliminarViaje.TabIndex = 86;
            pic_EliminarViaje.TabStop = false;
            pic_EliminarViaje.Click += pic_EliminarViaje_Click;
            pic_EliminarViaje.MouseEnter += pic_EliminarViaje_MouseEnter;
            pic_EliminarViaje.MouseLeave += pic_EliminarViaje_MouseLeave;
            // 
            // pic_Id
            // 
            pic_Id.Image = Properties.Resources.ID;
            pic_Id.Location = new Point(3, 97);
            pic_Id.Name = "pic_Id";
            pic_Id.Size = new Size(57, 36);
            pic_Id.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Id.TabIndex = 88;
            pic_Id.TabStop = false;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Image = (Image)resources.GetObject("pic_Cancelar.Image");
            pic_Cancelar.Location = new Point(569, 88);
            pic_Cancelar.Name = "pic_Cancelar";
            pic_Cancelar.Size = new Size(66, 60);
            pic_Cancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Cancelar.TabIndex = 89;
            pic_Cancelar.TabStop = false;
            pic_Cancelar.Click += pic_Cancelar_Click;
            pic_Cancelar.MouseEnter += pic_Cancelar_MouseEnter;
            pic_Cancelar.MouseLeave += pic_Cancelar_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(569, 52);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 90;
            label1.Text = "PANTALLA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(426, 67);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 91;
            label2.Text = "CONFIRMAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(lbl_NombreClient);
            panel1.Controls.Add(lbl_TransporteRodriguez);
            panel1.Controls.Add(pic_IconoPersona);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 33);
            panel1.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(569, 69);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 93;
            label3.Text = "PRINCIPAL";
            // 
            // Frm_Cliente_Cancelacion_Viaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(720, 469);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_Cancelar);
            Controls.Add(dtg_ListaViajes);
            Controls.Add(pic_Id);
            Controls.Add(pic_EliminarViaje);
            Controls.Add(txt_IdDeViajeACancelar);
            Controls.Add(lbl_IdCancelarViaje);
            Controls.Add(pnl_CancelarViaje);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cliente_Cancelacion_Viaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCancelarViajeCliente";
            Load += FrmCancelarViajeCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).EndInit();
            pnl_CancelarViaje.ResumeLayout(false);
            pnl_CancelarViaje.PerformLayout();
            pln_CancelarViaje.ResumeLayout(false);
            pln_CancelarViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected PictureBox pic_IconoPersona;
        protected Label lbl_TransporteRodriguez;
        private Panel pnl_CancelarViaje;
        protected Label label6;
        private DataGridView dtg_ListaViajes;
        protected Label lbl_IdCancelarViaje;
        private TextBox txt_IdDeViajeACancelar;
        private PictureBox pic_EliminarViaje;
        protected Label lbl_NombreClient;
        private PictureBox pic_Id;
        private PictureBox pic_Cancelar;
        protected Label label1;
        protected Label label2;
        private Panel panel1;
        private Panel pln_CancelarViaje;
        protected Label lbl_Cancelar;
        protected Label label3;
    }
}