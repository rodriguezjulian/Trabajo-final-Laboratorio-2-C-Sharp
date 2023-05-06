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
            dataGridView1 = new DataGridView();
            IdVehiculo = new DataGridViewTextBoxColumn();
            MarcaVehiculo = new DataGridViewTextBoxColumn();
            CapacidadVehiculo = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            PatenteVehiculo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_NombreUsuarioCliente
            // 
            lbl_NombreUsuarioCliente.Location = new Point(359, 9);
            // 
            // btn_CerrarSesion
            // 
            btn_CerrarSesion.Location = new Point(494, 229);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdVehiculo, MarcaVehiculo, CapacidadVehiculo, Color, PatenteVehiculo });
            dataGridView1.Location = new Point(24, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(548, 150);
            dataGridView1.TabIndex = 8;
            // 
            // IdVehiculo
            // 
            IdVehiculo.HeaderText = "ID";
            IdVehiculo.Name = "IdVehiculo";
            // 
            // MarcaVehiculo
            // 
            MarcaVehiculo.HeaderText = "Marca";
            MarcaVehiculo.Name = "MarcaVehiculo";
            // 
            // CapacidadVehiculo
            // 
            CapacidadVehiculo.HeaderText = "Capacidad";
            CapacidadVehiculo.Name = "CapacidadVehiculo";
            // 
            // Color
            // 
            Color.HeaderText = "Color";
            Color.Name = "Color";
            // 
            // PatenteVehiculo
            // 
            PatenteVehiculo.HeaderText = "Patente";
            PatenteVehiculo.Name = "PatenteVehiculo";
            // 
            // FrmListarVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 302);
            Controls.Add(dataGridView1);
            Name = "FrmListarVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListarVehiculos";
            Load += FrmListarVehiculos_Load;
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btn_CerrarSesion, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdVehiculo;
        private DataGridViewTextBoxColumn MarcaVehiculo;
        private DataGridViewTextBoxColumn CapacidadVehiculo;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn PatenteVehiculo;
    }
}