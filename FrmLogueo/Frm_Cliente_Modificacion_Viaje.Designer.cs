﻿namespace WF_TransporteRodriguez
{
    partial class Frm_Cliente_Modificacion_Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente_Modificacion_Viaje));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pic_Id = new PictureBox();
            label3 = new Label();
            txt_IdDeViajeAModificar = new TextBox();
            txt_Kg = new TextBox();
            label2 = new Label();
            dtp_FechaDeViaje = new DateTimePicker();
            label1 = new Label();
            pic_EditarViaje = new PictureBox();
            lbl_RerservarViaje = new Label();
            label7 = new Label();
            pic_CancelarModificacion = new PictureBox();
            dtg_ListarViajes = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            lbl_NombreCliente = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_EditarViaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_CancelarModificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pic_Id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_IdDeViajeAModificar);
            groupBox1.Controls.Add(txt_Kg);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtp_FechaDeViaje);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pic_EditarViaje);
            groupBox1.Controls.Add(lbl_RerservarViaje);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pic_CancelarModificacion);
            groupBox1.Controls.Add(dtg_ListarViajes);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 469);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carga;
            pictureBox1.Location = new Point(3, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // pic_Id
            // 
            pic_Id.Image = Properties.Resources.ID;
            pic_Id.Location = new Point(0, 93);
            pic_Id.Name = "pic_Id";
            pic_Id.Size = new Size(57, 36);
            pic_Id.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Id.TabIndex = 89;
            pic_Id.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 135);
            label3.Name = "label3";
            label3.Size = new Size(134, 17);
            label3.TabIndex = 85;
            label3.Text = "KG A TRANSPORTAR";
            // 
            // txt_IdDeViajeAModificar
            // 
            txt_IdDeViajeAModificar.BackColor = Color.FromArgb(255, 255, 192);
            txt_IdDeViajeAModificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdDeViajeAModificar.Location = new Point(63, 99);
            txt_IdDeViajeAModificar.Name = "txt_IdDeViajeAModificar";
            txt_IdDeViajeAModificar.Size = new Size(165, 25);
            txt_IdDeViajeAModificar.TabIndex = 84;
            txt_IdDeViajeAModificar.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Kg
            // 
            txt_Kg.BackColor = Color.FromArgb(255, 255, 192);
            txt_Kg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Kg.Location = new Point(63, 152);
            txt_Kg.Name = "txt_Kg";
            txt_Kg.Size = new Size(165, 25);
            txt_Kg.TabIndex = 83;
            txt_Kg.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(251, 81);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 82;
            label2.Text = "NUEVA FECHA";
            // 
            // dtp_FechaDeViaje
            // 
            dtp_FechaDeViaje.Location = new Point(251, 101);
            dtp_FechaDeViaje.MinDate = new DateTime(2023, 5, 9, 0, 0, 0, 0);
            dtp_FechaDeViaje.Name = "dtp_FechaDeViaje";
            dtp_FechaDeViaje.Size = new Size(200, 23);
            dtp_FechaDeViaje.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(492, 160);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 80;
            label1.Text = "EDITAR";
            // 
            // pic_EditarViaje
            // 
            pic_EditarViaje.Image = Properties.Resources.modificarCliente;
            pic_EditarViaje.Location = new Point(478, 81);
            pic_EditarViaje.Name = "pic_EditarViaje";
            pic_EditarViaje.Size = new Size(83, 76);
            pic_EditarViaje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_EditarViaje.TabIndex = 79;
            pic_EditarViaje.TabStop = false;
            pic_EditarViaje.Click += pic_EditarViaje_Click;
            pic_EditarViaje.MouseEnter += pic_EditarViaje_MouseEnter;
            pic_EditarViaje.MouseLeave += pic_EditarViaje_MouseLeave;
            // 
            // lbl_RerservarViaje
            // 
            lbl_RerservarViaje.AutoSize = true;
            lbl_RerservarViaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RerservarViaje.Location = new Point(63, 81);
            lbl_RerservarViaje.Name = "lbl_RerservarViaje";
            lbl_RerservarViaje.Size = new Size(171, 17);
            lbl_RerservarViaje.TabIndex = 78;
            lbl_RerservarViaje.Text = "ID DE VIAJE A MODIFICAR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(618, 163);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 76;
            label7.Text = "CANCELAR";
            // 
            // pic_CancelarModificacion
            // 
            pic_CancelarModificacion.Image = (Image)resources.GetObject("pic_CancelarModificacion.Image");
            pic_CancelarModificacion.Location = new Point(618, 81);
            pic_CancelarModificacion.Name = "pic_CancelarModificacion";
            pic_CancelarModificacion.Size = new Size(79, 76);
            pic_CancelarModificacion.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_CancelarModificacion.TabIndex = 75;
            pic_CancelarModificacion.TabStop = false;
            pic_CancelarModificacion.Click += pic_CancelarModificacion_Click;
            pic_CancelarModificacion.MouseEnter += pic_CancelarModificacion_MouseEnter;
            pic_CancelarModificacion.MouseLeave += pic_CancelarModificacion_MouseLeave;
            // 
            // dtg_ListarViajes
            // 
            dtg_ListarViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarViajes.Location = new Point(0, 183);
            dtg_ListarViajes.Name = "dtg_ListarViajes";
            dtg_ListarViajes.RowTemplate.Height = 25;
            dtg_ListarViajes.Size = new Size(720, 286);
            dtg_ListarViajes.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, -3);
            label6.Name = "label6";
            label6.Size = new Size(194, 30);
            label6.TabIndex = 68;
            label6.Text = "MODIFICAR VIAJE";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(lbl_NombreCliente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 33);
            panel1.TabIndex = 67;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.persona;
            pictureBox2.Location = new Point(376, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 30);
            label5.TabIndex = 30;
            label5.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // Frm_Cliente_Modificacion_Viaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 469);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cliente_Modificacion_Viaje";
            Text = "FrmModificarViaje";
            Load += FrmModificarViajeCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_EditarViaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_CancelarModificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarViajes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        protected Panel panel1;
        protected PictureBox pictureBox2;
        protected Label label5;
        private Panel panel2;
        protected Label label6;
        private DataGridView dtg_ListarViajes;
        private PictureBox pic_CancelarModificacion;
        protected Label label7;
        protected Label lbl_RerservarViaje;
        private PictureBox pic_EditarViaje;
        protected Label label1;
        protected Label label2;
        private DateTimePicker dtp_FechaDeViaje;
        protected Label label3;
        private TextBox txt_IdDeViajeAModificar;
        private TextBox txt_Kg;
        protected Label lbl_NombreCliente;
        private PictureBox pictureBox1;
        private PictureBox pic_Id;
    }
}