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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, moToolStripMenuItem, bajarToolStripMenuItem, listarToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clienteToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 34);
            clienteToolStripMenuItem.Text = "Cliente";
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
            pictureBox1.Location = new Point(153, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 301);
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
            // FrmMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 302);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuEmpleado";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}