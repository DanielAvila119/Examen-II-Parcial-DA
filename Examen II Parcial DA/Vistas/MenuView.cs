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
    }
}
