namespace WF_TransporteRodriguez
{
    partial class Frm_Admin_Menu
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
            pictureBox2 = new PictureBox();
            lbl_NombreUsuario = new Label();
            label1 = new Label();
            mnu_Admin = new MenuStrip();
            misDatosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            cuentasToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            moToolStripMenuItem = new ToolStripMenuItem();
            bajarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            crearVehiculoToolStripMenuItem = new ToolStripMenuItem();
            bajaVehiculoToolStripMenuItem = new ToolStripMenuItem();
            listarVehiculoToolStripMenuItem = new ToolStripMenuItem();
            turnosOcupadosToolStripMenuItem = new ToolStripMenuItem();
            informe = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mnu_Admin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_NombreUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(157, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 33);
            panel1.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.persona;
            pictureBox2.Location = new Point(448, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuario.Location = new Point(500, 11);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(64, 20);
            lbl_NombreUsuario.TabIndex = 32;
            lbl_NombreUsuario.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 29;
            label1.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // mnu_Admin
            // 
            mnu_Admin.BackColor = Color.FromArgb(255, 192, 128);
            mnu_Admin.Dock = DockStyle.Left;
            mnu_Admin.Items.AddRange(new ToolStripItem[] { misDatosToolStripMenuItem, empleadosToolStripMenuItem, clienteToolStripMenuItem, vehiculosToolStripMenuItem, turnosOcupadosToolStripMenuItem, informe, cerrarSesionToolStripMenuItem });
            mnu_Admin.Location = new Point(0, 0);
            mnu_Admin.Name = "mnu_Admin";
            mnu_Admin.Size = new Size(157, 505);
            mnu_Admin.TabIndex = 32;
            mnu_Admin.Text = "menuStrip2";
            // 
            // misDatosToolStripMenuItem
            // 
            misDatosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            misDatosToolStripMenuItem.Margin = new Padding(0, 30, 0, 30);
            misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            misDatosToolStripMenuItem.Size = new Size(144, 34);
            misDatosToolStripMenuItem.Text = "Mis datos";
            misDatosToolStripMenuItem.Click += misDatosToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem1, modificarToolStripMenuItem, bajaToolStripMenuItem, listarToolStripMenuItem1, cuentasToolStripMenuItem });
            empleadosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            empleadosToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(144, 34);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(181, 34);
            crearToolStripMenuItem1.Text = "Crear";
            crearToolStripMenuItem1.Click += crearToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(181, 34);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(181, 34);
            bajaToolStripMenuItem.Text = "Dar baja";
            bajaToolStripMenuItem.Click += bajaToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(181, 34);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // cuentasToolStripMenuItem
            // 
            cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            cuentasToolStripMenuItem.Size = new Size(181, 34);
            cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.AutoSize = false;
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, moToolStripMenuItem, bajarToolStripMenuItem, listarToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clienteToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(144, 34);
            clienteToolStripMenuItem.Text = "Clientes";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(181, 34);
            crearToolStripMenuItem.Text = "Crear ";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // moToolStripMenuItem
            // 
            moToolStripMenuItem.Name = "moToolStripMenuItem";
            moToolStripMenuItem.Size = new Size(181, 34);
            moToolStripMenuItem.Text = "Modificar";
            moToolStripMenuItem.Click += moToolStripMenuItem_Click;
            // 
            // bajarToolStripMenuItem
            // 
            bajarToolStripMenuItem.Name = "bajarToolStripMenuItem";
            bajarToolStripMenuItem.Size = new Size(181, 34);
            bajarToolStripMenuItem.Text = "Dar baja";
            bajarToolStripMenuItem.Click += bajarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(181, 34);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearVehiculoToolStripMenuItem, bajaVehiculoToolStripMenuItem, listarVehiculoToolStripMenuItem });
            vehiculosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            vehiculosToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(144, 34);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // crearVehiculoToolStripMenuItem
            // 
            crearVehiculoToolStripMenuItem.Name = "crearVehiculoToolStripMenuItem";
            crearVehiculoToolStripMenuItem.Size = new Size(173, 34);
            crearVehiculoToolStripMenuItem.Text = "Crear ";
            crearVehiculoToolStripMenuItem.Click += crearVehiculoToolStripMenuItem_Click;
            // 
            // bajaVehiculoToolStripMenuItem
            // 
            bajaVehiculoToolStripMenuItem.Name = "bajaVehiculoToolStripMenuItem";
            bajaVehiculoToolStripMenuItem.Size = new Size(173, 34);
            bajaVehiculoToolStripMenuItem.Text = "Dar baja ";
            bajaVehiculoToolStripMenuItem.Click += bajaVehiculoToolStripMenuItem_Click;
            // 
            // listarVehiculoToolStripMenuItem
            // 
            listarVehiculoToolStripMenuItem.Name = "listarVehiculoToolStripMenuItem";
            listarVehiculoToolStripMenuItem.Size = new Size(173, 34);
            listarVehiculoToolStripMenuItem.Text = "Listar";
            listarVehiculoToolStripMenuItem.Click += listarVehiculoToolStripMenuItem_Click;
            // 
            // turnosOcupadosToolStripMenuItem
            // 
            turnosOcupadosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            turnosOcupadosToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            turnosOcupadosToolStripMenuItem.Name = "turnosOcupadosToolStripMenuItem";
            turnosOcupadosToolStripMenuItem.Size = new Size(144, 34);
            turnosOcupadosToolStripMenuItem.Text = "Listar viajes ";
            turnosOcupadosToolStripMenuItem.Click += turnosOcupadosToolStripMenuItem_Click;
            // 
            // informe
            // 
            informe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            informe.Margin = new Padding(0, 0, 0, 100);
            informe.Name = "informe";
            informe.Size = new Size(144, 34);
            informe.Text = "Informe";
            informe.Click += informe_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(144, 34);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click_1;
            // 
            // Frm_Admin_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 505);
            Controls.Add(mnu_Admin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Frm_Admin_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Admin_Menu";
            Load += Frm_Admin_Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mnu_Admin.ResumeLayout(false);
            mnu_Admin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lbl_NombreUsuario;
        private Label label1;
        private MenuStrip mnu_Admin;
        private ToolStripMenuItem misDatosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem moToolStripMenuItem;
        private ToolStripMenuItem bajarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem crearVehiculoToolStripMenuItem;
        private ToolStripMenuItem bajaVehiculoToolStripMenuItem;
        private ToolStripMenuItem listarVehiculoToolStripMenuItem;
        private ToolStripMenuItem turnosOcupadosToolStripMenuItem;
        private ToolStripMenuItem informe;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem cuentasToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}