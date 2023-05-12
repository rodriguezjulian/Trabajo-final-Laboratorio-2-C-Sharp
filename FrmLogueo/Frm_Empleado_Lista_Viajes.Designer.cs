namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Lista_Viajes
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
            pnl_Izquierdo = new Panel();
            lbl_Volver = new Label();
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_ListarViajes = new Label();
            btn_ViajesRealizados = new Button();
            dtg_ListaViajes = new DataGridView();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).BeginInit();
            SuspendLayout();
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(lbl_Volver);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 12;
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
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.BackColor = Color.FromArgb(255, 128, 0);
            pnl_PanelSup.Controls.Add(lbl_ListarViajes);
            pnl_PanelSup.Location = new Point(107, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 72;
            // 
            // lbl_ListarViajes
            // 
            lbl_ListarViajes.AutoSize = true;
            lbl_ListarViajes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ListarViajes.Location = new Point(0, 6);
            lbl_ListarViajes.Name = "lbl_ListarViajes";
            lbl_ListarViajes.Size = new Size(158, 30);
            lbl_ListarViajes.TabIndex = 71;
            lbl_ListarViajes.Text = "LISTAR VIAJES";
            // 
            // btn_ViajesRealizados
            // 
            btn_ViajesRealizados.BackColor = Color.FromArgb(255, 192, 192);
            btn_ViajesRealizados.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesRealizados.Location = new Point(446, 4);
            btn_ViajesRealizados.Name = "btn_ViajesRealizados";
            btn_ViajesRealizados.Size = new Size(242, 36);
            btn_ViajesRealizados.TabIndex = 74;
            btn_ViajesRealizados.Text = "Viajes realizados";
            btn_ViajesRealizados.UseVisualStyleBackColor = false;
            // 
            // dtg_ListaViajes
            // 
            dtg_ListaViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListaViajes.Location = new Point(113, 58);
            dtg_ListaViajes.Name = "dtg_ListaViajes";
            dtg_ListaViajes.RowTemplate.Height = 25;
            dtg_ListaViajes.Size = new Size(607, 410);
            dtg_ListaViajes.TabIndex = 75;
            // 
            // Frm_Empleado_Lista_Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(dtg_ListaViajes);
            Controls.Add(btn_ViajesRealizados);
            Controls.Add(pnl_PanelSup);
            Controls.Add(pnl_Izquierdo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Lista_Viajes";
            Text = "Frm_Empleado_Lista_Viajes";
            pnl_Izquierdo.ResumeLayout(false);
            pnl_Izquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Izquierdo;
        private Label lbl_Volver;
        private PictureBox pic_Volver;
        private Panel pnl_PanelSup;
        private Label lbl_ListarViajes;
        private Button btn_ViajesRealizados;
        private DataGridView dtg_ListaViajes;
    }
}