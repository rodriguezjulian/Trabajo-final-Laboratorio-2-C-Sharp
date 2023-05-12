namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Modificacion_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Modificacion_Cliente));
            grp_DatosNuevoCliente = new GroupBox();
            pictureBox9 = new PictureBox();
            label3 = new Label();
            cbo_Rubro = new ComboBox();
            txt_ModNombre = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            txt_ModDireccion = new TextBox();
            txt_ModMail = new TextBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            dtg_ListarClientes = new DataGridView();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).BeginInit();
            SuspendLayout();
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Click += pic_Cancelar_Click;
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(219, 30);
            lbl_Opcion.Text = "MODIFICAR CLIENTE";
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 255, 192);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(label3);
            grp_DatosNuevoCliente.Controls.Add(cbo_Rubro);
            grp_DatosNuevoCliente.Controls.Add(txt_ModNombre);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(pictureBox6);
            grp_DatosNuevoCliente.Controls.Add(label6);
            grp_DatosNuevoCliente.Controls.Add(txt_ModDireccion);
            grp_DatosNuevoCliente.Controls.Add(txt_ModMail);
            grp_DatosNuevoCliente.Controls.Add(label2);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(95, 46);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(623, 129);
            grp_DatosNuevoCliente.TabIndex = 71;
            grp_DatosNuevoCliente.TabStop = false;
            grp_DatosNuevoCliente.Text = "Datos por ingresar";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.fabrica;
            pictureBox9.Location = new Point(315, 80);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 70);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 54;
            label3.Text = "Rubro";
            // 
            // cbo_Rubro
            // 
            cbo_Rubro.FormattingEnabled = true;
            cbo_Rubro.Items.AddRange(new object[] { "Libros", "Electrodosmesticos", "Muebles", "Ropa", "Juguetes", "Calzado", "Hogar", "Mascotas", "Computacion" });
            cbo_Rubro.Location = new Point(364, 91);
            cbo_Rubro.Name = "cbo_Rubro";
            cbo_Rubro.Size = new Size(249, 23);
            cbo_Rubro.TabIndex = 53;
            // 
            // txt_ModNombre
            // 
            txt_ModNombre.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModNombre.Location = new Point(62, 38);
            txt_ModNombre.Name = "txt_ModNombre";
            txt_ModNombre.Size = new Size(247, 25);
            txt_ModNombre.TabIndex = 42;
            txt_ModNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.persona;
            pictureBox3.Location = new Point(12, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(315, 28);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(364, 18);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 52;
            label6.Text = "Direccion";
            // 
            // txt_ModDireccion
            // 
            txt_ModDireccion.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModDireccion.Location = new Point(364, 38);
            txt_ModDireccion.Name = "txt_ModDireccion";
            txt_ModDireccion.Size = new Size(249, 25);
            txt_ModDireccion.TabIndex = 51;
            txt_ModDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ModMail
            // 
            txt_ModMail.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModMail.Location = new Point(62, 91);
            txt_ModMail.Name = "txt_ModMail";
            txt_ModMail.Size = new Size(247, 25);
            txt_ModMail.TabIndex = 48;
            txt_ModMail.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 70);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 47;
            label2.Text = "Mail";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 81);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // dtg_ListarClientes
            // 
            dtg_ListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarClientes.Location = new Point(95, 181);
            dtg_ListarClientes.Name = "dtg_ListarClientes";
            dtg_ListarClientes.RowTemplate.Height = 25;
            dtg_ListarClientes.Size = new Size(623, 276);
            dtg_ListarClientes.TabIndex = 55;
            
            dtg_ListarClientes.CellContentClick += dtg_ListarClientes_CellContentClick;
            // 
            // Frm_Empleado_Modificacion_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(dtg_ListarClientes);
            Controls.Add(grp_DatosNuevoCliente);
            Name = "Frm_Empleado_Modificacion_Cliente";
            Text = "Frm_Empleado_Modificacion_Cliente";
            Load += Frm_Empleado_Modificacion_Cliente_Load;
            Controls.SetChildIndex(pnl_PanelSup, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(grp_DatosNuevoCliente, 0);
            Controls.SetChildIndex(dtg_ListarClientes, 0);
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ReservarViajar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Label label3;
        private ComboBox cbo_Rubro;
        private TextBox txt_ModNombre;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label6;
        private TextBox txt_ModDireccion;
        private TextBox txt_ModMail;
        private Label label2;
        private PictureBox pictureBox5;
        private DataGridView dtg_ListarClientes;
    }
}