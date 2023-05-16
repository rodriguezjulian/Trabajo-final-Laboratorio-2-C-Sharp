namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Baja_Vehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Baja_Vehiculo));
            dtg_Listar = new DataGridView();
            txt_BajaPatente = new TextBox();
            pic_Persona = new PictureBox();
            lbl_Patente = new Label();
            pic_ID = new PictureBox();
            txt_BajaID = new TextBox();
            lbl_Id = new Label();
            lbl_VehiculoBaja = new Label();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Listar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_ID).BeginInit();
            SuspendLayout();
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
            lbl_Cancelar.Size = new Size(0, 15);
            lbl_Cancelar.Text = "";
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(173, 30);
            lbl_Opcion.Text = "BAJA VEHICULO";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_VehiculoBaja);
            panel1.Controls.Add(lbl_Id);
            panel1.Controls.Add(txt_BajaID);
            panel1.Controls.Add(pic_ID);
            panel1.Controls.Add(lbl_Patente);
            panel1.Controls.Add(pic_Persona);
            panel1.Controls.Add(txt_BajaPatente);
            panel1.Controls.Add(dtg_Listar);
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(dtg_Listar, 0);
            panel1.Controls.SetChildIndex(txt_BajaPatente, 0);
            panel1.Controls.SetChildIndex(pic_Persona, 0);
            panel1.Controls.SetChildIndex(lbl_Patente, 0);
            panel1.Controls.SetChildIndex(pic_ID, 0);
            panel1.Controls.SetChildIndex(txt_BajaID, 0);
            panel1.Controls.SetChildIndex(lbl_Id, 0);
            panel1.Controls.SetChildIndex(lbl_VehiculoBaja, 0);
            // 
            // dtg_Listar
            // 
            dtg_Listar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Listar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Listar.Location = new Point(95, 215);
            dtg_Listar.Name = "dtg_Listar";
            dtg_Listar.ReadOnly = true;
            dtg_Listar.RowTemplate.Height = 25;
            dtg_Listar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Listar.Size = new Size(603, 275);
            dtg_Listar.TabIndex = 71;
            dtg_Listar.CellClick += dtg_Listar_CellClick;
            // 
            // txt_BajaPatente
            // 
            txt_BajaPatente.BackColor = Color.FromArgb(224, 224, 224);
            txt_BajaPatente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BajaPatente.Location = new Point(191, 166);
            txt_BajaPatente.Name = "txt_BajaPatente";
            txt_BajaPatente.ReadOnly = true;
            txt_BajaPatente.Size = new Size(180, 25);
            txt_BajaPatente.TabIndex = 76;
            txt_BajaPatente.TextAlign = HorizontalAlignment.Center;
            // 
            // pic_Persona
            // 
            pic_Persona.Image = (Image)resources.GetObject("pic_Persona.Image");
            pic_Persona.Location = new Point(141, 156);
            pic_Persona.Name = "pic_Persona";
            pic_Persona.Size = new Size(44, 35);
            pic_Persona.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Persona.TabIndex = 77;
            pic_Persona.TabStop = false;
            // 
            // lbl_Patente
            // 
            lbl_Patente.AutoSize = true;
            lbl_Patente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Patente.Location = new Point(191, 146);
            lbl_Patente.Name = "lbl_Patente";
            lbl_Patente.Size = new Size(55, 17);
            lbl_Patente.TabIndex = 78;
            lbl_Patente.Text = "Patente";
            // 
            // pic_ID
            // 
            pic_ID.Image = Properties.Resources.ID;
            pic_ID.Location = new Point(393, 156);
            pic_ID.Name = "pic_ID";
            pic_ID.Size = new Size(44, 35);
            pic_ID.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ID.TabIndex = 79;
            pic_ID.TabStop = false;
            // 
            // txt_BajaID
            // 
            txt_BajaID.BackColor = Color.FromArgb(224, 224, 224);
            txt_BajaID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BajaID.Location = new Point(443, 166);
            txt_BajaID.Name = "txt_BajaID";
            txt_BajaID.ReadOnly = true;
            txt_BajaID.Size = new Size(51, 25);
            txt_BajaID.TabIndex = 80;
            txt_BajaID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(443, 146);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(22, 17);
            lbl_Id.TabIndex = 81;
            lbl_Id.Text = "ID";
            // 
            // lbl_VehiculoBaja
            // 
            lbl_VehiculoBaja.AutoSize = true;
            lbl_VehiculoBaja.BackColor = Color.FromArgb(255, 192, 192);
            lbl_VehiculoBaja.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_VehiculoBaja.Location = new Point(106, 103);
            lbl_VehiculoBaja.Name = "lbl_VehiculoBaja";
            lbl_VehiculoBaja.Size = new Size(361, 25);
            lbl_VehiculoBaja.TabIndex = 82;
            lbl_VehiculoBaja.Text = "Vehiculo seleccionado para dar de baja:";
            // 
            // Frm_Empleado_Baja_Vehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Empleado_Baja_Vehiculo";
            Text = "Frm_Empleado_Baja_Vehiculo";
            Load += Frm_Empleado_Baja_Vehiculo_Load;
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Listar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Persona).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_ID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Listar;
        private TextBox txt_BajaPatente;
        private PictureBox pic_Persona;
        private Label lbl_Patente;
        private PictureBox pic_ID;
        private TextBox txt_BajaID;
        private Label lbl_Id;
        private Label lbl_VehiculoBaja;
    }
}