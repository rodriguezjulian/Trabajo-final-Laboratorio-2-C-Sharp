namespace WF_TransporteRodriguez
{
    partial class FrmListarViajesCliente
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
            grp_ListarViajesCliente = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grp_ListarViajesCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(676, 336);
            dataGridView1.TabIndex = 0;
            // 
            // grp_ListarViajesCliente
            // 
            grp_ListarViajesCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grp_ListarViajesCliente.Controls.Add(dataGridView1);
            grp_ListarViajesCliente.Location = new Point(0, 0);
            grp_ListarViajesCliente.Name = "grp_ListarViajesCliente";
            grp_ListarViajesCliente.Size = new Size(720, 469);
            grp_ListarViajesCliente.TabIndex = 1;
            grp_ListarViajesCliente.TabStop = false;
            // 
            // FrmListarViajesCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 469);
            Controls.Add(grp_ListarViajesCliente);
            Name = "FrmListarViajesCliente";
            Text = "FrmListarViajesCliente";
            Load += FrmListarViajesCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grp_ListarViajesCliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grp_ListarViajesCliente;
    }
}