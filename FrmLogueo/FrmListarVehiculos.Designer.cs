namespace WF_TransporteRodriguez
{
    partial class FrmListarVehiculos
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
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(110, 0);
            panel1.Size = new Size(528, 33);
            // 
            // lbl_NombreUsuarioCliente
            // 
            lbl_NombreUsuarioCliente.Location = new Point(359, 9);
            // 
            // btn_CerrarSesion
            // 
            btn_CerrarSesion.Location = new Point(341, 149);
            btn_CerrarSesion.Text = "Volver ";
            btn_CerrarSesion.Click += btn_CerrarSesion_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(110, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(528, 219);
            dataGridView2.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 293);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(32, 77);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmListarVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 302);
            Controls.Add(panel2);
            Controls.Add(dataGridView2);
            Name = "FrmListarVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListarVehiculos";
            Load += FrmListarVehiculos_Load;
            Controls.SetChildIndex(dataGridView2, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btn_CerrarSesion, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private Panel panel2;
        private Button button1;
    }
}