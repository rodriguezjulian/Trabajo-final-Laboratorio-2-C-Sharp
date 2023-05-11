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
    public partial class Frm_Cliente_Modificacion_Viaje : Form
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public Frm_Cliente_Modificacion_Viaje()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmModificarViajeCliente_Load(object sender, EventArgs e)
        {
            viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dtg_ListarViajes.DataSource = viajesCliente;
            dtp_FechaDeViaje.MinDate = DateTime.Today;
            lbl_NombreCliente.Text = cliente.Nombre;

        }

        private void pic_EditarViaje_Click(object sender, EventArgs e)
        {
            Viaje? viajeAux;

            // tengo que verificar que el id de viaje sea del cliente y que la fecha se mayor a hoy
            //se supone que por como funciona el cortafuego no deberia ser null viajeAux porque ya se corta el if en la primer condicion
            //El guion bajo (_) se utiliza como una convención para indicar que no se va a utilizar el valor de salida.
            if (int.TryParse(txt_IdDeViajeAModificar.Text, out _) == true
                && int.TryParse(txt_Kg.Text, out _) == true
                    && Sistema.buscarViaje(int.Parse(txt_IdDeViajeAModificar.Text), out viajeAux) == true
                && viajeAux.NombreCliente == Cliente.Nombre && viajeAux.FechaViaje > DateTime.Today)
            {
                viajeAux.FechaViaje = dtp_FechaDeViaje.Value;
                viajeAux.KilosATransportar = float.Parse(txt_Kg.Text);
                viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
                dtg_ListarViajes.DataSource = viajesCliente;
            }
            else
            {
                MessageBox.Show("Verifique datos ingresados. \n");
            }
        }

        private void pic_EditarViaje_MouseEnter(object sender, EventArgs e)
        {
            pic_EditarViaje.BackColor = Color.Orange;
        }

        private void pic_EditarViaje_MouseLeave(object sender, EventArgs e)
        {
            pic_EditarViaje.BackColor = Color.Transparent;
        }

        private void pic_CancelarModificacion_MouseEnter(object sender, EventArgs e)
        {
            pic_CancelarModificacion.BackColor = Color.Orange;
        }

        private void pic_CancelarModificacion_MouseLeave(object sender, EventArgs e)
        {
            pic_CancelarModificacion.BackColor = Color.Transparent;
        }

        private void pic_CancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


    }
}
