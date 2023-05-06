namespace FrmLogueo
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            pic_CamionLogin = new PictureBox();
            lbl_Bienvenido = new Label();
            txt_LoginUsuario = new TextBox();
            txt_Contraseña = new TextBox();
            label2 = new Label();
            btn_Ingresar = new Button();
            colorDialog1 = new ColorDialog();
            pnl_TransporteRodriguez = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_cerrar = new PictureBox();
            btn_HardCodearEmpleado = new Button();
            btn_HardCodearCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_CamionLogin).BeginInit();
            pnl_TransporteRodriguez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            SuspendLayout();
            // 
            // pic_CamionLogin
            // 
            pic_CamionLogin.Image = WF_TransporteRodriguez.Properties.Resources.camioncito2;
            pic_CamionLogin.Location = new Point(435, 33);
            pic_CamionLogin.Name = "pic_CamionLogin";
            pic_CamionLogin.Size = new Size(367, 233);
            pic_CamionLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_CamionLogin.TabIndex = 1;
            pic_CamionLogin.TabStop = false;
            // 
            // lbl_Bienvenido
            // 
            lbl_Bienvenido.AutoSize = true;
            lbl_Bienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Bienvenido.Location = new Point(140, 50);
            lbl_Bienvenido.Name = "lbl_Bienvenido";
            lbl_Bienvenido.Size = new Size(161, 32);
            lbl_Bienvenido.TabIndex = 2;
            lbl_Bienvenido.Text = "BIENVENIDO";
            // 
            // txt_LoginUsuario
            // 
            txt_LoginUsuario.BackColor = Color.FromArgb(255, 255, 192);
            txt_LoginUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_LoginUsuario.Location = new Point(108, 107);
            txt_LoginUsuario.Name = "txt_LoginUsuario";
            txt_LoginUsuario.Size = new Size(202, 29);
            txt_LoginUsuario.TabIndex = 9;
            txt_LoginUsuario.Text = "Usuario";
            txt_LoginUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.BackColor = Color.FromArgb(255, 255, 192);
            txt_Contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contraseña.Location = new Point(108, 160);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(202, 29);
            txt_Contraseña.TabIndex = 10;
            txt_Contraseña.TextAlign = HorizontalAlignment.Center;
            txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 243);
            label2.Name = "label2";
            label2.Size = new Size(396, 15);
            label2.TabIndex = 13;
            label2.Text = "Si aun no es cliente, puede comunicarse a info@transporteRodriguez.com";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.PeachPuff;
            btn_Ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ingresar.Location = new Point(158, 210);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(109, 30);
            btn_Ingresar.TabIndex = 23;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // pnl_TransporteRodriguez
            // 
            pnl_TransporteRodriguez.BackColor = Color.FromArgb(255, 255, 192);
            pnl_TransporteRodriguez.Controls.Add(pictureBox1);
            pnl_TransporteRodriguez.Controls.Add(label1);
            pnl_TransporteRodriguez.Controls.Add(btn_cerrar);
            pnl_TransporteRodriguez.Location = new Point(0, 0);
            pnl_TransporteRodriguez.Name = "pnl_TransporteRodriguez";
            pnl_TransporteRodriguez.Size = new Size(802, 33);
            pnl_TransporteRodriguez.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WF_TransporteRodriguez.Properties.Resources.animacionCamion;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 1);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 28;
            label1.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = WF_TransporteRodriguez.Properties.Resources.delete;
            btn_cerrar.Location = new Point(774, 5);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(25, 25);
            btn_cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_cerrar.TabIndex = 28;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_HardCodearEmpleado
            // 
            btn_HardCodearEmpleado.Location = new Point(12, 107);
            btn_HardCodearEmpleado.Name = "btn_HardCodearEmpleado";
            btn_HardCodearEmpleado.Size = new Size(75, 23);
            btn_HardCodearEmpleado.TabIndex = 28;
            btn_HardCodearEmpleado.Text = "Empleado";
            btn_HardCodearEmpleado.UseVisualStyleBackColor = true;
            btn_HardCodearEmpleado.Click += btn_HardCodearEmpleado_Click;
            // 
            // btn_HardCodearCliente
            // 
            btn_HardCodearCliente.Location = new Point(344, 111);
            btn_HardCodearCliente.Name = "btn_HardCodearCliente";
            btn_HardCodearCliente.Size = new Size(75, 23);
            btn_HardCodearCliente.TabIndex = 29;
            btn_HardCodearCliente.Text = "Cliente";
            btn_HardCodearCliente.UseVisualStyleBackColor = true;
            btn_HardCodearCliente.Click += btn_HardCodearCliente_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 267);
            Controls.Add(btn_HardCodearCliente);
            Controls.Add(btn_HardCodearEmpleado);
            Controls.Add(pnl_TransporteRodriguez);
            Controls.Add(btn_Ingresar);
            Controls.Add(label2);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_LoginUsuario);
            Controls.Add(lbl_Bienvenido);
            Controls.Add(pic_CamionLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Frm_Login_FormClosing;
            Load += Frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CamionLogin).EndInit();
            pnl_TransporteRodriguez.ResumeLayout(false);
            pnl_TransporteRodriguez.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_CamionLogin;
        private Label lbl_Bienvenido;
        private TextBox txt_LoginUsuario;
        private TextBox txt_Contraseña;
        private Label label2;
        private Button btn_Ingresar;
        private ColorDialog colorDialog1;
        private Panel pnl_TransporteRodriguez;
        private PictureBox btn_cerrar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_HardCodearEmpleado;
        private Button btn_HardCodearCliente;
    }
}