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
    public partial class FrmViaje : Form
    {
        Usuario clienteInstanciado;
        Cliente cliente;
        public FrmViaje()
        {
            InitializeComponent();
        }

        public Usuario ClienteInstanciado { get => clienteInstanciado; set => clienteInstanciado = value; }

        private void button1_Click(object sender, EventArgs e)
        {

            string id;
            id = Sistema.CalcularIdViaje();

            if (Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), DateTime.Parse(txt_Fecha.Text)) != 0)
            {
                txt_IdVehiculo.Text = Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), DateTime.Parse(txt_Fecha.Text)).ToString();
                Sistema.ListaViajes.Add(new Viaje(int.Parse(id), txt_Nombre.Text, txt_DireccionSalida.Text,
                cbo_Provincias.SelectedItem.ToString(), float.Parse(txt_Kg.Text),
                Sistema.calcularPrecioViaje(cbo_Provincias.SelectedIndex, float.Parse(txt_Kg.Text)),
                Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), DateTime.Parse(txt_Fecha.Text)),
                DateTime.Parse(txt_Fecha.Text)));
            }
            else
            {
                MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
            }
            dataGridView1.DataSource = Sistema.ListaViajes;
        }

        private void FrmViaje_Load(object sender, EventArgs e)
        {
            cliente = Sistema.BuscarCliente(clienteInstanciado);
            txt_Nombre.Text = cliente.Nombre;
            Sistema.AgregarViajes();
            txt_Id.Text = Sistema.CalcularIdViaje();
            txt_DireccionSalida.Text = cliente.DireccionBSAS;
            cbo_Provincias.SelectedIndex = 0;
        }

    }
}
