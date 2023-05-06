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
    public partial class FrmListarVehiculos : Frmdiseño
    {
        Usuario usuarioInstanciado;
        public FrmListarVehiculos()
        {
            InitializeComponent();
        }

        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }

        private void FrmListarVehiculos_Load(object sender, EventArgs e)
        {
            Sistema.AgregarVehiculos();
            lbl_NombreUsuarioCliente.Text = usuarioInstanciado.Nombre;
            dataGridView2.DataSource = Sistema.ListaVehiculos;
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            FrmMenuEmpleado anterior = new FrmMenuEmpleado();
            anterior.UsuarioInstanciado = usuarioInstanciado;
            anterior.ShowDialog();
            this.Hide();

        }
    }
}
