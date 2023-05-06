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

            Sistema.ListaViajes.Add(new Viaje(int.Parse(id), txt_Nombre.Text, txt_DireccionSalida.Text,
                txt_ProvinciaDestino.Text, float.Parse(txt_Kg.Text), float.Parse(txt_Precio.Text), short.Parse(txt_IdVehiculo.Text), DateTime.Parse(txt_Fecha.Text)));
            // Sistema.AgregarViajes();
            dataGridView1.DataSource = Sistema.ListaViajes;
        }

        private void FrmViaje_Load(object sender, EventArgs e)
        {
            cliente = Sistema.BuscarCliente(clienteInstanciado);
            txt_Nombre.Text = cliente.Nombre;
            Sistema.AgregarViajes();//
            txt_Id.Text = Sistema.CalcularIdViaje();
            txt_DireccionSalida.Text = cliente.DireccionBSAS;
        }
    }
}
