namespace WF_TransporteRodriguez
{
    partial class Frm_Empleados_Lista_Vehiculos
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
            pnl_Izquierdo = new Panel();
            lbl_Volver = new Label();
            pic_Volver = new PictureBox();
            pnl_Superior = new Panel();
            lbl_nombreUsuario = new Label();
            pic_IconoPersona = new PictureBox();
            lbl_TransporteRodriguez = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(110, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(528, 265);
            dataGridView2.TabIndex = 9;
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 192, 128);
            pnl_Izquierdo.Controls.Add(lbl_Volver);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 304);
            pnl_Izquierdo.TabIndex = 10;
            // 
            // lbl_Volver
            // 
            lbl_Volver.AutoSize = true;
            lbl_Volver.Location = new Point(26, 233);
            lbl_Volver.Name = "lbl_Volver";
            lbl_Volver.Size = new Size(39, 15);
            lbl_Volver.TabIndex = 2;
            lbl_Volver.Text = "Volver";
            // 
            // pic_Volver
            // 
            pic_Volver.Image = Properties.Resources.volver;
            pic_Volver.Location = new Point(26, 192);
            pic_Volver.Name = "pic_Volver";
            pic_Volver.Size = new Size(55, 38);
            pic_Volver.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Volver.TabIndex = 1;
            pic_Volver.TabStop = false;
            pic_Volver.Click += pic_Volver_Click;
            // 
            // pnl_Superior
            // 
            pnl_Superior.BackColor = Color.FromArgb(255, 255, 192);
            pnl_Superior.Controls.Add(lbl_nombreUsuario);
            pnl_Superior.Controls.Add(pic_IconoPersona);
            pnl_Superior.Controls.Add(lbl_TransporteRodriguez);
            pnl_Superior.Location = new Point(110, 0);
            pnl_Superior.Name = "pnl_Superior";
            pnl_Superior.Size = new Size(528, 40);
            pnl_Superior.TabIndex = 11;
            // 
            // lbl_nombreUsuario
            // 
            lbl_nombreUsuario.AutoSize = true;
            lbl_nombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombreUsuario.Location = new Point(370, 14);
            lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            lbl_nombreUsuario.Size = new Size(64, 20);
            lbl_nombreUsuario.TabIndex = 60;
            lbl_nombreUsuario.Text = "Nombre";
            // 
            // pic_IconoPersona
            // 
            pic_IconoPersona.Image = Properties.Resources.persona;
            pic_IconoPersona.Location = new Point(320, 2);
            pic_IconoPersona.Name = "pic_IconoPersona";
            pic_IconoPersona.Size = new Size(44, 35);
            pic_IconoPersona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_IconoPersona.TabIndex = 59;
            pic_IconoPersona.TabStop = false;
            // 
            // lbl_TransporteRodriguez
            // 
            lbl_TransporteRodriguez.AutoSize = true;
            lbl_TransporteRodriguez.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TransporteRodriguez.Location = new Point(0, 4);
            lbl_TransporteRodriguez.Name = "lbl_TransporteRodriguez";
            lbl_TransporteRodriguez.Size = new Size(314, 32);
            lbl_TransporteRodriguez.TabIndex = 31;
            lbl_TransporteRodriguez.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // FrmListarVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 302);
            Controls.Add(pnl_Superior);
            Controls.Add(pnl_Izquierdo);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListarVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListarVehiculos";
            Load += FrmListarVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            pnl_Izquierdo.ResumeLayout(false);
            pnl_Izquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_Superior.ResumeLayout(false);
            pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IconoPersona).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private Panel pnl_Izquierdo;
        private Label lbl_Volver;
        private PictureBox pic_Volver;
        private Panel pnl_Superior;
        private Label lbl_TransporteRodriguez;
        private PictureBox pic_IconoPersona;
        private Label lbl_nombreUsuario;
    }
}