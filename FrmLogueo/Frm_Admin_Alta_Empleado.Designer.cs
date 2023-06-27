namespace WF_TransporteRodriguez
{
    partial class Frm_Admin_Alta_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Alta_Empleado));
            grp_DatosNuevoCliente = new GroupBox();
            pic_Flecha = new PictureBox();
            cbo_Mail = new ComboBox();
            lbl_TipoMail = new Label();
            pictureBox9 = new PictureBox();
            lbl_Puesto = new Label();
            cbo_Puesto = new ComboBox();
            txt_AltaNombre = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            txt_AltaMail = new TextBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Flecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            lbl_Opcion.Size = new Size(182, 30);
            lbl_Opcion.Text = "ALTA EMPLEADO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(grp_DatosNuevoCliente);
            panel1.Paint += panel1_Paint;
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(grp_DatosNuevoCliente, 0);
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 224, 192);
            grp_DatosNuevoCliente.Controls.Add(pic_Flecha);
            grp_DatosNuevoCliente.Controls.Add(cbo_Mail);
            grp_DatosNuevoCliente.Controls.Add(lbl_TipoMail);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(lbl_Puesto);
            grp_DatosNuevoCliente.Controls.Add(cbo_Puesto);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaNombre);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaMail);
            grp_DatosNuevoCliente.Controls.Add(label2);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(240, 98);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(317, 339);
            grp_DatosNuevoCliente.TabIndex = 71;
            grp_DatosNuevoCliente.TabStop = false;
            grp_DatosNuevoCliente.Text = "Datos por ingresar";
            // 
            // pic_Flecha
            // 
            pic_Flecha.Image = (Image)resources.GetObject("pic_Flecha.Image");
            pic_Flecha.Location = new Point(12, 193);
            pic_Flecha.Name = "pic_Flecha";
            pic_Flecha.Size = new Size(44, 35);
            pic_Flecha.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Flecha.TabIndex = 61;
            pic_Flecha.TabStop = false;
            // 
            // cbo_Mail
            // 
            cbo_Mail.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Mail.FormattingEnabled = true;
            cbo_Mail.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com", "@transporterodriguez.com" });
            cbo_Mail.Location = new Point(70, 213);
            cbo_Mail.Name = "cbo_Mail";
            cbo_Mail.Size = new Size(247, 23);
            cbo_Mail.TabIndex = 58;
            // 
            // lbl_TipoMail
            // 
            lbl_TipoMail.AutoSize = true;
            lbl_TipoMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TipoMail.Location = new Point(70, 193);
            lbl_TipoMail.Name = "lbl_TipoMail";
            lbl_TipoMail.Size = new Size(86, 17);
            lbl_TipoMail.TabIndex = 57;
            lbl_TipoMail.Text = "Tipo de mail";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 261);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // lbl_Puesto
            // 
            lbl_Puesto.AutoSize = true;
            lbl_Puesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Puesto.Location = new Point(70, 253);
            lbl_Puesto.Name = "lbl_Puesto";
            lbl_Puesto.Size = new Size(50, 17);
            lbl_Puesto.TabIndex = 54;
            lbl_Puesto.Text = "Puesto";
            // 
            // cbo_Puesto
            // 
            cbo_Puesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Puesto.FormattingEnabled = true;
            cbo_Puesto.Items.AddRange(new object[] { "Libros", "Electrodosmesticos", "Muebles", "Ropa", "Juguetes", "Calzado", "Hogar", "Mascotas", "Computacion" });
            cbo_Puesto.Location = new Point(68, 273);
            cbo_Puesto.Name = "cbo_Puesto";
            cbo_Puesto.Size = new Size(249, 23);
            cbo_Puesto.TabIndex = 53;
            // 
            // txt_AltaNombre
            // 
            txt_AltaNombre.BackColor = Color.White;
            txt_AltaNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaNombre.Location = new Point(64, 68);
            txt_AltaNombre.Name = "txt_AltaNombre";
            txt_AltaNombre.Size = new Size(253, 25);
            txt_AltaNombre.TabIndex = 42;
            txt_AltaNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 46);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.persona;
            pictureBox3.Location = new Point(12, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // txt_AltaMail
            // 
            txt_AltaMail.BackColor = Color.White;
            txt_AltaMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaMail.Location = new Point(70, 150);
            txt_AltaMail.Name = "txt_AltaMail";
            txt_AltaMail.Size = new Size(247, 25);
            txt_AltaMail.TabIndex = 48;
            txt_AltaMail.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 130);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 47;
            label2.Text = "Mail, sin \"@\"";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 140);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // Frm_Admin_Alta_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Admin_Alta_Empleado";
            Text = "Frm_Admin_Alta_Empleado";
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Flecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Label lbl_Puesto;
        private ComboBox cbo_Puesto;
        private TextBox txt_AltaNombre;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox txt_AltaMail;
        private Label label2;
        private PictureBox pictureBox5;
        private Label lbl_TipoMail;
        private ComboBox cbo_Mail;
        private PictureBox pic_Flecha;
    }
}