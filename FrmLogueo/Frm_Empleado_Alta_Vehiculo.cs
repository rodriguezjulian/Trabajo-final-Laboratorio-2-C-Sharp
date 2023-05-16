using Enumerado;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Alta_Vehiculo : Frm_Empleado_Diseño
    {
        public Frm_Empleado_Alta_Vehiculo()
        {
            InitializeComponent();
        }
        private void Frm_Empleado_Alta_Vehiculo_Load(object sender, EventArgs e)
        {
            cbo_Marca.DataSource = Enum.GetValues(typeof(Marcas));
            cbo_Color.DataSource = Enum.GetValues(typeof(Colores));
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            if (Repositorio_Vehiculos.VerificarPatente(txt_AltaPatente.Text) == true)
            {
                /*Repositorio_Vehiculos.ListaVehiculos.Add(new Vehiculo(Repositorio_Vehiculos.CalcularIdVehiculo(), cbo_Marca.SelectedItem.ToString(),
                    nup_Kilos.Value, cbo_Color.SelectedItem.ToString(), txt_AltaPatente.Text));*/
                    

                MessageBox.Show("Vehiculo dado de alta satisfactoriamente\n");
            }
            else
            {
                MessageBox.Show("ERROR, Verifique la patente ingresada\n");
            }
        }
    }
}
