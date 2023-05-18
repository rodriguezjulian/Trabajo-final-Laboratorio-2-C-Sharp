namespace WF_TransporteRodriguez
{
    partial class Frm_Admin_Lista_Empleado
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
            panel1 = new Panel();
            dtg_ListarEmpleados = new DataGridView();
            btn_Todos = new Button();
            btn_Activos = new Button();
            btn_DeBaja = new Button();
            pnl_Izquierdo = new Panel();
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_Listar = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarEmpleados).BeginInit();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtg_ListarEmpleados);
            panel1.Controls.Add(btn_Todos);
            panel1.Controls.Add(btn_Activos);
            panel1.Controls.Add(btn_DeBaja);
            panel1.Controls.Add(pnl_Izquierdo);
            panel1.Controls.Add(pnl_PanelSup);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 469);
            panel1.TabIndex = 0;
            // 
            // dtg_ListarEmpleados
            // 
            dtg_ListarEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListarEmpleados.BackgroundColor = Color.White;
            dtg_ListarEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarEmpleados.Location = new Point(112, 88);
            dtg_ListarEmpleados.Name = "dtg_ListarEmpleados";
            dtg_ListarEmpleados.ReadOnly = true;
            dtg_ListarEmpleados.RowTemplate.Height = 25;
            dtg_ListarEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListarEmpleados.Size = new Size(595, 379);
            dtg_ListarEmpleados.TabIndex = 77;
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.FromArgb(192, 255, 255);
            btn_Todos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Todos.Location = new Point(401, 46);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(98, 36);
            btn_Todos.TabIndex = 76;
            btn_Todos.Text = "TODOS";
            btn_Todos.UseVisualStyleBackColor = false;
            btn_Todos.Click += btn_Todos_Click;
            // 
            // btn_Activos
            // 
            btn_Activos.BackColor = Color.FromArgb(192, 255, 192);
            btn_Activos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Activos.Location = new Point(505, 46);
            btn_Activos.Name = "btn_Activos";
            btn_Activos.Size = new Size(98, 36);
            btn_Activos.TabIndex = 75;
            btn_Activos.Text = "ACTIVOS";
            btn_Activos.UseVisualStyleBackColor = false;
            btn_Activos.Click += btn_Activos_Click;
            // 
            // btn_DeBaja
            // 
            btn_DeBaja.BackColor = Color.FromArgb(255, 192, 192);
            btn_DeBaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DeBaja.Location = new Point(609, 46);
            btn_DeBaja.Name = "btn_DeBaja";
            btn_DeBaja.Size = new Size(98, 36);
            btn_DeBaja.TabIndex = 74;
            btn_DeBaja.Text = "INACTIVOS";
            btn_DeBaja.UseVisualStyleBackColor = false;
            btn_DeBaja.Click += btn_DeBaja_Click;
            // 
            // pnl_Izquierdo
            // 
            pnl_Izquierdo.BackColor = Color.FromArgb(255, 128, 0);
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 73;
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
            pnl_PanelSup.Controls.Add(lbl_Listar);
            pnl_PanelSup.Location = new Point(107, 0);
            pnl_PanelSup.Name = "pnl_PanelSup";
            pnl_PanelSup.Size = new Size(315, 40);
            pnl_PanelSup.TabIndex = 72;
            // 
            // lbl_Listar
            // 
            lbl_Listar.AutoSize = true;
            lbl_Listar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Listar.Location = new Point(0, 6);
            lbl_Listar.Name = "lbl_Listar";
            lbl_Listar.Size = new Size(213, 30);
            lbl_Listar.TabIndex = 71;
            lbl_Listar.Text = "LISTAR EMPLEADOS";
            // 
            // Frm_Admin_Lista_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Admin_Lista_Empleado";
            Text = "Frm_Admin_Lista_Empleado";
            Load += Frm_Admin_Lista_Empleado_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_ListarEmpleados).EndInit();
            pnl_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnl_PanelSup;
        private Label lbl_Listar;
        private Panel pnl_Izquierdo;
        private PictureBox pic_Volver;
        private Button btn_DeBaja;
        private Button btn_Activos;
        private Button btn_Todos;
        private DataGridView dtg_ListarEmpleados;
    }
}