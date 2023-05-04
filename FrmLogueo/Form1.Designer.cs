namespace FrmLogueo
{
    partial class Form1
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txt_LoginUsuario = new TextBox();
            textBox1 = new TextBox();
            rad_Empleado = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.camioncito2;
            pictureBox2.Location = new Point(433, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(367, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 6);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // txt_LoginUsuario
            // 
            txt_LoginUsuario.BackColor = Color.FromArgb(255, 255, 192);
            txt_LoginUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_LoginUsuario.Location = new Point(109, 86);
            txt_LoginUsuario.Name = "txt_LoginUsuario";
            txt_LoginUsuario.Size = new Size(202, 29);
            txt_LoginUsuario.TabIndex = 9;
            txt_LoginUsuario.Text = "Usuario";
            txt_LoginUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(109, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 29);
            textBox1.TabIndex = 10;
            textBox1.Text = "Contraseña";
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(292, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cliente";
            radioButton1.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 229);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(rad_Empleado);
            Controls.Add(textBox1);
            Controls.Add(txt_LoginUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txt_LoginUsuario;
        private TextBox textBox1;
        private RadioButton rad_Empleado;
        private RadioButton radioButton1;
        private Label label2;
    }
}