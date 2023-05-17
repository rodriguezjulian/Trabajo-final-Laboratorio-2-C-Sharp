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
            pic_Volver = new PictureBox();
            pnl_PanelSup = new Panel();
            lbl_Listar = new Label();
            dtg_ListarClientes = new DataGridView();
            btn_DeBaja = new Button();
            panel1 = new Panel();
            btn_Todos = new Button();
            btn_Activos = new Button();
            pnl_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Volver).BeginInit();
            pnl_PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).BeginInit();
            panel1.SuspendLayout();
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
            pnl_Izquierdo.Controls.Add(pic_Volver);
            pnl_Izquierdo.Location = new Point(0, 0);
            pnl_Izquierdo.Name = "pnl_Izquierdo";
            pnl_Izquierdo.Size = new Size(107, 468);
            pnl_Izquierdo.TabIndex = 11;
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
            dtg_ListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListarClientes.BackgroundColor = Color.White;
            dtg_ListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarClientes.Location = new Point(112, 88);
            dtg_ListarClientes.Name = "dtg_ListarClientes";
            dtg_ListarClientes.RowTemplate.Height = 25;
            dtg_ListarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListarClientes.Size = new Size(595, 379);
            dtg_ListarClientes.TabIndex = 72;
            // 
            // btn_DeBaja
            // 
            btn_DeBaja.BackColor = Color.FromArgb(255, 192, 192);
            btn_DeBaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DeBaja.Location = new Point(609, 46);
            btn_DeBaja.Name = "btn_DeBaja";
            btn_DeBaja.Size = new Size(98, 36);
            btn_DeBaja.TabIndex = 73;
            btn_DeBaja.Text = "INACTIVOS";
            btn_DeBaja.UseVisualStyleBackColor = false;
            btn_DeBaja.Click += btn_DeBaja_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.Controls.Add(btn_Todos);
            panel1.Controls.Add(btn_Activos);
            panel1.Controls.Add(pnl_PanelSup);
            panel1.Controls.Add(btn_DeBaja);
            panel1.Controls.Add(pnl_Izquierdo);
            panel1.Controls.Add(dtg_ListarClientes);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 469);
            panel1.TabIndex = 3;
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.FromArgb(192, 255, 255);
            btn_Todos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Todos.Location = new Point(401, 46);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(98, 36);
            btn_Todos.TabIndex = 75;
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
            btn_Activos.TabIndex = 74;
            btn_Activos.Text = "ACTIVOS";
            btn_Activos.UseVisualStyleBackColor = false;
            btn_Activos.Click += btn_Activos_Click;
            // 
            // Frm_Empleado_Listar_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Listar_Clientes";
            Text = "Frm_Empleado_Listar_Clientes";
            Load += Frm_Empleado_Listar_Clientes_Load;
            pnl_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Volver).EndInit();
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel pnl_Izquierdo;
        private PictureBox pic_Volver;
        private Panel pnl_PanelSup;
        private Label lbl_Listar;
        private DataGridView dtg_ListarClientes;
        private Button btn_DeBaja;
        private Panel panel1;
        private Button btn_Todos;
        private Button btn_Activos;
    }
}