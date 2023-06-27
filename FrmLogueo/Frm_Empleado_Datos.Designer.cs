namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Datos));
            panel3 = new Panel();
            pic_Volver = new PictureBox();
            groupBox1 = new GroupBox();
            pic_Cargo = new PictureBox();
            pic_Mail = new PictureBox();
            pic_Persona = new PictureBox();
            txt_Cargo = new TextBox();
            txt_Mail = new TextBox();
            txt_NombreCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Id = new TextBox();
            lbl_RerservarViaje = new Label();
            pic_Id = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Cargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Mail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(pic_Volver);
            panel3.Location = new Point(0, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 468);
            panel3.TabIndex = 71;
            // 
            // pic_Volver
            // 
            pic_Volver.Image = (Image)resources.GetObject("pic_Volver.Image");
            pic_Volver.Location = new Point(9, 218);
            pic_Volver.Name = "pic_Volver";
            pic_Volver.Size = new Size(57, 36);
            pic_Volver.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Volver.TabIndex = 106;
            pic_Volver.TabStop = false;
            pic_Volver.Click += pic_Volver_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(pic_Cargo);
            groupBox1.Controls.Add(pic_Mail);
            groupBox1.Controls.Add(pic_Persona);
            groupBox1.Controls.Add(txt_Cargo);
            groupBox1.Controls.Add(txt_Mail);
            groupBox1.Controls.Add(txt_NombreCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Id);
            groupBox1.Controls.Add(lbl_RerservarViaje);
            groupBox1.Controls.Add(pic_Id);
            groupBox1.Location = new Point(206, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 339);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la cuenta";
            // 
            // pic_Cargo
            // 
            pic_Cargo.Image = (Image)resources.GetObject("pic_Cargo.Image");
            pic_Cargo.Location = new Point(23, 237);
            pic_Cargo.Name = "pic_Cargo";
            pic_Cargo.Size = new Size(57, 36);
            pic_Cargo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Cargo.TabIndex = 105;
            pic_Cargo.TabStop = false;
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
            // txt_Cargo
            // 
            txt_Cargo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Cargo.BackColor = Color.FromArgb(255, 255, 192);
            txt_Cargo.Enabled = false;
            txt_Cargo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Cargo.Location = new Point(85, 248);
            txt_Cargo.Name = "txt_Cargo";
            txt_Cargo.ReadOnly = true;
            txt_Cargo.Size = new Size(241, 25);
            txt_Cargo.TabIndex = 100;
            txt_Cargo.TextAlign = HorizontalAlignment.Center;
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
            txt_Mail.Size = new Size(241, 25);
            txt_Mail.TabIndex = 99;
            txt_Mail.TextAlign = HorizontalAlignment.Center;
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
            txt_NombreCliente.Size = new Size(240, 25);
            txt_NombreCliente.TabIndex = 98;
            txt_NombreCliente.TextAlign = HorizontalAlignment.Center;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 224);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 95;
            label1.Text = "Cargo";
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
            txt_Id.Size = new Size(241, 25);
            txt_Id.TabIndex = 94;
            txt_Id.TextAlign = HorizontalAlignment.Center;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(69, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 105;
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
            // Frm_Empleado_Datos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(720, 502);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Datos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Empleado_Datos";
            Load += Frm_Empleado_Datos_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Cargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Mail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Id).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private GroupBox groupBox1;
        private PictureBox pic_Mail;
        private PictureBox pic_Persona;
        private TextBox txt_Mail;
        private TextBox txt_NombreCliente;
        private Label label3;
        private Label label2;
        private TextBox txt_Id;
        private Label lbl_RerservarViaje;
        private PictureBox pic_Id;
        private Panel panel2;
        private Label label6;
        private PictureBox pic_Cargo;
        private TextBox txt_Cargo;
        private Label label1;
        private PictureBox pic_Volver;
    }
}