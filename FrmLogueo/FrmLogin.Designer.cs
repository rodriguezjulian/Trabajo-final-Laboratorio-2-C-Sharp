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
            pic_CamionLogin = new PictureBox();
            lbl_Bienvenido = new Label();
            txt_LoginUsuario = new TextBox();
            txt_Contraseña = new TextBox();
            rad_Empleado = new RadioButton();
            rad_Cliente = new RadioButton();
            label2 = new Label();
            btn_Ingresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_CamionLogin).BeginInit();
            SuspendLayout();
            // 
            // pic_CamionLogin
            // 
            pic_CamionLogin.Image = WF_TransporteRodriguez.Properties.Resources.camioncito2;
            pic_CamionLogin.Location = new Point(433, -1);
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
            lbl_Bienvenido.Location = new Point(133, 6);
            lbl_Bienvenido.Name = "lbl_Bienvenido";
            lbl_Bienvenido.Size = new Size(161, 32);
            lbl_Bienvenido.TabIndex = 2;
            lbl_Bienvenido.Text = "BIENVENIDO";
            // 
            // txt_LoginUsuario
            // 
            txt_LoginUsuario.BackColor = Color.FromArgb(255, 255, 192);
            txt_LoginUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_LoginUsuario.Location = new Point(109, 71);
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
            txt_Contraseña.Location = new Point(109, 121);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(202, 29);
            txt_Contraseña.TabIndex = 10;
            txt_Contraseña.Text = "Contraseña";
            txt_Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // rad_Empleado
            // 
            rad_Empleado.AutoSize = true;
            rad_Empleado.BackColor = Color.Transparent;
            rad_Empleado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rad_Empleado.Location = new Point(47, 41);
            rad_Empleado.Name = "rad_Empleado";
            rad_Empleado.Size = new Size(95, 24);
            rad_Empleado.TabIndex = 11;
            rad_Empleado.TabStop = true;
            rad_Empleado.Text = "Empleado";
            rad_Empleado.UseVisualStyleBackColor = false;
            // 
            // rad_Cliente
            // 
            rad_Cliente.AutoSize = true;
            rad_Cliente.BackColor = Color.Transparent;
            rad_Cliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rad_Cliente.Location = new Point(292, 41);
            rad_Cliente.Name = "rad_Cliente";
            rad_Cliente.Size = new Size(73, 24);
            rad_Cliente.TabIndex = 12;
            rad_Cliente.TabStop = true;
            rad_Cliente.Text = "Cliente";
            rad_Cliente.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 205);
            label2.Name = "label2";
            label2.Size = new Size(396, 15);
            label2.TabIndex = 13;
            label2.Text = "Si aun no es cliente, puede comunicarse a info@transporteRodriguez.com";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.PeachPuff;
            btn_Ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ingresar.Location = new Point(153, 156);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(109, 30);
            btn_Ingresar.TabIndex = 23;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 229);
            Controls.Add(btn_Ingresar);
            Controls.Add(label2);
            Controls.Add(rad_Cliente);
            Controls.Add(rad_Empleado);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_LoginUsuario);
            Controls.Add(lbl_Bienvenido);
            Controls.Add(pic_CamionLogin);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pic_CamionLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_CamionLogin;
        private Label lbl_Bienvenido;
        private TextBox txt_LoginUsuario;
        private TextBox txt_Contraseña;
        private RadioButton rad_Empleado;
        private RadioButton rad_Cliente;
        private Label label2;
        private Button btn_Ingresar;
    }
}