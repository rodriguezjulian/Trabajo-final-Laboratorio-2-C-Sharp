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
            dtg_ListarVehiculos = new DataGridView();
            pnl_Izquierdo = new Panel();
            lbl_Volver = new Label();
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_ListarVehiculos = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarVehiculos).BeginInit();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_ListarVehiculos
            // 
            dtg_ListarVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_ListarVehiculos.BackgroundColor = Color.White;
            dtg_ListarVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarVehiculos.Location = new Point(107, 39);
            dtg_ListarVehiculos.Name = "dtg_ListarVehiculos";
            dtg_ListarVehiculos.RowTemplate.Height = 25;
            dtg_ListarVehiculos.Size = new Size(614, 418);
            dtg_ListarVehiculos.TabIndex = 9;
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(lbl_Volver);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 10;
            // 
            // lbl_Volver
            // 
            lbl_Volver.AutoSize = true;
            lbl_Volver.Location = new Point(12, 233);
            lbl_Volver.Name = "lbl_Volver";
            lbl_Volver.Size = new Size(87, 15);
            lbl_Volver.TabIndex = 2;
            lbl_Volver.Text = "Menu principal";
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
            // pnl_PanelSup
            // 
            pnl_PanelSup.BackColor = Color.FromArgb(255, 128, 0);
            pnl_PanelSup.Controls.Add(lbl_ListarVehiculos);
            pnl_PanelSup.Location = new Point(107, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 70;
            // 
            // lbl_ListarVehiculos
            // 
            lbl_ListarVehiculos.AutoSize = true;
            lbl_ListarVehiculos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ListarVehiculos.Location = new Point(0, 6);
            lbl_ListarVehiculos.Name = "lbl_ListarVehiculos";
            lbl_ListarVehiculos.Size = new Size(203, 30);
            lbl_ListarVehiculos.TabIndex = 71;
            lbl_ListarVehiculos.Text = "LISTAR VEHICULOS";
            // 
            // Frm_Empleados_Lista_Vehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(pnl_PanelSup);
            Controls.Add(pnl_Izquierdo);
            Controls.Add(dtg_ListarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleados_Lista_Vehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListarVehiculos";
            Load += FrmListarVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_ListarVehiculos).EndInit();
            pnl_Izquierdo.ResumeLayout(false);
            pnl_Izquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtg_ListarVehiculos;
        private Panel pnl_Izquierdo;
        private Label lbl_Volver;
        private PictureBox pic_Volver;
        private Panel pnl_PanelSup;
        private Label lbl_ListarVehiculos;
    }
}