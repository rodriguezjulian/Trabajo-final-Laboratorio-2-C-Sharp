namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Informe_Viajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Informe_Viajes));
            dtp_LimiteInferior = new DateTimePicker();
            dtp_LimiteSuperior = new DateTimePicker();
            pic_ReservarViajar = new PictureBox();
            pic_Cancelar = new PictureBox();
            lbl_InformeDeViajes = new Label();
            lbl_FechaInferior = new Label();
            label1 = new Label();
            lbl_GuardarInforme = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtp_LimiteInferior
            // 
            dtp_LimiteInferior.Location = new Point(32, 71);
            dtp_LimiteInferior.Name = "dtp_LimiteInferior";
            dtp_LimiteInferior.Size = new Size(255, 23);
            dtp_LimiteInferior.TabIndex = 1;
            // 
            // dtp_LimiteSuperior
            // 
            dtp_LimiteSuperior.Location = new Point(337, 73);
            dtp_LimiteSuperior.Name = "dtp_LimiteSuperior";
            dtp_LimiteSuperior.Size = new Size(255, 23);
            dtp_LimiteSuperior.TabIndex = 2;
            // 
            // pic_ReservarViajar
            // 
            pic_ReservarViajar.Image = Properties.Resources.guardar;
            pic_ReservarViajar.Location = new Point(204, 242);
            pic_ReservarViajar.Name = "pic_ReservarViajar";
            pic_ReservarViajar.Size = new Size(83, 76);
            pic_ReservarViajar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ReservarViajar.TabIndex = 72;
            pic_ReservarViajar.TabStop = false;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Image = (Image)resources.GetObject("pic_Cancelar.Image");
            pic_Cancelar.Location = new Point(337, 242);
            pic_Cancelar.Name = "pic_Cancelar";
            pic_Cancelar.Size = new Size(79, 76);
            pic_Cancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Cancelar.TabIndex = 75;
            pic_Cancelar.TabStop = false;
            // 
            // lbl_InformeDeViajes
            // 
            lbl_InformeDeViajes.AutoSize = true;
            lbl_InformeDeViajes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_InformeDeViajes.Location = new Point(251, 33);
            lbl_InformeDeViajes.Name = "lbl_InformeDeViajes";
            lbl_InformeDeViajes.Size = new Size(216, 30);
            lbl_InformeDeViajes.TabIndex = 76;
            lbl_InformeDeViajes.Text = "INFORME DE VIAJES";
            // 
            // lbl_FechaInferior
            // 
            lbl_FechaInferior.AutoSize = true;
            lbl_FechaInferior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FechaInferior.Location = new Point(32, 37);
            lbl_FechaInferior.Name = "lbl_FechaInferior";
            lbl_FechaInferior.Size = new Size(173, 21);
            lbl_FechaInferior.TabIndex = 77;
            lbl_FechaInferior.Text = "Viajes desde la fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 37);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 78;
            label1.Text = "Fecha tope:";
            // 
            // lbl_GuardarInforme
            // 
            lbl_GuardarInforme.AutoSize = true;
            lbl_GuardarInforme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GuardarInforme.Location = new Point(200, 334);
            lbl_GuardarInforme.Name = "lbl_GuardarInforme";
            lbl_GuardarInforme.Size = new Size(87, 21);
            lbl_GuardarInforme.TabIndex = 79;
            lbl_GuardarInforme.Text = "GUARDAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lbl_GuardarInforme);
            panel1.Controls.Add(pic_Cancelar);
            panel1.Controls.Add(lbl_FechaInferior);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtp_LimiteInferior);
            panel1.Controls.Add(pic_ReservarViajar);
            panel1.Controls.Add(dtp_LimiteSuperior);
            panel1.Location = new Point(53, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 374);
            panel1.TabIndex = 80;
            // 
            // Frm_Empleado_Informe_Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(720, 502);
            ControlBox = false;
            Controls.Add(lbl_InformeDeViajes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Informe_Viajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Empleado_Informe_Viajes";
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_LimiteInferior;
        private DateTimePicker dtp_LimiteSuperior;
        private PictureBox pic_ReservarViajar;
        private PictureBox pic_Cancelar;
        private Label lbl_InformeDeViajes;
        private Label lbl_FechaInferior;
        private Label label1;
        private Label lbl_GuardarInforme;
        private Panel panel1;
    }
}