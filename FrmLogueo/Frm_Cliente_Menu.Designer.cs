namespace WF_TransporteRodriguez
{
    partial class Frm_Cliente_Menu
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
            menuStrip1 = new MenuStrip();
            listarMisViajesToolStripMenuItem = new ToolStripMenuItem();
            reservarViajeToolStripMenuItem = new ToolStripMenuItem();
            cancelarViajeToolStripMenuItem = new ToolStripMenuItem();
            ms_MenuCliente = new MenuStrip();
            misViajeToolStripMenuItem = new ToolStripMenuItem();
            reservarViajeToolStripMenuItem1 = new ToolStripMenuItem();
            modificarViajeToolStripMenuItem1 = new ToolStripMenuItem();
            cancelarViajeToolStripMenuItem2 = new ToolStripMenuItem();
            listarViajeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ms_MenuCliente.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 128);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { listarMisViajesToolStripMenuItem, reservarViajeToolStripMenuItem, cancelarViajeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(165, 302);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // listarMisViajesToolStripMenuItem
            // 
            listarMisViajesToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listarMisViajesToolStripMenuItem.Margin = new Padding(0, 33, 0, 20);
            listarMisViajesToolStripMenuItem.Name = "listarMisViajesToolStripMenuItem";
            listarMisViajesToolStripMenuItem.Size = new Size(152, 34);
            listarMisViajesToolStripMenuItem.Text = "Listar viajes";
            // 
            // reservarViajeToolStripMenuItem
            // 
            reservarViajeToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            reservarViajeToolStripMenuItem.Margin = new Padding(0, 33, 0, 20);
            reservarViajeToolStripMenuItem.Name = "reservarViajeToolStripMenuItem";
            reservarViajeToolStripMenuItem.Size = new Size(152, 34);
            reservarViajeToolStripMenuItem.Text = "Reservar viaje";
            // 
            // cancelarViajeToolStripMenuItem
            // 
            cancelarViajeToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarViajeToolStripMenuItem.Margin = new Padding(0, 33, 0, 20);
            cancelarViajeToolStripMenuItem.Name = "cancelarViajeToolStripMenuItem";
            cancelarViajeToolStripMenuItem.Size = new Size(152, 34);
            cancelarViajeToolStripMenuItem.Text = "Cancelar viaje";
            // 
            // ms_MenuCliente
            // 
            ms_MenuCliente.BackColor = Color.FromArgb(255, 192, 128);
            ms_MenuCliente.Dock = DockStyle.Left;
            ms_MenuCliente.Items.AddRange(new ToolStripItem[] { misViajeToolStripMenuItem, reservarViajeToolStripMenuItem1, modificarViajeToolStripMenuItem1, cancelarViajeToolStripMenuItem2, listarViajeToolStripMenuItem });
            ms_MenuCliente.Location = new Point(0, 0);
            ms_MenuCliente.Name = "ms_MenuCliente";
            ms_MenuCliente.Size = new Size(177, 469);
            ms_MenuCliente.TabIndex = 2;
            ms_MenuCliente.Text = "menuStrip2";
            // 
            // misViajeToolStripMenuItem
            // 
            misViajeToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            misViajeToolStripMenuItem.Margin = new Padding(0, 33, 0, 20);
            misViajeToolStripMenuItem.Name = "misViajeToolStripMenuItem";
            misViajeToolStripMenuItem.Size = new Size(164, 34);
            misViajeToolStripMenuItem.Text = "Mi perfil";
            misViajeToolStripMenuItem.Click += misViajeToolStripMenuItem_Click;
            // 
            // reservarViajeToolStripMenuItem1
            // 
            reservarViajeToolStripMenuItem1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            reservarViajeToolStripMenuItem1.Margin = new Padding(0, 0, 0, 20);
            reservarViajeToolStripMenuItem1.Name = "reservarViajeToolStripMenuItem1";
            reservarViajeToolStripMenuItem1.Size = new Size(164, 34);
            reservarViajeToolStripMenuItem1.Text = "Reservar viaje";
            reservarViajeToolStripMenuItem1.Click += reservarViajeToolStripMenuItem1_Click;
            // 
            // modificarViajeToolStripMenuItem1
            // 
            modificarViajeToolStripMenuItem1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            modificarViajeToolStripMenuItem1.Margin = new Padding(0, 0, 0, 20);
            modificarViajeToolStripMenuItem1.Name = "modificarViajeToolStripMenuItem1";
            modificarViajeToolStripMenuItem1.Size = new Size(164, 34);
            modificarViajeToolStripMenuItem1.Text = "Modificar viaje";
            modificarViajeToolStripMenuItem1.Click += modificarViajeToolStripMenuItem1_Click;
            // 
            // cancelarViajeToolStripMenuItem2
            // 
            cancelarViajeToolStripMenuItem2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarViajeToolStripMenuItem2.Margin = new Padding(0, 0, 0, 20);
            cancelarViajeToolStripMenuItem2.Name = "cancelarViajeToolStripMenuItem2";
            cancelarViajeToolStripMenuItem2.Size = new Size(164, 34);
            cancelarViajeToolStripMenuItem2.Text = "Cancelar viaje";
            cancelarViajeToolStripMenuItem2.Click += cancelarViajeToolStripMenuItem2_Click;
            // 
            // listarViajeToolStripMenuItem
            // 
            listarViajeToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listarViajeToolStripMenuItem.Margin = new Padding(0, 0, 0, 20);
            listarViajeToolStripMenuItem.Name = "listarViajeToolStripMenuItem";
            listarViajeToolStripMenuItem.Size = new Size(164, 34);
            listarViajeToolStripMenuItem.Text = "Listar viajes";
            listarViajeToolStripMenuItem.Click += listarViajeToolStripMenuItem_Click;
            // 
            // FrmMenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 469);
            Controls.Add(menuStrip1);
            Controls.Add(ms_MenuCliente);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuCliente";
            Load += FrmMenuCliente_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ms_MenuCliente.ResumeLayout(false);
            ms_MenuCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listarMisViajesToolStripMenuItem;
        private ToolStripMenuItem reservarViajeToolStripMenuItem;
        private ToolStripMenuItem cancelarViajeToolStripMenuItem;
        private MenuStrip ms_MenuCliente;
        private ToolStripMenuItem misViajeToolStripMenuItem;
        private ToolStripMenuItem reservarViajeToolStripMenuItem1;
        private ToolStripMenuItem modificarViajeToolStripMenuItem1;
        private ToolStripMenuItem cancelarViajeToolStripMenuItem2;
        private ToolStripMenuItem listarViajeToolStripMenuItem;
    }
}