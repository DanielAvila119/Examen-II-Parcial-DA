using Examen_II_Parcial_DA.Modelos.DAO;
using Examen_II_Parcial_DA.Modelos.Entidades;
using Examen_II_Parcial_DA.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Parcial_DA.Controladores
{
    public class TicketsController
    {
        TicketsView vista;
        TicketsDAO ticketsDAO = new TicketsDAO();
        Tickets tickets = new Tickets();
        string operacion = string.Empty;

        public TicketsController(TicketsView view)
        {
            vista = view;
            vista.btn_Nuevo.Click += new EventHandler(Nuevo);
            vista.btn_Guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_Eliminar.Click += new EventHandler(Eliminar);
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.TicketsDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = ticketsDAO.EliminarTicket(Convert.ToInt32(vista.TicketsDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Usuario Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se puedo Eliminar el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.TicketsDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.TicketsDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_NomCliente.Text = vista.TicketsDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txt_EmailCliente.Text = vista.TicketsDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txt_Asunto.Text = vista.TicketsDataGridView.CurrentRow.Cells["ASUNTO"].Value.ToString();
                vista.txt_Mensaje.Text = vista.TicketsDataGridView.CurrentRow.Cells["MENSAJE"].Value.ToString();
                vista.txt_numTicket.Text = vista.TicketsDataGridView.CurrentRow.Cells["NUMEROTICKET"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.TicketsDataGridView.DataSource = ticketsDAO.GetTicket();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_NomCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_NomCliente, "Por favor ingrese un Nombre del Cliente");
                vista.txt_NomCliente.Focus();
                return;
            }
            if (vista.txt_EmailCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_EmailCliente, "Por favor ingrese un Email del Cliente");
                vista.txt_EmailCliente.Focus();
                return;
            }
            if (vista.txt_Dispositivo.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Dispositivo, "Por favor ingrese un Dispositivo");
                vista.txt_Dispositivo.Focus();
                return;
            }
            if (vista.txt_Asunto.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Asunto, "Por favor ingrese un Asunto");
                vista.txt_Asunto.Focus();
                return;
            }
            if (vista.txt_Mensaje.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Mensaje, "Por favor ingrese un Mensaje");
                vista.txt_Mensaje.Focus();
                return;
            }
            if (vista.txt_numTicket.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_numTicket, "Por favor ingrese un Mensaje");
                vista.txt_numTicket.Focus();
                return;
            }

            try
            {
                tickets.Nombre = vista.txt_NomCliente.Text.ToUpper();
                tickets.Email = vista.txt_EmailCliente.Text;
                tickets.Dispositivo = vista.txt_Dispositivo.Text;
                tickets.Asunto = vista.txt_Asunto.Text;
                tickets.Mensaje = vista.txt_Mensaje.Text;
                tickets.numTicket = vista.txt_numTicket.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = ticketsDAO.InsertarNuevoTicket(tickets);
                    if (inserto)
                    {
                        MessageBox.Show("Ticket creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el Ticket, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    tickets.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = ticketsDAO.ActualizarTicket(tickets);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Ticket Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el Ticket. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void HabilitarControles()
        {
            //Habilitar TextBoxs
            vista.txt_NomCliente.Enabled = true;
            vista.txt_EmailCliente.Enabled = true;
            vista.txt_Dispositivo.Enabled = true;
            vista.txt_Asunto.Enabled = true;
            vista.txt_Mensaje.Enabled = true;
            vista.txt_numTicket.Enabled = true;

            //Habilitar Botones
            vista.btn_Guardar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Nuevo.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_NomCliente.Enabled = false;
            vista.txt_EmailCliente.Enabled = false;
            vista.txt_Dispositivo.Enabled = false;
            vista.txt_Asunto.Enabled = false;
            vista.txt_Mensaje.Enabled = false;
            vista.txt_numTicket.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_ID.Clear();
            vista.txt_NomCliente.Clear();
            vista.txt_EmailCliente.Clear();
            vista.txt_Dispositivo.Clear();
            vista.txt_Asunto.Clear();
            vista.txt_Mensaje.Clear();
            vista.txt_numTicket.Clear();
        }
    }
}
