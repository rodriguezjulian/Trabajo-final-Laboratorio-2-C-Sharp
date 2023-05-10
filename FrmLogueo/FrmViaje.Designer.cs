namespace WF_TransporteRodriguez
{
    partial class FrmViaje
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViaje));
            lbl_NombreCliente = new Label();
            lbl_DireccionSalida = new Label();
            lbl_ProvinciaDestino = new Label();
            lbl_Fecha = new Label();
            txt_Nombre = new TextBox();
            txt_DireccionSalida = new TextBox();
            label1 = new Label();
            cbo_Provincias = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grp_CargosFijos = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grp_Viajes = new GroupBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            lbl_RerservarViaje = new Label();
            pic_ReservarViajar = new PictureBox();
            grp_DatosViaje = new GroupBox();
            nup_Kilos = new NumericUpDown();
            dtp_FechaDeViaje = new DateTimePicker();
            panel3 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            grp_CargosFijos.SuspendLayout();
            grp_Viajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).BeginInit();
            grp_DatosViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_Kilos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Location = new Point(2, 9);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(54, 15);
            lbl_NombreCliente.TabIndex = 45;
            lbl_NombreCliente.Text = "Nombre ";
            // 
            // lbl_DireccionSalida
            // 
            lbl_DireccionSalida.AutoSize = true;
            lbl_DireccionSalida.Location = new Point(2, 59);
            lbl_DireccionSalida.Name = "lbl_DireccionSalida";
            lbl_DireccionSalida.Size = new Size(106, 15);
            lbl_DireccionSalida.TabIndex = 46;
            lbl_DireccionSalida.Text = "Direccion de salida";
            // 
            // lbl_ProvinciaDestino
            // 
            lbl_ProvinciaDestino.AutoSize = true;
            lbl_ProvinciaDestino.Location = new Point(2, 125);
            lbl_ProvinciaDestino.Name = "lbl_ProvinciaDestino";
            lbl_ProvinciaDestino.Size = new Size(98, 15);
            lbl_ProvinciaDestino.TabIndex = 47;
            lbl_ProvinciaDestino.Text = "Provincia destino";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(2, 180);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(38, 15);
            lbl_Fecha.TabIndex = 49;
            lbl_Fecha.Text = "Fecha";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Nombre.BackColor = Color.FromArgb(255, 255, 192);
            txt_Nombre.Enabled = false;
            txt_Nombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(2, 28);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.ReadOnly = true;
            txt_Nombre.Size = new Size(255, 25);
            txt_Nombre.TabIndex = 50;
            txt_Nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_DireccionSalida
            // 
            txt_DireccionSalida.BackColor = Color.FromArgb(255, 255, 192);
            txt_DireccionSalida.Enabled = false;
            txt_DireccionSalida.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DireccionSalida.Location = new Point(2, 87);
            txt_DireccionSalida.Name = "txt_DireccionSalida";
            txt_DireccionSalida.Size = new Size(255, 25);
            txt_DireccionSalida.TabIndex = 53;
            txt_DireccionSalida.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 232);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 60;
            label1.Text = "Kg a transportar";
            // 
            // cbo_Provincias
            // 
            cbo_Provincias.FormattingEnabled = true;
            cbo_Provincias.Items.AddRange(new object[] { "Santa fe ", "Corrientes ", "Misiones" });
            cbo_Provincias.Location = new Point(2, 143);
            cbo_Provincias.Name = "cbo_Provincias";
            cbo_Provincias.Size = new Size(255, 23);
            cbo_Provincias.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 62;
            label2.Text = "Santa fe       Cargo fijo $4000 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 63;
            label3.Text = "Corrientes   Cargo fijo $6000 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 78);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 64;
            label4.Text = "Misiones     Cargo fijo $8000";
            // 
            // grp_CargosFijos
            // 
            grp_CargosFijos.Controls.Add(label2);
            grp_CargosFijos.Controls.Add(label4);
            grp_CargosFijos.Controls.Add(label3);
            grp_CargosFijos.Location = new Point(446, 97);
            grp_CargosFijos.Name = "grp_CargosFijos";
            grp_CargosFijos.Size = new Size(236, 140);
            grp_CargosFijos.TabIndex = 65;
            grp_CargosFijos.TabStop = false;
            grp_CargosFijos.Text = "DEPOSITOS";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grp_Viajes
            // 
            grp_Viajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grp_Viajes.BackColor = Color.FromArgb(255, 255, 192);
            grp_Viajes.Controls.Add(label7);
            grp_Viajes.Controls.Add(pictureBox4);
            grp_Viajes.Controls.Add(lbl_RerservarViaje);
            grp_Viajes.Controls.Add(pic_ReservarViajar);
            grp_Viajes.Controls.Add(grp_DatosViaje);
            grp_Viajes.Controls.Add(panel3);
            grp_Viajes.Controls.Add(panel2);
            grp_Viajes.Controls.Add(panel1);
            grp_Viajes.Controls.Add(grp_CargosFijos);
            grp_Viajes.Location = new Point(0, 0);
            grp_Viajes.Name = "grp_Viajes";
            grp_Viajes.Size = new Size(720, 469);
            grp_Viajes.TabIndex = 66;
            grp_Viajes.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(603, 342);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 75;
            label7.Text = "CANCELAR";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(603, 259);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 76);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 74;
            pictureBox4.TabStop = false;
            // 
            // lbl_RerservarViaje
            // 
            lbl_RerservarViaje.AutoSize = true;
            lbl_RerservarViaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RerservarViaje.Location = new Point(436, 341);
            lbl_RerservarViaje.Name = "lbl_RerservarViaje";
            lbl_RerservarViaje.Size = new Size(109, 17);
            lbl_RerservarViaje.TabIndex = 72;
            lbl_RerservarViaje.Text = "RESERVAR VIAJE";
            // 
            // pic_ReservarViajar
            // 
            pic_ReservarViajar.Image = Properties.Resources.guardar;
            pic_ReservarViajar.Location = new Point(446, 259);
            pic_ReservarViajar.Name = "pic_ReservarViajar";
            pic_ReservarViajar.Size = new Size(83, 76);
            pic_ReservarViajar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ReservarViajar.TabIndex = 71;
            pic_ReservarViajar.TabStop = false;
            pic_ReservarViajar.Click += pic_ReservarViajar_Click;
            // 
            // grp_DatosViaje
            // 
            grp_DatosViaje.Controls.Add(nup_Kilos);
            grp_DatosViaje.Controls.Add(dtp_FechaDeViaje);
            grp_DatosViaje.Controls.Add(cbo_Provincias);
            grp_DatosViaje.Controls.Add(label1);
            grp_DatosViaje.Controls.Add(txt_DireccionSalida);
            grp_DatosViaje.Controls.Add(txt_Nombre);
            grp_DatosViaje.Controls.Add(lbl_Fecha);
            grp_DatosViaje.Controls.Add(lbl_ProvinciaDestino);
            grp_DatosViaje.Controls.Add(lbl_DireccionSalida);
            grp_DatosViaje.Controls.Add(lbl_NombreCliente);
            grp_DatosViaje.Location = new Point(106, 88);
            grp_DatosViaje.Name = "grp_DatosViaje";
            grp_DatosViaje.Size = new Size(304, 327);
            grp_DatosViaje.TabIndex = 70;
            grp_DatosViaje.TabStop = false;
            // 
            // nup_Kilos
            // 
            nup_Kilos.Location = new Point(6, 253);
            nup_Kilos.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nup_Kilos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup_Kilos.Name = "nup_Kilos";
            nup_Kilos.Size = new Size(251, 23);
            nup_Kilos.TabIndex = 70;
            nup_Kilos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtp_FechaDeViaje
            // 
            dtp_FechaDeViaje.Location = new Point(2, 198);
            dtp_FechaDeViaje.Name = "dtp_FechaDeViaje";
            dtp_FechaDeViaje.Size = new Size(255, 23);
            dtp_FechaDeViaje.TabIndex = 69;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 403);
            panel3.TabIndex = 68;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, -3);
            label6.Name = "label6";
            label6.Size = new Size(180, 30);
            label6.TabIndex = 68;
            label6.Text = "RESERVAR VIAJE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 33);
            panel1.TabIndex = 66;
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
            label5.Location = new Point(-3, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 30);
            label5.TabIndex = 30;
            label5.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // FrmViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(grp_Viajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmViaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viaje";
            Load += FrmViaje_Load;
            grp_CargosFijos.ResumeLayout(false);
            grp_CargosFijos.PerformLayout();
            grp_Viajes.ResumeLayout(false);
            grp_Viajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).EndInit();
            grp_DatosViaje.ResumeLayout(false);
            grp_DatosViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_Kilos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_NombreCliente;
        private Label lbl_DireccionSalida;
        private Label lbl_ProvinciaDestino;
        private Label lbl_Fecha;
        private TextBox txt_Nombre;
        private TextBox txt_DireccionSalida;
        private Label label1;
        private ComboBox cbo_Provincias;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grp_CargosFijos;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grp_Viajes;
        protected Panel panel1;
        protected PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        protected Label label6;
        protected Label label5;
        private DateTimePicker dtp_FechaDeViaje;
        protected Label lbl_RerservarViaje;
        private PictureBox pic_ReservarViajar;
        private GroupBox grp_DatosViaje;
        protected Label label7;
        private PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private NumericUpDown nup_Kilos;
    }
}