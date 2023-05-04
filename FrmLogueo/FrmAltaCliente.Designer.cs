namespace WF_TransporteRodriguez
{
    partial class FrmAltaCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_AltaNombre = new TextBox();
            txt_AltaDireccion = new TextBox();
            txt_AltaContraseña = new TextBox();
            txt_AltaRubro = new TextBox();
            btn_SalirAltaCliente = new Button();
            btn_GuardarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 67);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 110);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 159);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 216);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Rubro ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 391);
            label5.Name = "label5";
            label5.Size = new Size(657, 15);
            label5.TabIndex = 4;
            label5.Text = "RUBRO NO SERA OBLIGATORIO - EL ID SE CALCULARA AUTOMATICAMENTE - VER DE CREAR UNA CONTRASEÑA RANDOM";
            // 
            // txt_AltaNombre
            // 
            txt_AltaNombre.Location = new Point(245, 59);
            txt_AltaNombre.Name = "txt_AltaNombre";
            txt_AltaNombre.Size = new Size(100, 23);
            txt_AltaNombre.TabIndex = 5;
            // 
            // txt_AltaDireccion
            // 
            txt_AltaDireccion.Location = new Point(245, 140);
            txt_AltaDireccion.Name = "txt_AltaDireccion";
            txt_AltaDireccion.Size = new Size(100, 23);
            txt_AltaDireccion.TabIndex = 6;
            // 
            // txt_AltaContraseña
            // 
            txt_AltaContraseña.Location = new Point(245, 102);
            txt_AltaContraseña.Name = "txt_AltaContraseña";
            txt_AltaContraseña.Size = new Size(100, 23);
            txt_AltaContraseña.TabIndex = 7;
            // 
            // txt_AltaRubro
            // 
            txt_AltaRubro.Location = new Point(245, 208);
            txt_AltaRubro.Name = "txt_AltaRubro";
            txt_AltaRubro.Size = new Size(100, 23);
            txt_AltaRubro.TabIndex = 8;
            // 
            // btn_SalirAltaCliente
            // 
            btn_SalirAltaCliente.BackColor = Color.IndianRed;
            btn_SalirAltaCliente.Location = new Point(470, 289);
            btn_SalirAltaCliente.Name = "btn_SalirAltaCliente";
            btn_SalirAltaCliente.Size = new Size(75, 23);
            btn_SalirAltaCliente.TabIndex = 33;
            btn_SalirAltaCliente.Text = "Salir";
            btn_SalirAltaCliente.UseVisualStyleBackColor = false;
            btn_SalirAltaCliente.Click += btn_SalirAltaCliente_Click;
            // 
            // btn_GuardarCliente
            // 
            btn_GuardarCliente.BackColor = Color.FromArgb(192, 255, 192);
            btn_GuardarCliente.Location = new Point(258, 289);
            btn_GuardarCliente.Name = "btn_GuardarCliente";
            btn_GuardarCliente.Size = new Size(75, 23);
            btn_GuardarCliente.TabIndex = 34;
            btn_GuardarCliente.Text = "Guardar";
            btn_GuardarCliente.UseVisualStyleBackColor = false;
            btn_GuardarCliente.Click += btn_GuardarCliente_Click;
            // 
            // FrmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_GuardarCliente);
            Controls.Add(btn_SalirAltaCliente);
            Controls.Add(txt_AltaRubro);
            Controls.Add(txt_AltaContraseña);
            Controls.Add(txt_AltaDireccion);
            Controls.Add(txt_AltaNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_AltaNombre;
        private TextBox txt_AltaDireccion;
        private TextBox txt_AltaContraseña;
        private TextBox txt_AltaRubro;
        private Button btn_SalirAltaCliente;
        private Button btn_GuardarCliente;
    }
}