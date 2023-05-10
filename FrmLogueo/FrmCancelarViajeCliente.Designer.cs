namespace WF_TransporteRodriguez
{
    partial class FrmCancelarViajeCliente
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
            pnl_TopNaranja = new Panel();
            pic_IconoPersona = new PictureBox();
            lbl_TransporteRodriguez = new Label();
            pnl_CancelarViaje = new Panel();
            label6 = new Label();
            dtg_ListarViajes = new DataGridView();
            lbl_IdCancelarViaje = new Label();
            txt_IdDeViajeACancelar = new TextBox();
            pic_EliminarViaje = new PictureBox();
            lbl_ConfirmarEliminacion = new Label();
            pnl_TopNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).BeginInit();
            pnl_CancelarViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).BeginInit();
            SuspendLayout();
            // 
            // pnl_TopNaranja
            // 
            pnl_TopNaranja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopNaranja.BackColor = Color.FromArgb(255, 192, 128);
            pnl_TopNaranja.Controls.Add(pic_IconoPersona);
            pnl_TopNaranja.Controls.Add(lbl_TransporteRodriguez);
            pnl_TopNaranja.Location = new Point(0, 0);
            pnl_TopNaranja.Name = "pnl_TopNaranja";
            pnl_TopNaranja.Size = new Size(706, 33);
            pnl_TopNaranja.TabIndex = 68;
            // 
            // pic_IconoPersona
            // 
            pic_IconoPersona.Image = Properties.Resources.persona;
            pic_IconoPersona.Location = new Point(376, 3);
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
            dtg_ListarViajes.Location = new Point(3, 152);
            dtg_ListarViajes.Name = "dtg_ListarViajes";
            dtg_ListarViajes.RowTemplate.Height = 25;
            dtg_ListarViajes.Size = new Size(706, 286);
            dtg_ListarViajes.TabIndex = 70;
            // 
            // lbl_IdCancelarViaje
            // 
            lbl_IdCancelarViaje.AutoSize = true;
            lbl_IdCancelarViaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IdCancelarViaje.Location = new Point(12, 88);
            lbl_IdCancelarViaje.Name = "lbl_IdCancelarViaje";
            lbl_IdCancelarViaje.Size = new Size(165, 17);
            lbl_IdCancelarViaje.TabIndex = 79;
            lbl_IdCancelarViaje.Text = "ID DE VIAJE A CANCELAR";
            // 
            // txt_IdDeViajeACancelar
            // 
            txt_IdDeViajeACancelar.BackColor = Color.FromArgb(255, 255, 192);
            txt_IdDeViajeACancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdDeViajeACancelar.Location = new Point(15, 108);
            txt_IdDeViajeACancelar.Name = "txt_IdDeViajeACancelar";
            txt_IdDeViajeACancelar.Size = new Size(162, 25);
            txt_IdDeViajeACancelar.TabIndex = 85;
            txt_IdDeViajeACancelar.TextAlign = HorizontalAlignment.Center;
            // 
            // pic_EliminarViaje
            // 
            pic_EliminarViaje.Image = Properties.Resources.eliminar;
            pic_EliminarViaje.Location = new Point(426, 78);
            pic_EliminarViaje.Name = "pic_EliminarViaje";
            pic_EliminarViaje.Size = new Size(68, 71);
            pic_EliminarViaje.SizeMode = PictureBoxSizeMode.Zoom;
            pic_EliminarViaje.TabIndex = 86;
            pic_EliminarViaje.TabStop = false;
            pic_EliminarViaje.Click += pic_EliminarViaje_Click;
            pic_EliminarViaje.MouseEnter += pic_EliminarViaje_MouseEnter;
            pic_EliminarViaje.MouseLeave += pic_EliminarViaje_MouseLeave;
            // 
            // lbl_ConfirmarEliminacion
            // 
            lbl_ConfirmarEliminacion.AutoSize = true;
            lbl_ConfirmarEliminacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ConfirmarEliminacion.Location = new Point(416, 58);
            lbl_ConfirmarEliminacion.Name = "lbl_ConfirmarEliminacion";
            lbl_ConfirmarEliminacion.Size = new Size(88, 17);
            lbl_ConfirmarEliminacion.TabIndex = 87;
            lbl_ConfirmarEliminacion.Text = "CONFIRMAR ";
            // 
            // FrmCancelarViajeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(704, 430);
            Controls.Add(lbl_ConfirmarEliminacion);
            Controls.Add(pic_EliminarViaje);
            Controls.Add(txt_IdDeViajeACancelar);
            Controls.Add(lbl_IdCancelarViaje);
            Controls.Add(dtg_ListarViajes);
            Controls.Add(pnl_CancelarViaje);
            Controls.Add(pnl_TopNaranja);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCancelarViajeCliente";
            Text = "FrmCancelarViajeCliente";
            Load += FrmCancelarViajeCliente_Load;
            pnl_TopNaranja.ResumeLayout(false);
            pnl_TopNaranja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).EndInit();
            pnl_CancelarViaje.ResumeLayout(false);
            pnl_CancelarViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_EliminarViaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Panel pnl_TopNaranja;
        protected PictureBox pic_IconoPersona;
        protected Label lbl_TransporteRodriguez;
        private Panel pnl_CancelarViaje;
        protected Label label6;
        private DataGridView dtg_ListarViajes;
        protected Label lbl_IdCancelarViaje;
        private TextBox txt_IdDeViajeACancelar;
        private PictureBox pic_EliminarViaje;
        protected Label lbl_ConfirmarEliminacion;
    }
}