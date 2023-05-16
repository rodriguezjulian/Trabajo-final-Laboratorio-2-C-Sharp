﻿using Enumerado;
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
            if (Repositorio_Vehiculos.VerificarPatente(txt_AltaPatente.Text) == 0)
            {
                Repositorio_Vehiculos.ListaVehiculos.Add(new Vehiculo(Repositorio_Vehiculos.CalcularIdVehiculo(), (Marcas)cbo_Marca.SelectedItem,
                    (int)nup_Kilos.Value, (Colores)cbo_Color.SelectedItem, txt_AltaPatente.Text,true));
                MessageBox.Show("Vehiculo dado de alta satisfactoriamente\n");
            }
            else
            {
                if (Repositorio_Vehiculos.VerificarPatente(txt_AltaPatente.Text) == 1)
                {
                    MessageBox.Show("ERROR, Verifique la patente ingresada\n");
                }
                else
                {
                    MessageBox.Show("ERROR, La patente ingresada pertenece a un vehiculo existente\n");
                }
                
            }
        }
        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}