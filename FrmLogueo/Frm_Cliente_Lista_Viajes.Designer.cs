namespace WF_TransporteRodriguez
{
    partial class Frm_Cliente_Lista_Viajes
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
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            lbl_NombreCliente = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grp_ListarViajesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(717, 343);
            dataGridView1.TabIndex = 0;
            // 
            // grp_ListarViajesCliente
            // 
            grp_ListarViajesCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grp_ListarViajesCliente.Controls.Add(label7);
            grp_ListarViajesCliente.Controls.Add(pictureBox1);
            grp_ListarViajesCliente.Controls.Add(panel2);
            grp_ListarViajesCliente.Controls.Add(panel1);
            grp_ListarViajesCliente.Controls.Add(dataGridView1);
            grp_ListarViajesCliente.Location = new Point(0, 0);
            grp_ListarViajesCliente.Name = "grp_ListarViajesCliente";
            grp_ListarViajesCliente.Size = new Size(738, 469);
            grp_ListarViajesCliente.TabIndex = 1;
            grp_ListarViajesCliente.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(603, 39);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 106;
            label7.Text = "Volver";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.volver;
            pictureBox1.Location = new Point(603, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 5);
            label6.Name = "label6";
            label6.Size = new Size(158, 30);
            label6.TabIndex = 68;
            label6.Text = "LISTAR VIAJES";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(lbl_NombreCliente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 33);
            panel1.TabIndex = 68;
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(416, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(192, 30);
            lbl_NombreCliente.TabIndex = 86;
            lbl_NombreCliente.Text = "NOMBRE CLIENTE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.persona;
            pictureBox2.Location = new Point(376, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 30);
            label5.TabIndex = 30;
            label5.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // Frm_Cliente_Lista_Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 469);
            Controls.Add(grp_ListarViajesCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cliente_Lista_Viajes";
            Text = "FrmListarViajesCliente";
            Load += FrmListarViajesCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grp_ListarViajesCliente.ResumeLayout(false);
            grp_ListarViajesCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grp_ListarViajesCliente;
        protected Panel panel1;
        protected Label lbl_NombreCliente;
        protected PictureBox pictureBox2;
        protected Label label5;
        private Panel panel2;
        protected Label label6;
        private PictureBox pictureBox1;
        protected Label label7;
    }
}