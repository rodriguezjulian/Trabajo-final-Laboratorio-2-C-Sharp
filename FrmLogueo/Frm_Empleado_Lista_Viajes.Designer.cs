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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnl_Izquierdo = new Panel();
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_ListarViajes = new Label();
            dtg_ListaViajes = new DataGridView();
            gpb_ListarViajes = new GroupBox();
            btn_ViajesCancelados = new Button();
            btn_Todos = new Button();
            btn_ViajesRealizados = new Button();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).BeginInit();
            gpb_ListarViajes.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 12;
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
            lbl_ListarViajes.Location = new Point(3, 4);
            lbl_ListarViajes.Name = "lbl_ListarViajes";
            lbl_ListarViajes.Size = new Size(158, 30);
            lbl_ListarViajes.TabIndex = 71;
            lbl_ListarViajes.Text = "LISTAR VIAJES";
            // 
            // dtg_ListaViajes
            // 
            dtg_ListaViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dtg_ListaViajes.Location = new Point(107, 64);
            dtg_ListaViajes.Name = "dtg_ListaViajes";
            dtg_ListaViajes.ReadOnly = true;
            dtg_ListaViajes.RowHeadersVisible = false;
            dtg_ListaViajes.RowTemplate.Height = 25;
            dtg_ListaViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListaViajes.Size = new Size(613, 404);
            dtg_ListaViajes.TabIndex = 75;
            // 
            // gpb_ListarViajes
            // 
            gpb_ListarViajes.Controls.Add(btn_ViajesCancelados);
            gpb_ListarViajes.Controls.Add(btn_Todos);
            gpb_ListarViajes.Controls.Add(btn_ViajesRealizados);
            gpb_ListarViajes.Controls.Add(dtg_ListaViajes);
            gpb_ListarViajes.Controls.Add(pnl_PanelSup);
            gpb_ListarViajes.Controls.Add(pnl_Izquierdo);
            gpb_ListarViajes.Dock = DockStyle.Bottom;
            gpb_ListarViajes.Location = new Point(0, 0);
            gpb_ListarViajes.Name = "gpb_ListarViajes";
            gpb_ListarViajes.Size = new Size(720, 469);
            gpb_ListarViajes.TabIndex = 76;
            gpb_ListarViajes.TabStop = false;
            // 
            // btn_ViajesCancelados
            // 
            btn_ViajesCancelados.BackColor = Color.FromArgb(255, 192, 192);
            btn_ViajesCancelados.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesCancelados.Location = new Point(608, 22);
            btn_ViajesCancelados.Name = "btn_ViajesCancelados";
            btn_ViajesCancelados.Size = new Size(111, 36);
            btn_ViajesCancelados.TabIndex = 78;
            btn_ViajesCancelados.Text = "CANCELADOS";
            btn_ViajesCancelados.UseVisualStyleBackColor = false;
            btn_ViajesCancelados.Click += btn_ViajesCancelados_Click;
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.FromArgb(192, 255, 255);
            btn_Todos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Todos.Location = new Point(424, 22);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(76, 36);
            btn_Todos.TabIndex = 77;
            btn_Todos.Text = "TODOS";
            btn_Todos.UseVisualStyleBackColor = false;
            btn_Todos.Click += btn_Todos_Click;
            // 
            // btn_ViajesRealizados
            // 
            btn_ViajesRealizados.BackColor = Color.FromArgb(192, 255, 192);
            btn_ViajesRealizados.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesRealizados.Location = new Point(501, 22);
            btn_ViajesRealizados.Name = "btn_ViajesRealizados";
            btn_ViajesRealizados.Size = new Size(102, 36);
            btn_ViajesRealizados.TabIndex = 76;
            btn_ViajesRealizados.Text = "REALIZADOS";
            btn_ViajesRealizados.UseVisualStyleBackColor = false;
            btn_ViajesRealizados.Click += btn_ViajesRealizados_Click;
            // 
            // Frm_Empleado_Lista_Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(gpb_ListarViajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Lista_Viajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Empleado_Lista_Viajes";
            Load += Frm_Empleado_Lista_Viajes_Load;
            pnl_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).EndInit();
            gpb_ListarViajes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Izquierdo;
        private PictureBox pic_Volver;
        private Panel pnl_PanelSup;
        private Label lbl_ListarViajes;
        private DataGridView dtg_ListaViajes;
        private GroupBox gpb_ListarViajes;
        private Button btn_ViajesRealizados;
        private Button btn_Todos;
        private Button btn_ViajesCancelados;
    }
}