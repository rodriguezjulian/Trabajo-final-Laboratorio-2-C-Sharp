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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtg_ListaViajes = new DataGridView();
            grp_ListarViajesCliente = new GroupBox();
            btn_Cancelados = new Button();
            btn_ViajesTodos = new Button();
            btn_ViajesPendientes = new Button();
            btn_ViajesRealizados = new Button();
            pic_Atras = new PictureBox();
            panel2 = new Panel();
            lbl_Listar = new Label();
            panel1 = new Panel();
            lbl_NombreCliente = new Label();
            pic_Persona = new PictureBox();
            lbl_TransporteRodriguez = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).BeginInit();
            grp_ListarViajesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Atras).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            SuspendLayout();
            // 
            // dtg_ListaViajes
            // 
            dtg_ListaViajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_ListaViajes.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_ListaViajes.EnableHeadersVisualStyles = false;
            dtg_ListaViajes.GridColor = Color.FromArgb(255, 224, 192);
            dtg_ListaViajes.Location = new Point(3, 114);
            dtg_ListaViajes.Name = "dtg_ListaViajes";
            dtg_ListaViajes.ReadOnly = true;
            dtg_ListaViajes.RowHeadersVisible = false;
            dtg_ListaViajes.RowTemplate.Height = 25;
            dtg_ListaViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListaViajes.Size = new Size(717, 343);
            dtg_ListaViajes.TabIndex = 0;
            // 
            // grp_ListarViajesCliente
            // 
            grp_ListarViajesCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grp_ListarViajesCliente.Controls.Add(btn_Cancelados);
            grp_ListarViajesCliente.Controls.Add(btn_ViajesTodos);
            grp_ListarViajesCliente.Controls.Add(btn_ViajesPendientes);
            grp_ListarViajesCliente.Controls.Add(btn_ViajesRealizados);
            grp_ListarViajesCliente.Controls.Add(pic_Atras);
            grp_ListarViajesCliente.Controls.Add(panel2);
            grp_ListarViajesCliente.Controls.Add(panel1);
            grp_ListarViajesCliente.Controls.Add(dtg_ListaViajes);
            grp_ListarViajesCliente.Location = new Point(0, 0);
            grp_ListarViajesCliente.Name = "grp_ListarViajesCliente";
            grp_ListarViajesCliente.Size = new Size(738, 469);
            grp_ListarViajesCliente.TabIndex = 1;
            grp_ListarViajesCliente.TabStop = false;
            // 
            // btn_Cancelados
            // 
            btn_Cancelados.BackColor = Color.Red;
            btn_Cancelados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelados.Location = new Point(495, 85);
            btn_Cancelados.Name = "btn_Cancelados";
            btn_Cancelados.Size = new Size(93, 23);
            btn_Cancelados.TabIndex = 111;
            btn_Cancelados.Text = "CANCELADOS";
            btn_Cancelados.UseVisualStyleBackColor = false;
            btn_Cancelados.Click += btn_Cancelados_Click;
            // 
            // btn_ViajesTodos
            // 
            btn_ViajesTodos.BackColor = Color.FromArgb(192, 255, 255);
            btn_ViajesTodos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesTodos.Location = new Point(198, 85);
            btn_ViajesTodos.Name = "btn_ViajesTodos";
            btn_ViajesTodos.Size = new Size(93, 23);
            btn_ViajesTodos.TabIndex = 110;
            btn_ViajesTodos.Text = "TODOS";
            btn_ViajesTodos.UseVisualStyleBackColor = false;
            btn_ViajesTodos.Click += btn_ViajesTodos_Click;
            // 
            // btn_ViajesPendientes
            // 
            btn_ViajesPendientes.BackColor = Color.FromArgb(255, 192, 192);
            btn_ViajesPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesPendientes.Location = new Point(396, 85);
            btn_ViajesPendientes.Name = "btn_ViajesPendientes";
            btn_ViajesPendientes.Size = new Size(93, 23);
            btn_ViajesPendientes.TabIndex = 109;
            btn_ViajesPendientes.Text = "PENDIENTES";
            btn_ViajesPendientes.UseVisualStyleBackColor = false;
            btn_ViajesPendientes.Click += btn_ViajesPendientes_Click;
            // 
            // btn_ViajesRealizados
            // 
            btn_ViajesRealizados.BackColor = Color.FromArgb(192, 255, 192);
            btn_ViajesRealizados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViajesRealizados.Location = new Point(297, 85);
            btn_ViajesRealizados.Name = "btn_ViajesRealizados";
            btn_ViajesRealizados.Size = new Size(93, 23);
            btn_ViajesRealizados.TabIndex = 108;
            btn_ViajesRealizados.Text = "REALIZADOS";
            btn_ViajesRealizados.UseVisualStyleBackColor = false;
            btn_ViajesRealizados.Click += btn_ViajesRealizados_Click;
            // 
            // pic_Atras
            // 
            pic_Atras.Image = Properties.Resources.volver;
            pic_Atras.Location = new Point(603, 63);
            pic_Atras.Name = "pic_Atras";
            pic_Atras.Size = new Size(59, 50);
            pic_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Atras.TabIndex = 107;
            pic_Atras.TabStop = false;
            pic_Atras.Click += pic_Atras_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(lbl_Listar);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 40);
            panel2.TabIndex = 69;
            // 
            // lbl_Listar
            // 
            lbl_Listar.AutoSize = true;
            lbl_Listar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Listar.Location = new Point(0, 5);
            lbl_Listar.Name = "lbl_Listar";
            lbl_Listar.Size = new Size(158, 30);
            lbl_Listar.TabIndex = 68;
            lbl_Listar.Text = "LISTAR VIAJES";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(lbl_NombreCliente);
            panel1.Controls.Add(pic_Persona);
            panel1.Controls.Add(lbl_TransporteRodriguez);
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
            // pic_Persona
            // 
            pic_Persona.Image = Properties.Resources.persona;
            pic_Persona.Location = new Point(376, 3);
            pic_Persona.Name = "pic_Persona";
            pic_Persona.Size = new Size(34, 27);
            pic_Persona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Persona.TabIndex = 34;
            pic_Persona.TabStop = false;
            // 
            // lbl_TransporteRodriguez
            // 
            lbl_TransporteRodriguez.AutoSize = true;
            lbl_TransporteRodriguez.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TransporteRodriguez.Location = new Point(3, 0);
            lbl_TransporteRodriguez.Name = "lbl_TransporteRodriguez";
            lbl_TransporteRodriguez.Size = new Size(275, 30);
            lbl_TransporteRodriguez.TabIndex = 30;
            lbl_TransporteRodriguez.Text = "TRANSPORTE RODRIGUEZ";
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
            ((System.ComponentModel.ISupportInitialize)dtg_ListaViajes).EndInit();
            grp_ListarViajesCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Atras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_ListaViajes;
        private GroupBox grp_ListarViajesCliente;
        protected Panel panel1;
        protected Label lbl_NombreCliente;
        protected PictureBox pic_Persona;
        protected Label lbl_TransporteRodriguez;
        private Panel panel2;
        protected Label lbl_Listar;
        private PictureBox pic_Atras;
        private Button btn_ViajesPendientes;
        private Button btn_ViajesRealizados;
        private Button btn_ViajesTodos;
        private Button btn_Cancelados;
    }
}