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
            SuspendLayout();
            // 
            // lbl_Hora
            // 
            lbl_Hora.Dock = DockStyle.Fill;
            lbl_Hora.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Hora.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_Hora.Location = new Point(0, 0);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(720, 469);
            lbl_Hora.TabIndex = 1;
            lbl_Hora.Text = "{HORA}";
            lbl_Hora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmr_HoraMenu
            // 
            tmr_HoraMenu.Enabled = true;
            tmr_HoraMenu.Tick += tmr_HoraMenu_Tick;
            // 
            // Frm_Hora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(lbl_Hora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Hora";
            Text = "Frm_Hora";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Hora;
        private System.Windows.Forms.Timer tmr_HoraMenu;
    }
}