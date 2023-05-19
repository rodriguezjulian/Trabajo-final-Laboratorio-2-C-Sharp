﻿using System;
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
    public partial class Frm_Cliente_Cancelacion_Viaje : Form
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public Frm_Cliente_Cancelacion_Viaje()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmCancelarViajeCliente_Load(object sender, EventArgs e)
        {
            viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.FechaViaje > DateTime.Now && viaje.Estado == true);
            OrganizarDataGridViajes(viajesCliente);
            lbl_NombreClient.Text = cliente.Nombre;
        }

        private void pic_EliminarViaje_Click(object sender, EventArgs e)
        {
            //NO PUEDE ELIMINAR UN VIAJE QUE YA SE REALIZO
            if (!string.IsNullOrEmpty(txt_IdDeViajeACancelar.Text))
            {
                if (DateTime.Parse(txt_Fecha.Text) > DateTime.Today)
                {
                    Repositorio_Viajes.Repo_Viajes.DarDeBaja(int.Parse(txt_IdDeViajeACancelar.Text));
                    dtg_ListaViajes.Columns.Clear();
                    viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.FechaViaje > DateTime.Now && viaje.Estado == true);
                    OrganizarDataGridViajes(viajesCliente);
                    txt_IdDeViajeACancelar .Text= "";
                    txt_Fecha.Text = "";

                    MessageBox.Show("Viaje cancelado \n");
                }
            }
            else
            {
                MessageBox.Show("Seleccione viaje \n");
            }
        }
        #region EVENTOS PARA EL MOUSE
        private void pic_EliminarViaje_MouseLeave(object sender, EventArgs e)
        {
            pic_EliminarViaje.BackColor = Color.Transparent;
        }

        private void pic_EliminarViaje_MouseEnter(object sender, EventArgs e)
        {
            pic_EliminarViaje.BackColor = Color.Black;
        }
        private void pic_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Transparent;
        }

        private void pic_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Orange;
        }
        #endregion
        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void dtg_ListarViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdDeViajeACancelar.Text = dtg_ListaViajes.CurrentRow.Cells[0].Value.ToString();
            txt_Fecha.Text = dtg_ListaViajes.CurrentRow.Cells[1].Value.ToString();
        }
        public void OrganizarDataGridViajes(List<Viaje> viajesCliente)
        {

            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesCliente;
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
                DataPropertyName = "DireccionSalida",
                HeaderText = "Salida",
                DisplayIndex = 3
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProvinciaDestino",
                HeaderText = "Destino",
                DisplayIndex = 4
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DisplayIndex = 5
            });
        }
    }
}
