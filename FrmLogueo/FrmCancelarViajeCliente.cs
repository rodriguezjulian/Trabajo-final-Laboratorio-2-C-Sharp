using System;
using System.Collections;
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
    public partial class FrmCancelarViajeCliente : Form
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public FrmCancelarViajeCliente()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmCancelarViajeCliente_Load(object sender, EventArgs e)
        {
            viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dtg_ListarViajes.DataSource = viajesCliente;
        }

        private void pic_EliminarViaje_Click(object sender, EventArgs e)
        {
            //NO PUEDE ELIMINAR UN VIAJE QUE YA SE REALIZO
            Viaje? viajeAux;
            if (Sistema.buscarViaje(int.Parse(txt_IdDeViajeACancelar.Text), out viajeAux) == true
                && viajeAux.NombreCliente == Cliente.Nombre && viajeAux.FechaViaje > DateTime.Today)
            {
                Sistema.ListaViajes.Remove(viajeAux);
                viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
                dtg_ListarViajes.DataSource = viajesCliente;
            }
        }
        private void pic_EliminarViaje_MouseLeave(object sender, EventArgs e)
        {
            pic_EliminarViaje.BackColor = Color.Transparent;
        }

        private void pic_EliminarViaje_MouseEnter(object sender, EventArgs e)
        {
            pic_EliminarViaje.BackColor = Color.Black;
        }
    }
}
