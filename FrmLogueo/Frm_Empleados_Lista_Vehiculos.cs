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
        Usuario usuarioInstanciado;
        public Frm_Empleados_Lista_Vehiculos()
        {
            InitializeComponent();
        }

        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }

        private void FrmListarVehiculos_Load(object sender, EventArgs e)
        {
            Sistema.AgregarVehiculos();
            lbl_nombreUsuario.Text = usuarioInstanciado.Nombre;
            dataGridView2.DataSource = Sistema.ListaVehiculos;
        }
        private void pic_Volver_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Menu anterior = new Frm_Empleado_Menu();
            anterior.UsuarioInstanciado = usuarioInstanciado;
            anterior.ShowDialog();
            this.Hide();

        }
    }
}
