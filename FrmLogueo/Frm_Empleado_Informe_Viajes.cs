using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransporteRodriguez;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Informe_Viajes : Form
    {
        public Frm_Empleado_Informe_Viajes()
        {
            InitializeComponent();
        }
        private void pic_ReservarViajar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaArchivo;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //if (File.Exists(saveFileDialog.FileName))
                    //{
                    rutaArchivo = saveFileDialog.FileName;
                    Repositorio_Viajes.Repo_Viajes.GuardarViajes(dtp_LimiteInferior.Value.Date, dtp_LimiteSuperior.Value.Date, rutaArchivo);
                    MessageBox.Show("Informe generado con exito");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


    }
}
