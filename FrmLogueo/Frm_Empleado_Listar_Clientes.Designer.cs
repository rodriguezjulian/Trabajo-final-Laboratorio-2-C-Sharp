namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Listar_Clientes
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            pnl_Izquierdo = new Panel();
            lbl_Volver = new Label();
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_Listar = new Label();
            dtg_ListarClientes = new DataGridView();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdVehiculo";
            dataGridViewTextBoxColumn1.HeaderText = "IdVehiculo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "MarcaVehiculo";
            dataGridViewTextBoxColumn2.HeaderText = "MarcaVehiculo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CapacidadDeCarga";
            dataGridViewTextBoxColumn3.HeaderText = "CapacidadDeCarga";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Color";
            dataGridViewTextBoxColumn4.HeaderText = "Color";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Patente";
            dataGridViewTextBoxColumn5.HeaderText = "Patente";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 72;
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(lbl_Volver);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 11;
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
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.BackColor = Color.FromArgb(255, 128, 0);
            pnl_PanelSup.Controls.Add(lbl_Listar);
            pnl_PanelSup.Location = new Point(107, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 71;
            // 
            // lbl_Listar
            // 
            lbl_Listar.AutoSize = true;
            lbl_Listar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Listar.Location = new Point(0, 6);
            lbl_Listar.Name = "lbl_Listar";
            lbl_Listar.Size = new Size(176, 30);
            lbl_Listar.TabIndex = 71;
            lbl_Listar.Text = "LISTAR CLENTES";
            // 
            // dtg_ListarClientes
            // 
            dtg_ListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_ListarClientes.BackgroundColor = Color.White;
            dtg_ListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarClientes.Location = new Point(107, 46);
            dtg_ListarClientes.Name = "dtg_ListarClientes";
            dtg_ListarClientes.RowTemplate.Height = 25;
            dtg_ListarClientes.Size = new Size(614, 418);
            dtg_ListarClientes.TabIndex = 72;
            // 
            // Frm_Empleado_Listar_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(dtg_ListarClientes);
            Controls.Add(pnl_PanelSup);
            Controls.Add(pnl_Izquierdo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Listar_Clientes";
            Text = "Frm_Empleado_Listar_Clientes";
            pnl_Izquierdo.ResumeLayout(false);
            pnl_Izquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel pnl_Izquierdo;
        private Label lbl_Volver;
        private PictureBox pic_Volver;
        private Panel pnl_PanelSup;
        private Label lbl_Listar;
        private DataGridView dtg_ListarClientes;
    }
}