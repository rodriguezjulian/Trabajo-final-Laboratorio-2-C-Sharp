namespace WF_TransporteRodriguez
{
    partial class FrmMenuEmpleado
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btn_CerrarSesion = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_NombreUsuario = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 128);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, vehiculosToolStripMenuItem, turnosOcupadosToolStripMenuItem, estadisticasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(150, 302);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            vehiculosToolStripMenuItem.Size = new Size(137, 34);
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
            turnosOcupadosToolStripMenuItem.Size = new Size(137, 34);
            turnosOcupadosToolStripMenuItem.Text = "Listar viajes ";
            // 
            // estadisticasToolStripMenuItem
            // 
            estadisticasToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estadisticasToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            estadisticasToolStripMenuItem.Size = new Size(137, 34);
            estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.animacionCamion;
            pictureBox1.Location = new Point(193, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(683, 278);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 4;
            button1.Text = "Cerrar sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_CerrarSesion
            // 
            btn_CerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
            btn_CerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CerrarSesion.ForeColor = Color.Black;
            btn_CerrarSesion.Location = new Point(508, 261);
            btn_CerrarSesion.Name = "btn_CerrarSesion";
            btn_CerrarSesion.Size = new Size(118, 29);
            btn_CerrarSesion.TabIndex = 6;
            btn_CerrarSesion.Text = "Cerrar sesion";
            btn_CerrarSesion.UseVisualStyleBackColor = false;
            btn_CerrarSesion.Click += btn_CerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_NombreUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(153, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 33);
            panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.persona;
            pictureBox2.Location = new Point(281, 4);
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
            lbl_NombreUsuario.Location = new Point(321, 9);
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
            // FrmMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 302);
            Controls.Add(panel1);
            Controls.Add(btn_CerrarSesion);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMenuEmpleado_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button button1;
        private Button btn_CerrarSesion;
        private Panel panel1;
        private Label label1;
        private Label lbl_NombreUsuario;
        private PictureBox pictureBox2;
    }
}