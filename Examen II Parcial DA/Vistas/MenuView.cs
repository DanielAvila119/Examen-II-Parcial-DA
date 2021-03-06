using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_II_Parcial_DA.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        ClientesView vistaClientes;
        SoporteView vistaServicio;
        EstadoTicketsView vistaEstado;
        TicketsView vistaTicket;
        DetalleView vistaDetalle;
        private void ClienteToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaClientes == null)
            {
                vistaClientes = new ClientesView();
                vistaClientes.MdiParent = this;
                vistaClientes.FormClosed += VistaClientes_FormClosed;
                vistaClientes.Show();
            }
            else
            {
                vistaClientes.Activate();
            }
        }

        private void VistaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClientes = null;
        }

        private void SoporteToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaServicio == null)
            {
                vistaServicio = new SoporteView();
                vistaServicio.MdiParent = this;
                vistaServicio.FormClosed += VistaServicio_FormClosed;
                vistaServicio.Show();
            }
            else
            {
                vistaServicio.Activate();
            }
        }

        private void VistaServicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaServicio = null;
        }

        private void EstadoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoTicketsView();
                vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += VistaEstado_FormClosed; ;
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

        private void VistaEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaEstado = null;
        }

        private void ConsultaTicketTsoolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTicket == null)
            {
                vistaTicket = new TicketsView();
                vistaTicket.MdiParent = this;
                vistaTicket.FormClosed += VistaTicket_FormClosed;
                vistaTicket.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

        private void VistaTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTicket = null;
        }

        private void DetalleToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetalleView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += VistaDetalle_FormClosed;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
        }

        private void VistaDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaDetalle = null;
        }
    }
}
