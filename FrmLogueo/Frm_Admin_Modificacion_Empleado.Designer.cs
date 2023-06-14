namespace WF_TransporteRodriguez
{
    partial class Frm_Admin_Modificacion_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Modificacion_Empleado));
            dtg_ListarEmpleados = new DataGridView();
            grp_DatosNuevoCliente = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cbo_Mail = new ComboBox();
            btn_Todos = new Button();
            btn_DeBaja = new Button();
            btn_Activos = new Button();
            label4 = new Label();
            txt_ID = new TextBox();
            pictureBox9 = new PictureBox();
            lbl_Puesto = new Label();
            cbo_Puesto = new ComboBox();
            txt_ModNombre = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            txt_ModMail = new TextBox();
            pictureBox5 = new PictureBox();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarEmpleados).BeginInit();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.Location = new Point(87, 33);
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
            lbl_Opcion.Size = new Size(249, 30);
            lbl_Opcion.Text = "MODIFICAR EMPLEADO";
            // 
            // panel1
            // 
            panel1.Controls.Add(grp_DatosNuevoCliente);
            panel1.Controls.Add(dtg_ListarEmpleados);
            panel1.Controls.SetChildIndex(panel2, 0);
            panel1.Controls.SetChildIndex(pnl_PanelSup, 0);
            panel1.Controls.SetChildIndex(dtg_ListarEmpleados, 0);
            panel1.Controls.SetChildIndex(grp_DatosNuevoCliente, 0);
            // 
            // dtg_ListarEmpleados
            // 
            dtg_ListarEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListarEmpleados.BackgroundColor = Color.White;
            dtg_ListarEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarEmpleados.Location = new Point(94, 239);
            dtg_ListarEmpleados.Name = "dtg_ListarEmpleados";
            dtg_ListarEmpleados.ReadOnly = true;
            dtg_ListarEmpleados.RowTemplate.Height = 25;
            dtg_ListarEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListarEmpleados.Size = new Size(623, 251);
            dtg_ListarEmpleados.TabIndex = 71;
            dtg_ListarEmpleados.CellClick += dtg_ListarEmpleados_CellClick;
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 255, 192);
            grp_DatosNuevoCliente.Controls.Add(label2);
            grp_DatosNuevoCliente.Controls.Add(pictureBox1);
            grp_DatosNuevoCliente.Controls.Add(cbo_Mail);
            grp_DatosNuevoCliente.Controls.Add(btn_Todos);
            grp_DatosNuevoCliente.Controls.Add(btn_DeBaja);
            grp_DatosNuevoCliente.Controls.Add(btn_Activos);
            grp_DatosNuevoCliente.Controls.Add(label4);
            grp_DatosNuevoCliente.Controls.Add(txt_ID);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(lbl_Puesto);
            grp_DatosNuevoCliente.Controls.Add(cbo_Puesto);
            grp_DatosNuevoCliente.Controls.Add(txt_ModNombre);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(txt_ModMail);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(94, 79);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(623, 154);
            grp_DatosNuevoCliente.TabIndex = 72;
            grp_DatosNuevoCliente.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 81;
            label2.Text = "Mail, sin \"@\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 80;
            pictureBox1.TabStop = false;
            // 
            // cbo_Mail
            // 
            cbo_Mail.FormattingEnabled = true;
            cbo_Mail.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com", "@transporterodriguez.com" });
            cbo_Mail.Location = new Point(61, 122);
            cbo_Mail.Name = "cbo_Mail";
            cbo_Mail.Size = new Size(247, 23);
            cbo_Mail.TabIndex = 79;
            cbo_Mail.KeyPress += cbo_Mail_KeyPress;
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.FromArgb(192, 255, 255);
            btn_Todos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Todos.Location = new Point(321, 79);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(98, 36);
            btn_Todos.TabIndex = 78;
            btn_Todos.Text = "TODOS";
            btn_Todos.UseVisualStyleBackColor = false;
            btn_Todos.Click += btn_Todos_Click;
            // 
            // btn_DeBaja
            // 
            btn_DeBaja.BackColor = Color.FromArgb(255, 192, 192);
            btn_DeBaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DeBaja.Location = new Point(525, 80);
            btn_DeBaja.Name = "btn_DeBaja";
            btn_DeBaja.Size = new Size(98, 36);
            btn_DeBaja.TabIndex = 77;
            btn_DeBaja.Text = "INACTIVOS";
            btn_DeBaja.UseVisualStyleBackColor = false;
            btn_DeBaja.Click += btn_DeBaja_Click;
            // 
            // btn_Activos
            // 
            btn_Activos.BackColor = Color.FromArgb(192, 255, 192);
            btn_Activos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Activos.Location = new Point(424, 80);
            btn_Activos.Name = "btn_Activos";
            btn_Activos.Size = new Size(98, 36);
            btn_Activos.TabIndex = 76;
            btn_Activos.Text = "ACTIVOS";
            btn_Activos.UseVisualStyleBackColor = false;
            btn_Activos.Click += btn_Activos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 19);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 56;
            label4.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.BackColor = Color.FromArgb(224, 224, 224);
            txt_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ID.Location = new Point(258, 38);
            txt_ID.Name = "txt_ID";
            txt_ID.ReadOnly = true;
            txt_ID.Size = new Size(51, 25);
            txt_ID.TabIndex = 55;
            txt_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(315, 28);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // lbl_Puesto
            // 
            lbl_Puesto.AutoSize = true;
            lbl_Puesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Puesto.Location = new Point(369, 20);
            lbl_Puesto.Name = "lbl_Puesto";
            lbl_Puesto.Size = new Size(50, 17);
            lbl_Puesto.TabIndex = 54;
            lbl_Puesto.Text = "Puesto";
            // 
            // cbo_Puesto
            // 
            cbo_Puesto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_Puesto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_Puesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Puesto.FormattingEnabled = true;
            cbo_Puesto.Items.AddRange(new object[] { "sss" });
            cbo_Puesto.Location = new Point(365, 40);
            cbo_Puesto.Name = "cbo_Puesto";
            cbo_Puesto.Size = new Size(249, 23);
            cbo_Puesto.TabIndex = 53;
            cbo_Puesto.KeyPress += cbo_Puesto_KeyPress;
            // 
            // txt_ModNombre
            // 
            txt_ModNombre.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModNombre.Location = new Point(62, 38);
            txt_ModNombre.Name = "txt_ModNombre";
            txt_ModNombre.Size = new Size(180, 25);
            txt_ModNombre.TabIndex = 42;
            txt_ModNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.persona;
            pictureBox3.Location = new Point(12, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // txt_ModMail
            // 
            txt_ModMail.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModMail.Location = new Point(62, 91);
            txt_ModMail.Name = "txt_ModMail";
            txt_ModMail.Size = new Size(247, 25);
            txt_ModMail.TabIndex = 48;
            txt_ModMail.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 81);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // Frm_Admin_Modificacion_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Name = "Frm_Admin_Modificacion_Empleado";
            Text = "Frm_Admin_Modificacion_Empleado";
            Load += Frm_Admin_Modificacion_Empleado_Load;
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_ListarEmpleados).EndInit();
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_ListarEmpleados;
        private GroupBox grp_DatosNuevoCliente;
        private Label label4;
        private TextBox txt_ID;
        private PictureBox pictureBox9;
        private Label lbl_Puesto;
        private ComboBox cbo_Puesto;
        private TextBox txt_ModNombre;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox txt_ModMail;
        private PictureBox pictureBox5;
        private Button btn_Activos;
        private Button btn_DeBaja;
        private Button btn_Todos;
        private ComboBox cbo_Mail;
        private PictureBox pictureBox1;
        private Label label2;
    }
}