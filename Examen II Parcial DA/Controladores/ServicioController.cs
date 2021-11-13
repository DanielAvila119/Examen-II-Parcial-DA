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
    public class ServicioController
    {
        SoporteView vista;
        ServicioDAO servicioDAO = new ServicioDAO();
        Servicio servicio = new Servicio();
        string operacion = string.Empty;

        public ServicioController(SoporteView view)
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
            if (vista.ServicioDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = servicioDAO.EliminarServicio(Convert.ToInt32(vista.ServicioDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Servicio Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se puedo Servicio el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.ServicioDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.ServicioDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_cliente.Text = vista.ServicioDataGridView.CurrentRow.Cells["CLIENTE"].Value.ToString();
                vista.cbx_Dispositivo.Text = vista.ServicioDataGridView.CurrentRow.Cells["DISPOSITIVO"].Value.ToString();
                vista.cbx_Problema.Text = vista.ServicioDataGridView.CurrentRow.Cells["PROBLEMA"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ServicioDataGridView.DataSource = servicioDAO.GetServicio();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_cliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_cliente, "Por favor ingrese un Cliente");
                vista.txt_cliente.Focus();
                return;
            }
            if (vista.cbx_Dispositivo.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbx_Dispositivo, "Por favor ingrese el Dispositivo");
                vista.cbx_Dispositivo.Focus();
                return;
            }
            if (vista.cbx_Problema.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbx_Problema, "Por favor ingrese su Problema");
                vista.cbx_Problema.Focus();
                return;
            }

            try
            {
                servicio.Cliente = vista.txt_cliente.Text;
                servicio.Dispositivo = vista.cbx_Dispositivo.Text;
                servicio.Problema = vista.cbx_Problema.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = servicioDAO.InsertarNuevoServicio(servicio);
                    if (inserto)
                    {
                        MessageBox.Show("Servicio registrado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el Servicio, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    servicio.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = servicioDAO.ActualizarServicio(servicio);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Servicio Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el Servicio. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            vista.txt_cliente.Enabled = true;
            vista.cbx_Dispositivo.Enabled = true;
            vista.cbx_Problema.Enabled = true;

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
            vista.txt_cliente.Enabled = true;
            vista.cbx_Dispositivo.Enabled = true;
            vista.cbx_Problema.Enabled = true;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_cliente.Clear();
            vista.cbx_Dispositivo.Text = "";
            vista.cbx_Problema.Text = "";
        }
    }
}
