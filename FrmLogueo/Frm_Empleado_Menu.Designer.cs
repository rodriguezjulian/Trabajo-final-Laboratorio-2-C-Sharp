namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Menu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            misDatosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            moToolStripMenuItem = new ToolStripMenuItem();
            bajarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            cargarVehiculoToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            turnosOcupadosToolStripMenuItem = new ToolStripMenuItem();
            estadisticasToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_NombreUsuario = new Label();
            label1 = new Label();
            pnl_Padre = new Panel();
            tmr_Menu = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 128);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { misDatosToolStripMenuItem, clienteToolStripMenuItem, vehiculosToolStripMenuItem, turnosOcupadosToolStripMenuItem, estadisticasToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(157, 505);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // misDatosToolStripMenuItem
            // 
            misDatosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            misDatosToolStripMenuItem.Margin = new Padding(0, 30, 0, 0);
            misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            misDatosToolStripMenuItem.Size = new Size(144, 34);
            misDatosToolStripMenuItem.Text = "Mis datos";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.AutoSize = false;
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, moToolStripMenuItem, bajarToolStripMenuItem, listarToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clienteToolStripMenuItem.Margin = new Padding(0, 33, 0, 20);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 34);
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
            // 
            // bajarToolStripMenuItem
            // 
            bajarToolStripMenuItem.Name = "bajarToolStripMenuItem";
            bajarToolStripMenuItem.Size = new Size(181, 34);
            bajarToolStripMenuItem.Text = "Bajar";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(181, 34);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarVehiculoToolStripMenuItem, modificarToolStripMenuItem, bajaToolStripMenuItem, listarToolStripMenuItem1 });
            vehiculosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            vehiculosToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(144, 34);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // cargarVehiculoToolStripMenuItem
            // 
            cargarVehiculoToolStripMenuItem.Name = "cargarVehiculoToolStripMenuItem";
            cargarVehiculoToolStripMenuItem.Size = new Size(187, 34);
            cargarVehiculoToolStripMenuItem.Text = "Cargar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(187, 34);
            modificarToolStripMenuItem.Text = "Modificar ";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(187, 34);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(187, 34);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // turnosOcupadosToolStripMenuItem
            // 
            turnosOcupadosToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            turnosOcupadosToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            turnosOcupadosToolStripMenuItem.Name = "turnosOcupadosToolStripMenuItem";
            turnosOcupadosToolStripMenuItem.Size = new Size(144, 34);
            turnosOcupadosToolStripMenuItem.Text = "Listar viajes ";
            // 
            // estadisticasToolStripMenuItem
            // 
            estadisticasToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estadisticasToolStripMenuItem.Margin = new Padding(0, 0, 0, 120);
            estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            estadisticasToolStripMenuItem.Size = new Size(144, 34);
            estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(144, 34);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_NombreUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(158, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 33);
            panel1.TabIndex = 30;
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
            // pnl_Padre
            // 
            pnl_Padre.Location = new Point(158, 35);
            pnl_Padre.Name = "pnl_Padre";
            pnl_Padre.Size = new Size(720, 468);
            pnl_Padre.TabIndex = 32;
            // 
            // tmr_Menu
            // 
            tmr_Menu.Enabled = true;
            // 
            // Frm_Empleado_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 505);
            Controls.Add(pnl_Padre);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Empleado_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMenuEmpleado_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem moToolStripMenuItem;
        private ToolStripMenuItem bajarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem cargarVehiculoToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem turnosOcupadosToolStripMenuItem;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label label1;
        private Label lbl_NombreUsuario;
        private PictureBox pictureBox2;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_Menu;
        private ToolStripMenuItem misDatosToolStripMenuItem;
        public static Panel pnl_Padre;
    }
}