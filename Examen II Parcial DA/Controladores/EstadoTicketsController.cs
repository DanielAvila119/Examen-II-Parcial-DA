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
    public class EstadoTicketsController
    {
            EstadoTicketsView vista;
            EstadoTicketsDAO estadoticketDAO = new EstadoTicketsDAO();
            EstadoTickets estadoTickets = new EstadoTickets();
            string operacion = string.Empty;

            public EstadoTicketsController(EstadoTicketsView view)
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
                if (vista.EstadoTicketsDataGridView.SelectedRows.Count > 0)
                {
                    bool elimino = estadoticketDAO.EliminarEstadoTicket(Convert.ToInt32(vista.EstadoTicketsDataGridView.CurrentRow.Cells[0].Value.ToString()));
                    if (elimino)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡El Estado del Ticket ha sido Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo eliminar el Estado del Ticket. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void Modificar(object sender, EventArgs e)
            {
                operacion = "Modificar";
                if (vista.EstadoTicketsDataGridView.SelectedRows.Count > 0)
                {
                    vista.txt_ID.Text = vista.EstadoTicketsDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                    vista.txt_NumeroTicket.Text = vista.EstadoTicketsDataGridView.CurrentRow.Cells["NUMEROTICKET"].Value.ToString();
                    vista.cbx_EstadoTicket.Text = vista.EstadoTicketsDataGridView.CurrentRow.Cells["ESTADOTICKET"].Value.ToString();
                    HabilitarControles();
                }
            }
            private void Load(object sender, EventArgs e)
            {
                ListarClientes();
            }

            private void ListarClientes()
            {
                vista.EstadoTicketsDataGridView.DataSource = estadoticketDAO.GetEstadoTicket();
            }
            private void Nuevo(object sender, EventArgs e)
            {
                HabilitarControles();
                operacion = "Nuevo";
            }
            private void Guardar(object sender, EventArgs e)
            {
                if (vista.txt_NumeroTicket.Text == "")
                {
                    vista.errorProvider1.SetError(vista.txt_NumeroTicket, "Por favor ingrese un Numero de Ticket");
                    vista.txt_NumeroTicket.Focus();
                    return;
                }
                if (vista.cbx_EstadoTicket.Text == "")
                {
                    vista.errorProvider1.SetError(vista.cbx_EstadoTicket, "Por favor ingrese un Estado del Ticket");
                    vista.cbx_EstadoTicket.Focus();
                    return;
                }

                try
                {
                    estadoTickets.numeroTicket = vista.txt_NumeroTicket.Text;
                    estadoTickets.estadoTicket = vista.cbx_EstadoTicket.Text;

                    if (operacion == "Nuevo")
                    {
                        bool inserto = estadoticketDAO.InsertarNuevoEstadoTicket(estadoTickets);
                        if (inserto)
                        {
                            MessageBox.Show("Estado del Ticket registrado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el Estado del Ticket, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (operacion == "Modificar")
                    {
                        estadoTickets.Id = Convert.ToInt32(vista.txt_ID.Text);
                        bool modifico = estadoticketDAO.ActualizarEstadoTicket(estadoTickets);
                        if (modifico)
                        {
                            DeshabilitarControles();
                            LimpiarControles();

                            MessageBox.Show("¡Estado del Ticket modificado exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarClientes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar el Estado del Ticket. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                vista.txt_NumeroTicket.Enabled = true;
                vista.cbx_EstadoTicket.Enabled = true;

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
                vista.txt_ID.Enabled = false;
                vista.txt_NumeroTicket.Enabled = true;
                vista.cbx_EstadoTicket.Enabled = true;

                //Habilitar y desahiblitar Botones
                vista.btn_Guardar.Enabled = false;
                vista.btn_Cancelar.Enabled = false;
                vista.btn_Modificar.Enabled = true;
                vista.btn_Nuevo.Enabled = true;
            }
            private void LimpiarControles()
            {
                vista.txt_NumeroTicket.Clear();
                vista.cbx_EstadoTicket.Text = "";
            }
        
    }
}
