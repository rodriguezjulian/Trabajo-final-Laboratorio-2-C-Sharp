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
    public partial class Frm_Cliente_Alta_Viaje : Form
    {
        Usuario clienteInstanciado;
        Cliente cliente;
        Viaje viajeAux;
        Repositorio_Clientes repositorio_Clientes=new Repositorio_Clientes();
        Repositorio_Viajes repositorio_Viajes = new Repositorio_Viajes();
        public Frm_Cliente_Alta_Viaje()
        {
            InitializeComponent();
        }

        public Usuario ClienteInstanciado { get => clienteInstanciado; set => clienteInstanciado = value; }
        private void FrmViaje_Load(object sender, EventArgs e)
        {
            cliente = repositorio_Clientes.BuscarInstancia(clienteInstanciado);
            txt_Nombre.Text = cliente.Nombre;
            txt_DireccionSalida.Text = cliente.DireccionBSAS;
            cbo_Provincias.SelectedIndex = 0;
            dtp_FechaDeViaje.MinDate = DateTime.Today;
            lbl_NombreClient.Text = cliente.Nombre;
        }

        private void pic_ReservarViajar_Click(object sender, EventArgs e)
        {
           
            if (Repositorio_Vehiculos.RetornarVehiculoDisponible((float)nup_Kilos.Value, dtp_FechaDeViaje.Value) != 0)
            {
                //CREAR METODO -- VERIFICAR 
                Repositorio_Viajes.ListaViajes.Add(new Viaje(repositorio_Viajes.CalcularId(), txt_Nombre.Text, txt_DireccionSalida.Text,
                cbo_Provincias.SelectedItem.ToString(), (float)nup_Kilos.Value,
                Repositorio_Viajes.calcularPrecioViaje(cbo_Provincias.SelectedIndex, (float)nup_Kilos.Value),
                Repositorio_Vehiculos.RetornarVehiculoDisponible((float)nup_Kilos.Value, dtp_FechaDeViaje.Value),
                dtp_FechaDeViaje.Value.Date));

                viajeAux=repositorio_Viajes.BuscarInstanciaId(repositorio_Viajes.CalcularId() - 1);
                MessageBox.Show("VIAJE CONFIRMADO\n" + viajeAux.ToString());
                Frm_Cliente_Menu anterior = new Frm_Cliente_Menu();
                anterior.usuarioInstanciado = clienteInstanciado;
                this.Close();
                anterior.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
            }
        }
        #region EVENTOS PARA EL MOUSE
        private void pic_ReservarViajar_MouseLeave(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Transparent;
        }

        private void pic_ReservarViajar_MouseEnter(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Transparent;
        }
        #endregion 
        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


    }
}
