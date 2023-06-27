namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Baja_Cliente
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
            dtg_ListarClientes = new DataGridView();
            lbl_ClienteBaja = new Label();
            lbl_Nombe = new Label();
            pic_Persona = new PictureBox();
            txt_BajaNombre = new TextBox();
            txt_BajaID = new TextBox();
            lbl_ID = new Label();
            pic_ID = new PictureBox();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_ID).BeginInit();
            SuspendLayout();
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.Location = new Point(88, 33);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            // 
            // pic_Guardar
            // 
            pic_Guardar.Click += pic_Guardar_Click;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Click += pic_Cancelar_Click;
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cancelar.Location = new Point(-2, 324);
            lbl_Cancelar.Size = new Size(0, 13);
            lbl_Cancelar.Text = "";
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(153, 30);
            lbl_Opcion.Text = "BAJA CLIENTE";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_ClienteBaja);
            panel1.Controls.Add(lbl_ID);
            panel1.Controls.Add(pic_ID);
            panel1.Controls.Add(txt_BajaID);
            panel1.Controls.Add(dtg_ListarClientes);
            panel1.Controls.Add(lbl_Nombe);
            panel1.Controls.Add(pic_Persona);
            panel1.Controls.Add(txt_BajaNombre);
            panel1.Controls.SetChildIndex(txt_BajaNombre, 0);
            panel1.Controls.SetChildIndex(pic_Persona, 0);
            panel1.Controls.SetChildIndex(lbl_Nombe, 0);
            panel1.Controls.SetChildIndex(dtg_ListarClientes, 0);
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(txt_BajaID, 0);
            panel1.Controls.SetChildIndex(pic_ID, 0);
            panel1.Controls.SetChildIndex(lbl_ID, 0);
            panel1.Controls.SetChildIndex(lbl_ClienteBaja, 0);
            // 
            // dtg_ListarClientes
            // 
            dtg_ListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListarClientes.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_ListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_ListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_ListarClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_ListarClientes.EnableHeadersVisualStyles = false;
            dtg_ListarClientes.GridColor = Color.FromArgb(255, 224, 192);
            dtg_ListarClientes.Location = new Point(89, 198);
            dtg_ListarClientes.Name = "dtg_ListarClientes";
            dtg_ListarClientes.ReadOnly = true;
            dtg_ListarClientes.RowHeadersVisible = false;
            dtg_ListarClientes.RowTemplate.Height = 25;
            dtg_ListarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListarClientes.Size = new Size(623, 292);
            dtg_ListarClientes.TabIndex = 71;
            dtg_ListarClientes.CellClick += dtg_ListarClientes_CellClick;
            // 
            // lbl_ClienteBaja
            // 
            lbl_ClienteBaja.AutoSize = true;
            lbl_ClienteBaja.BackColor = Color.FromArgb(255, 192, 192);
            lbl_ClienteBaja.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ClienteBaja.Location = new Point(89, 89);
            lbl_ClienteBaja.Name = "lbl_ClienteBaja";
            lbl_ClienteBaja.Size = new Size(346, 25);
            lbl_ClienteBaja.TabIndex = 72;
            lbl_ClienteBaja.Text = "Cliente seleccionado para dar de baja:";
            // 
            // lbl_Nombe
            // 
            lbl_Nombe.AutoSize = true;
            lbl_Nombe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombe.Location = new Point(95, 114);
            lbl_Nombe.Name = "lbl_Nombe";
            lbl_Nombe.Size = new Size(58, 17);
            lbl_Nombe.TabIndex = 73;
            lbl_Nombe.Text = "Nombre";
            // 
            // pic_Persona
            // 
            pic_Persona.Image = Properties.Resources.persona;
            pic_Persona.Location = new Point(105, 135);
            pic_Persona.Name = "pic_Persona";
            pic_Persona.Size = new Size(44, 35);
            pic_Persona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Persona.TabIndex = 74;
            pic_Persona.TabStop = false;
            // 
            // txt_BajaNombre
            // 
            txt_BajaNombre.BackColor = Color.FromArgb(224, 224, 224);
            txt_BajaNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BajaNombre.Location = new Point(155, 145);
            txt_BajaNombre.Name = "txt_BajaNombre";
            txt_BajaNombre.ReadOnly = true;
            txt_BajaNombre.Size = new Size(180, 25);
            txt_BajaNombre.TabIndex = 75;
            txt_BajaNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_BajaID
            // 
            txt_BajaID.BackColor = Color.FromArgb(255, 255, 192);
            txt_BajaID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BajaID.Location = new Point(408, 145);
            txt_BajaID.Name = "txt_BajaID";
            txt_BajaID.Size = new Size(51, 25);
            txt_BajaID.TabIndex = 76;
            txt_BajaID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ID.Location = new Point(408, 125);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(22, 17);
            lbl_ID.TabIndex = 77;
            lbl_ID.Text = "ID";
            // 
            // pic_ID
            // 
            pic_ID.Image = Properties.Resources.ID;
            pic_ID.Location = new Point(358, 135);
            pic_ID.Name = "pic_ID";
            pic_ID.Size = new Size(44, 35);
            pic_ID.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ID.TabIndex = 78;
            pic_ID.TabStop = false;
            // 
            // Frm_Empleado_Baja_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Empleado_Baja_Cliente";
            Text = "Frm_Empleado_Baja_Cliente";
            Load += Frm_Empleado_Baja_Cliente_Load;
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_ID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_ListarClientes;
        private Label lbl_ClienteBaja;
        private Label lbl_Nombe;
        private PictureBox pic_Persona;
        private TextBox txt_BajaNombre;
        private TextBox txt_BajaID;
        private Label lbl_ID;
        private PictureBox pic_ID;
    }
}