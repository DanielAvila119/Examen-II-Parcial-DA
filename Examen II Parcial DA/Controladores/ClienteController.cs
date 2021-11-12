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
    public class ClienteController
    {
        ClientesView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;

        public ClienteController(ClientesView view)
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
            if (vista.ClientesDataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = clienteDAO.EliminarCliente(Convert.ToInt32(vista.ClientesDataGridView1.CurrentRow.Cells[0].Value.ToString()));
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
            if (vista.ClientesDataGridView1.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.ClientesDataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_Identidad.Text = vista.ClientesDataGridView1.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                vista.txt_Nombre.Text = vista.ClientesDataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txt_Email.Text = vista.ClientesDataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txt_Direccion.Text = vista.ClientesDataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ClientesDataGridView1.DataSource = clienteDAO.GetCliente();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_Identidad.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Identidad, "Por favor ingrese una Identidad");
                vista.txt_Identidad.Focus();
                return;
            }
            if (vista.txt_Nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Nombre, "Por favor ingrese un Nombre");
                vista.txt_Nombre.Focus();
                return;
            }
            if (vista.txt_Email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Email, "Por favor ingrese un Email");
                vista.txt_Email.Focus();
                return;
            }
            if (vista.txt_Direccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Direccion, "Por favor ingrese una Dirección");
                vista.txt_Direccion.Focus();
                return;
            }

            try
            {
                cliente.Identidad = vista.txt_Identidad.Text;
                cliente.Nombre = vista.txt_Nombre.Text.ToUpper();
                cliente.Email = vista.txt_Email.Text;
                cliente.Direccion = vista.txt_Direccion.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                    if (inserto)
                    {
                        MessageBox.Show("Cliente creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el Cliente, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        

        private void HabilitarControles()
        {
            //Habilitar TextBoxs
            vista.txt_Identidad.Enabled = true;
            vista.txt_Nombre.Enabled = true;
            vista.txt_Email.Enabled = true;
            vista.txt_Direccion.Enabled = true;

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
            vista.txt_Nombre.Enabled = false;
            vista.txt_Email.Enabled = false;
            vista.txt_Identidad.Enabled = false;
            vista.txt_Direccion.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_ID.Clear();
            vista.txt_Nombre.Clear();
            vista.txt_Email.Clear();
            vista.txt_Identidad.Clear();
            vista.txt_Direccion.Clear();
        }
    }
}
