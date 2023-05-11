namespace WF_TransporteRodriguez
{
    partial class Frm_Hora
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
            lbl_Hora = new Label();
            tmr_HoraMenu = new System.Windows.Forms.Timer(components);
            pln_Contedor = new Panel();
            lbl_Fecha = new Label();
            pln_Contedor.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Hora
            // 
            lbl_Hora.BackColor = Color.FromArgb(255, 128, 0);
            lbl_Hora.Dock = DockStyle.Top;
            lbl_Hora.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Hora.ForeColor = Color.White;
            lbl_Hora.Location = new Point(0, 0);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(590, 150);
            lbl_Hora.TabIndex = 1;
            lbl_Hora.Text = "{HORA}";
            lbl_Hora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmr_HoraMenu
            // 
            tmr_HoraMenu.Enabled = true;
            tmr_HoraMenu.Tick += tmr_HoraMenu_Tick;
            // 
            // pln_Contedor
            // 
            pln_Contedor.BackColor = Color.FromArgb(255, 128, 0);
            pln_Contedor.Controls.Add(lbl_Fecha);
            pln_Contedor.Controls.Add(lbl_Hora);
            pln_Contedor.Dock = DockStyle.Fill;
            pln_Contedor.Location = new Point(65, 90);
            pln_Contedor.Margin = new Padding(0);
            pln_Contedor.Name = "pln_Contedor";
            pln_Contedor.Size = new Size(590, 289);
            pln_Contedor.TabIndex = 2;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.BackColor = Color.FromArgb(255, 128, 0);
            lbl_Fecha.Dock = DockStyle.Fill;
            lbl_Fecha.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Fecha.ForeColor = Color.White;
            lbl_Fecha.Location = new Point(0, 150);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(590, 139);
            lbl_Fecha.TabIndex = 2;
            lbl_Fecha.Text = "{FECHA}";
            lbl_Fecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_Hora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(pln_Contedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Hora";
            Padding = new Padding(65, 90, 65, 90);
            Text = "Frm_Hora";
            pln_Contedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Hora;
        private System.Windows.Forms.Timer tmr_HoraMenu;
        private Panel pln_Contedor;
        private Label lbl_Fecha;
    }
}