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
    public partial class FrmModificarViajeCliente : Form
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public FrmModificarViajeCliente()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmModificarViajeCliente_Load(object sender, EventArgs e)
        {
            viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dtg_ListarViajes.DataSource = viajesCliente;
            dtp_FechaDeViaje.MinDate = DateTime.Today;

        }

        private void pic_EditarViaje_Click(object sender, EventArgs e)
        {
            Viaje? viajeAux;

            // tengo que verificar que el id de viaje sea del cliente y que la fecha se mayor a hoy
            //se supone que por como funciona el cortafuego no deberia ser null viajeAux porque ya se corta el if en la primer condicion
            if (Sistema.buscarViaje(int.Parse(txt_IdDeViajeAModificar.Text), out viajeAux) == true
                && viajeAux.NombreCliente == Cliente.Nombre && viajeAux.FechaViaje > DateTime.Today)
            {
                viajeAux.FechaViaje = dtp_FechaDeViaje.Value;
                viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
                dtg_ListarViajes.DataSource = viajesCliente;
            }
            else
            {
                MessageBox.Show("Verifique datos ingresados. \n");
            }
        }
    }
}
