using Enumerado;
using FrmLogueo;
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

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleados_Lista_Vehiculos : Form
    {
        public Frm_Empleados_Lista_Vehiculos()
        {
            InitializeComponent();
        }
        private void FrmListarVehiculos_Load(object sender, EventArgs e)
        {
            dtg_Listar.DataSource = Repositorio_Vehiculos.ListaVehiculos;
        }
        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }
    }
}
