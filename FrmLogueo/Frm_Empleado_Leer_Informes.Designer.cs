namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Leer_Informes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtg_ListaViajes = new DataGridView();
            btn_AbrirInforme = new Button();
            pic_Volver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            SuspendLayout();
            // 
            // dtg_ListaViajes
            // 
            dtg_ListaViajes.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_ListaViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_ListaViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_ListaViajes.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_ListaViajes.EnableHeadersVisualStyles = false;
            dtg_ListaViajes.GridColor = Color.FromArgb(255, 224, 192);
            dtg_ListaViajes.Location = new Point(59, 104);
            dtg_ListaViajes.Name = "dtg_ListaViajes";
            dtg_ListaViajes.ReadOnly = true;
            dtg_ListaViajes.RowHeadersVisible = false;
            dtg_ListaViajes.RowTemplate.Height = 25;
            dtg_ListaViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListaViajes.Size = new Size(606, 322);
            dtg_ListaViajes.TabIndex = 83;
            // 
            // btn_AbrirInforme
            // 
            btn_AbrirInforme.BackColor = Color.FromArgb(255, 224, 192);
            btn_AbrirInforme.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AbrirInforme.Location = new Point(244, 65);
            btn_AbrirInforme.Name = "btn_AbrirInforme";
            btn_AbrirInforme.Size = new Size(237, 33);
            btn_AbrirInforme.TabIndex = 84;
            btn_AbrirInforme.Text = "ABRIR INFORME";
            btn_AbrirInforme.UseVisualStyleBackColor = false;
            btn_AbrirInforme.Click += btn_AbrirInforme_Click;
            // 
            // pic_Volver
            // 
            pic_Volver.Image = Properties.Resources.volver;
            pic_Volver.Location = new Point(642, 450);
            pic_Volver.Name = "pic_Volver";
            pic_Volver.Size = new Size(55, 38);
            pic_Volver.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Volver.TabIndex = 85;
            pic_Volver.TabStop = false;
            pic_Volver.Click += pic_Volver_Click;
            // 
            // Frm_Empleado_Leer_Informes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(718, 500);
            ControlBox = false;
            Controls.Add(pic_Volver);
            Controls.Add(btn_AbrirInforme);
            Controls.Add(dtg_ListaViajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Leer_Informes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Empleado_Leer_Informes";
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_ListaViajes;
        private Button btn_AbrirInforme;
        private PictureBox pic_Volver;
    }
}