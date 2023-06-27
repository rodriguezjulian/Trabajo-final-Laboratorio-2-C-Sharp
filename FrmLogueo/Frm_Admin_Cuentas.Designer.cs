namespace WF_TransporteRodriguez
{
    partial class Frm_Admin_Cuentas
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
            pnl_Izquierdo = new Panel();
            pic_Volver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(467, 282);
            dataGridView1.TabIndex = 0;
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 74;
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
            // Frm_Admin_Cuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            ControlBox = false;
            Controls.Add(pnl_Izquierdo);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Admin_Cuentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Admin_Cuentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnl_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnl_Izquierdo;
        private PictureBox pic_Volver;
    }
}