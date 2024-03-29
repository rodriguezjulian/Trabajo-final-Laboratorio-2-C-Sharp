﻿using System;
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
            //PASAR A REPOSITORIO
            /*  dtp_FechaDeViaje.Format = DateTimePickerFormat.Custom;
              dtp_FechaDeViaje.CustomFormat = " ";*/

            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.FechaViaje > DateTime.Now && viaje.IdCliente == cliente.IdCliente && viaje.Estado == true);
            OrganizarDataGridViajes(viajesCliente);
            dtp_FechaDeViaje.MinDate = DateTime.Today.AddDays(+1);
            lbl_NombreCliente.Text = cliente.Nombre;
        }

        private void pic_EditarViaje_Click(object sender, EventArgs e)
        {
            Viaje viajeAux;
            try
            {
                Repositorio_Viajes.Repo_Viajes.ModificarViaje(txt_IdDeViajeAModificar.Text, Cliente, dtp_FechaDeViaje.Value, ((float)nup_Kg.Value).ToString(), cbo_Provincias.Text, out viajeAux);
                dtg_ListaViajes.Columns.Clear();
                viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.FechaViaje > DateTime.Now && viaje.Estado == true);
                OrganizarDataGridViajes(viajesCliente);
                MessageBox.Show("VIAJE MODIFICADO\n" + viajeAux.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Errores.EscribirLogErrores(ex);
            }
        }
        private void pic_CancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dtg_ListarViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdDeViajeAModificar.Text = dtg_ListaViajes.CurrentRow.Cells[0].Value.ToString();
            dtp_FechaDeViaje.Text = dtg_ListaViajes.CurrentRow.Cells[1].Value.ToString();
            nup_Kg.Text = dtg_ListaViajes.CurrentRow.Cells[3].Value.ToString();
            cbo_Provincias.Text = dtg_ListaViajes.CurrentRow.Cells[5].Value.ToString();
        }
        #region EVENTOS PARA EL MOUSE
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
        #endregion

        public void OrganizarDataGridViajes(List<Viaje> viajesClient)
        {
            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesClient;


            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdViaje",
                HeaderText = "ID",
                DisplayIndex = 0
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FechaViaje",
                HeaderText = "Fecha",
                DisplayIndex = 1
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "nombreCliente",
                HeaderText = "Nombre",
                DisplayIndex = 2
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "KilosATransportar",
                HeaderText = "KG",
                DisplayIndex = 3
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionSalida",
                HeaderText = "Salida",
                DisplayIndex = 4
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProvinciaDestino",
                HeaderText = "Destino",
                DisplayIndex = 5
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DisplayIndex = 6
            });
        }

        private void cbo_Provincias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
