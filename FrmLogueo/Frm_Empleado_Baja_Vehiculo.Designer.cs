namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Baja_Vehiculo
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
            dtg_Listar = new DataGridView();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Listar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.Size = new Size(0, 15);
            lbl_Cancelar.Text = "";
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(173, 30);
            lbl_Opcion.Text = "BAJA VEHICULO";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtg_Listar);
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(dtg_Listar, 0);
            // 
            // dtg_Listar
            // 
            dtg_Listar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Listar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Listar.Location = new Point(95, 143);
            dtg_Listar.Name = "dtg_Listar";
            dtg_Listar.ReadOnly = true;
            dtg_Listar.RowTemplate.Height = 25;
            dtg_Listar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Listar.Size = new Size(603, 347);
            dtg_Listar.TabIndex = 71;
            // 
            // Frm_Empleado_Baja_Vehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Empleado_Baja_Vehiculo";
            Text = "Frm_Empleado_Baja_Vehiculo";
            Load += Frm_Empleado_Baja_Vehiculo_Load;
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Listar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Listar;
    }
}