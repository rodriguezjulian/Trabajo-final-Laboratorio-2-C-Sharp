namespace WF_TransporteRodriguez
{
    partial class FrmDatosCliente
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
            panel1 = new Panel();
            lbl_NombreCliente = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            pic_Id = new PictureBox();
            lbl_RerservarViaje = new Label();
            txt_Id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_NombreCliente = new TextBox();
            txt_Mail = new TextBox();
            txt_Direccion = new TextBox();
            label4 = new Label();
            txt_Rubro = new TextBox();
            groupBox1 = new GroupBox();
            pic_Rubro = new PictureBox();
            pic_Direccion = new PictureBox();
            pic_Mail = new PictureBox();
            pic_Persona = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Id).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Rubro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Direccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Mail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(69, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 30);
            label6.TabIndex = 68;
            label6.Text = "MI PERFIL";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Location = new Point(0, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 403);
            panel3.TabIndex = 70;
            // 
            // pic_Id
            // 
            pic_Id.Image = Properties.Resources.ID;
            pic_Id.Location = new Point(22, 47);
            pic_Id.Name = "pic_Id";
            pic_Id.Size = new Size(57, 36);
            pic_Id.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Id.TabIndex = 90;
            pic_Id.TabStop = false;
            // 
            // lbl_RerservarViaje
            // 
            lbl_RerservarViaje.AutoSize = true;
            lbl_RerservarViaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RerservarViaje.Location = new Point(85, 29);
            lbl_RerservarViaje.Name = "lbl_RerservarViaje";
            lbl_RerservarViaje.Size = new Size(31, 21);
            lbl_RerservarViaje.TabIndex = 92;
            lbl_RerservarViaje.Text = "ID ";
            // 
            // txt_Id
            // 
            txt_Id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Id.BackColor = Color.FromArgb(255, 255, 192);
            txt_Id.Enabled = false;
            txt_Id.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Id.Location = new Point(85, 58);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(175, 25);
            txt_Id.TabIndex = 94;
            txt_Id.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 224);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 95;
            label1.Text = "Direccion en BS AS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 97);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 96;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 160);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 97;
            label3.Text = "Mail ";
            // 
            // txt_NombreCliente
            // 
            txt_NombreCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_NombreCliente.BackColor = Color.FromArgb(255, 255, 192);
            txt_NombreCliente.Enabled = false;
            txt_NombreCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NombreCliente.Location = new Point(86, 121);
            txt_NombreCliente.Name = "txt_NombreCliente";
            txt_NombreCliente.ReadOnly = true;
            txt_NombreCliente.Size = new Size(175, 25);
            txt_NombreCliente.TabIndex = 98;
            txt_NombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Mail
            // 
            txt_Mail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Mail.BackColor = Color.FromArgb(255, 255, 192);
            txt_Mail.Enabled = false;
            txt_Mail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Mail.Location = new Point(85, 184);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.ReadOnly = true;
            txt_Mail.Size = new Size(175, 25);
            txt_Mail.TabIndex = 99;
            txt_Mail.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Direccion.BackColor = Color.FromArgb(255, 255, 192);
            txt_Direccion.Enabled = false;
            txt_Direccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.Location = new Point(85, 248);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.ReadOnly = true;
            txt_Direccion.Size = new Size(175, 25);
            txt_Direccion.TabIndex = 100;
            txt_Direccion.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 290);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 101;
            label4.Text = "Rubro";
            // 
            // txt_Rubro
            // 
            txt_Rubro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Rubro.BackColor = Color.FromArgb(255, 255, 192);
            txt_Rubro.Enabled = false;
            txt_Rubro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Rubro.Location = new Point(86, 314);
            txt_Rubro.Name = "txt_Rubro";
            txt_Rubro.ReadOnly = true;
            txt_Rubro.Size = new Size(175, 25);
            txt_Rubro.TabIndex = 102;
            txt_Rubro.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pic_Rubro);
            groupBox1.Controls.Add(pic_Direccion);
            groupBox1.Controls.Add(pic_Mail);
            groupBox1.Controls.Add(pic_Persona);
            groupBox1.Controls.Add(txt_Direccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Rubro);
            groupBox1.Controls.Add(txt_Mail);
            groupBox1.Controls.Add(txt_NombreCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Id);
            groupBox1.Controls.Add(lbl_RerservarViaje);
            groupBox1.Controls.Add(pic_Id);
            groupBox1.Location = new Point(226, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 357);
            groupBox1.TabIndex = 103;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la cuenta";
            // 
            // pic_Rubro
            // 
            pic_Rubro.Image = Properties.Resources.fabrica;
            pic_Rubro.Location = new Point(23, 303);
            pic_Rubro.Name = "pic_Rubro";
            pic_Rubro.Size = new Size(57, 36);
            pic_Rubro.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Rubro.TabIndex = 106;
            pic_Rubro.TabStop = false;
            // 
            // pic_Direccion
            // 
            pic_Direccion.Image = Properties.Resources.direccion;
            pic_Direccion.Location = new Point(22, 237);
            pic_Direccion.Name = "pic_Direccion";
            pic_Direccion.Size = new Size(57, 36);
            pic_Direccion.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Direccion.TabIndex = 105;
            pic_Direccion.TabStop = false;
            // 
            // pic_Mail
            // 
            pic_Mail.Image = Properties.Resources.mail;
            pic_Mail.Location = new Point(23, 173);
            pic_Mail.Name = "pic_Mail";
            pic_Mail.Size = new Size(57, 36);
            pic_Mail.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Mail.TabIndex = 104;
            pic_Mail.TabStop = false;
            // 
            // pic_Persona
            // 
            pic_Persona.Image = Properties.Resources.persona;
            pic_Persona.Location = new Point(23, 110);
            pic_Persona.Name = "pic_Persona";
            pic_Persona.Size = new Size(57, 36);
            pic_Persona.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Persona.TabIndex = 103;
            pic_Persona.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.volver;
            pictureBox1.Location = new Point(611, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(611, 358);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 105;
            label7.Text = "Volver";
            // 
            // FrmDatosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(704, 430);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDatosCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDatosCliente";
            Load += FrmDatosCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Id).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Rubro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Direccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Mail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Panel panel1;
        protected Label lbl_NombreCliente;
        protected PictureBox pictureBox2;
        protected Label label5;
        private Panel panel2;
        protected Label label6;
        private Panel panel3;
        private PictureBox pic_Id;
        protected Label lbl_RerservarViaje;
        private TextBox txt_Id;
        protected Label label1;
        protected Label label2;
        protected Label label3;
        private TextBox txt_NombreCliente;
        private TextBox txt_Mail;
        private TextBox txt_Direccion;
        protected Label label4;
        private TextBox txt_Rubro;
        private GroupBox groupBox1;
        private PictureBox pic_Rubro;
        private PictureBox pic_Direccion;
        private PictureBox pic_Mail;
        private PictureBox pic_Persona;
        private PictureBox pictureBox1;
        protected Label label7;
    }
}