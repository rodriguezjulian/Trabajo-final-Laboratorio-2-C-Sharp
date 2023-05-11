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
            label6 = new Label();
            dtg_ListarViajes = new DataGridView();
            lbl_IdCancelarViaje = new Label();
            txt_IdDeViajeACancelar = new TextBox();
            pic_EliminarViaje = new PictureBox();
            pic_Id = new PictureBox();
            pic_Cancelar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnl_TopNaranja = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).BeginInit();
            pnl_CancelarViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            SuspendLayout();
            // 
            // lbl_NombreClient
            // 
            lbl_NombreClient.AutoSize = true;
            lbl_NombreClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreClient.Location = new Point(426, 67);
            lbl_NombreClient.Name = "lbl_NombreClient";
            lbl_NombreClient.Size = new Size(192, 30);
            lbl_NombreClient.TabIndex = 88;
            lbl_NombreClient.Text = "NOMBRE CLIENTE";
            // 
            // pic_IconoPersona
            // 
            pic_IconoPersona.Image = Properties.Resources.persona;
            pic_IconoPersona.Location = new Point(386, 57);
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
            lbl_TransporteRodriguez.Location = new Point(66, 88);
            lbl_TransporteRodriguez.Name = "lbl_TransporteRodriguez";
            lbl_TransporteRodriguez.Size = new Size(275, 30);
            lbl_TransporteRodriguez.TabIndex = 30;
            lbl_TransporteRodriguez.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // pnl_CancelarViaje
            // 
            pnl_CancelarViaje.BackColor = Color.FromArgb(255, 128, 0);
            pnl_CancelarViaje.Controls.Add(label6);
            pnl_CancelarViaje.Location = new Point(0, 29);
            pnl_CancelarViaje.Name = "pnl_CancelarViaje";
            pnl_CancelarViaje.Size = new Size(315, 40);
            pnl_CancelarViaje.TabIndex = 69;
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
            // dtg_ListarViajes
            // 
            dtg_ListarViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarViajes.Location = new Point(0, 155);
            dtg_ListarViajes.Name = "dtg_ListarViajes";
            dtg_ListarViajes.RowTemplate.Height = 25;
            dtg_ListarViajes.Size = new Size(706, 277);
            dtg_ListarViajes.TabIndex = 70;
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
            txt_IdDeViajeACancelar.BackColor = Color.FromArgb(255, 255, 192);
            txt_IdDeViajeACancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdDeViajeACancelar.Location = new Point(66, 108);
            txt_IdDeViajeACancelar.Name = "txt_IdDeViajeACancelar";
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
            label1.Location = new Point(569, 67);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 90;
            label1.Text = "CANCELAR";
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
            // pnl_TopNaranja
            // 
            pnl_TopNaranja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopNaranja.BackColor = Color.FromArgb(255, 192, 128);
            pnl_TopNaranja.Location = new Point(0, 0);
            pnl_TopNaranja.Name = "pnl_TopNaranja";
            pnl_TopNaranja.Size = new Size(706, 33);
            pnl_TopNaranja.TabIndex = 68;
            // 
            // Frm_Cliente_Cancelacion_Viaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(704, 430);
            Controls.Add(lbl_TransporteRodriguez);
            Controls.Add(pic_IconoPersona);
            Controls.Add(lbl_NombreClient);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_Cancelar);
            Controls.Add(dtg_ListarViajes);
            Controls.Add(pic_Id);
            Controls.Add(pic_EliminarViaje);
            Controls.Add(txt_IdDeViajeACancelar);
            Controls.Add(lbl_IdCancelarViaje);
            Controls.Add(pnl_CancelarViaje);
            Controls.Add(pnl_TopNaranja);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cliente_Cancelacion_Viaje";
            Text = "FrmCancelarViajeCliente";
            Load += FrmCancelarViajeCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).EndInit();
            pnl_CancelarViaje.ResumeLayout(false);
            pnl_CancelarViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected PictureBox pic_IconoPersona;
        protected Label lbl_TransporteRodriguez;
        private Panel pnl_CancelarViaje;
        protected Label label6;
        private DataGridView dtg_ListarViajes;
        protected Label lbl_IdCancelarViaje;
        private TextBox txt_IdDeViajeACancelar;
        private PictureBox pic_EliminarViaje;
        protected Label lbl_NombreClient;
        private PictureBox pic_Id;
        private PictureBox pic_Cancelar;
        protected Label label1;
        protected Label label2;
        protected Panel pnl_TopNaranja;
    }
}