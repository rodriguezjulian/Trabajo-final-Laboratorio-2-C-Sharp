namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Alta_Vehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Alta_Vehiculo));
            grp_DatosNuevoCliente = new GroupBox();
            cbo_Marca = new ComboBox();
            pictureBox2 = new PictureBox();
            cbo_Color = new ComboBox();
            lbl_Color = new Label();
            pictureBox1 = new PictureBox();
            lbl_Kg = new Label();
            nup_Kilos = new NumericUpDown();
            pictureBox9 = new PictureBox();
            lbl_Marca = new Label();
            txt_AltaPatente = new TextBox();
            lbl_Patente = new Label();
            pictureBox5 = new PictureBox();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nup_Kilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.Location = new Point(86, 33);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Size = new Size(89, 469);
            // 
            // pic_Guardar
            // 
            pic_Guardar.Click += pic_Guardar_Click;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Click += pic_Cancelar_Click;
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.Size = new Size(0, 15);
            lbl_Cancelar.Text = "";
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(188, 30);
            lbl_Opcion.Text = "CREAR VEHICULO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(grp_DatosNuevoCliente);
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(grp_DatosNuevoCliente, 0);
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 224, 192);
            grp_DatosNuevoCliente.Controls.Add(cbo_Marca);
            grp_DatosNuevoCliente.Controls.Add(pictureBox2);
            grp_DatosNuevoCliente.Controls.Add(cbo_Color);
            grp_DatosNuevoCliente.Controls.Add(lbl_Color);
            grp_DatosNuevoCliente.Controls.Add(pictureBox1);
            grp_DatosNuevoCliente.Controls.Add(lbl_Kg);
            grp_DatosNuevoCliente.Controls.Add(nup_Kilos);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(lbl_Marca);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaPatente);
            grp_DatosNuevoCliente.Controls.Add(lbl_Patente);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(223, 98);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(317, 339);
            grp_DatosNuevoCliente.TabIndex = 71;
            grp_DatosNuevoCliente.TabStop = false;
            grp_DatosNuevoCliente.Text = "Datos por ingresar";
            // 
            // cbo_Marca
            // 
            cbo_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Marca.FormattingEnabled = true;
            cbo_Marca.Location = new Point(59, 49);
            cbo_Marca.Name = "cbo_Marca";
            cbo_Marca.Size = new Size(252, 23);
            cbo_Marca.TabIndex = 72;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // cbo_Color
            // 
            cbo_Color.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color.FormattingEnabled = true;
            cbo_Color.Location = new Point(65, 242);
            cbo_Color.Name = "cbo_Color";
            cbo_Color.Size = new Size(249, 23);
            cbo_Color.TabIndex = 59;
            // 
            // lbl_Color
            // 
            lbl_Color.AutoSize = true;
            lbl_Color.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Color.Location = new Point(62, 222);
            lbl_Color.Name = "lbl_Color";
            lbl_Color.Size = new Size(41, 17);
            lbl_Color.TabIndex = 58;
            lbl_Color.Text = "Color";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // lbl_Kg
            // 
            lbl_Kg.AutoSize = true;
            lbl_Kg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Kg.Location = new Point(59, 150);
            lbl_Kg.Name = "lbl_Kg";
            lbl_Kg.Size = new Size(158, 17);
            lbl_Kg.TabIndex = 56;
            lbl_Kg.Text = "Capacidad de carga (KG)";
            // 
            // nup_Kilos
            // 
            nup_Kilos.Location = new Point(62, 179);
            nup_Kilos.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nup_Kilos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup_Kilos.Name = "nup_Kilos";
            nup_Kilos.ReadOnly = true;
            nup_Kilos.Size = new Size(252, 23);
            nup_Kilos.TabIndex = 55;
            nup_Kilos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(8, 27);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Marca.Location = new Point(62, 25);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(45, 17);
            lbl_Marca.TabIndex = 54;
            lbl_Marca.Text = "Marca";
            // 
            // txt_AltaPatente
            // 
            txt_AltaPatente.BackColor = Color.White;
            txt_AltaPatente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaPatente.Location = new Point(59, 105);
            txt_AltaPatente.Name = "txt_AltaPatente";
            txt_AltaPatente.PlaceholderText = "111AAA";
            txt_AltaPatente.Size = new Size(252, 25);
            txt_AltaPatente.TabIndex = 48;
            txt_AltaPatente.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Patente
            // 
            lbl_Patente.AutoSize = true;
            lbl_Patente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Patente.Location = new Point(62, 85);
            lbl_Patente.Name = "lbl_Patente";
            lbl_Patente.Size = new Size(138, 17);
            lbl_Patente.TabIndex = 47;
            lbl_Patente.Text = "Patente, Ej \"111AAA\"";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 104);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // Frm_Empleado_Alta_Vehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Empleado_Alta_Vehiculo";
            Text = "Frm_Empleado_Alta_Vehiculo";
            Load += Frm_Empleado_Alta_Vehiculo_Load;
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nup_Kilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Label lbl_Marca;
        private PictureBox pictureBox6;
        private Label label6;
        private TextBox txt_AltaDireccion;
        private TextBox txt_AltaPatente;
        private Label lbl_Patente;
        private PictureBox pictureBox5;
        private ComboBox cbo_Color;
        private Label lbl_Color;
        private PictureBox pictureBox1;
        private Label lbl_Kg;
        private NumericUpDown nup_Kilos;
        private PictureBox pictureBox2;
        private ComboBox cbo_Marca;
    }
}