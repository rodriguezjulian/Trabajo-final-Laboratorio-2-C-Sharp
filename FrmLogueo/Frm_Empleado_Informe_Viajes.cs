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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Repositorio_Viajes.Repo_Viajes.GuardarViajes(dtp_LimiteInferior.Value.Date, dtp_LimiteSuperior.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
