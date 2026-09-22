using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int idClienteSeleccionado;
        public Form1()
        {
            //Constructor
            InitializeComponent();
            ProbarConexion();
            dgvClientes.CellClick += dgvClientes_CellClick;
            CargarClientes();
        }
        private static void ProbarConexion()
        {
            try
            {
                using (var db = new EmpresaContext())
                {
                    bool conectado = db.Database.CanConnect();

                    if (conectado)
                    {
                        //MessageBox.Show("¡Conexión con MySQL correcta!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo conectar con MySQL.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarClientes()
        {
            using var db = new EmpresaContext();
            var clientes = db.Clientes.ToList();

            /*
            MessageBox.Show("Clientes encontrados: " + clientes.Count);
            dgvClientes.DataSource = clientes;*/

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                txtApellido.Focus();
                return;
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El Email es obligatorio.");
                txtEmail.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Introduzca un email válido.");
                txtEmail.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Introduzca un email válido.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                txtTelefono.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (!long.TryParse(txtTelefono.Text, out _) ||
                    txtTelefono.Text.Length != 9)
                {
                    MessageBox.Show("El teléfono debe contener exactamente 9 dígitos.");
                    txtTelefono.Focus();
                    return;
                }
            }

            using (var db = new EmpresaContext())
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                db.Clientes.Add(cliente);
                db.SaveChanges();

                CargarClientes();

                MessageBox.Show("Cliente guardado correctamente.");

                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();
                txtNombre.Focus();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        //Evento
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                txtApellido.Focus();
                return;
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El Email es obligatorio.");
                txtEmail.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Introduzca un email válido.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El Teléfono es obligatorio.");
                txtTelefono.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (!long.TryParse(txtTelefono.Text, out _) ||
                    txtTelefono.Text.Length != 9)
                {
                    MessageBox.Show("El teléfono debe contener exactamente 9 dígitos.");
                    txtTelefono.Focus();
                    return;
                }
            }

            using (var db = new EmpresaContext())
            {
                var cliente = db.Clientes.Find(idClienteSeleccionado);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontró el cliente.");
                    return;
                }

                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Apellido = txtApellido.Text.Trim();
                cliente.Email = txtEmail.Text.Trim();
                cliente.Telefono = txtTelefono.Text.Trim();

                db.SaveChanges();

                CargarClientes();

                idClienteSeleccionado = 0;

                MessageBox.Show("Cliente modificado correctamente.");
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Evento funcionando. Fila: " + e.RowIndex);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                idClienteSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
                txtEmail.Text = fila.Cells["Email"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                using (var db = new EmpresaContext())
                {
                    var cliente = db.Clientes.Find(idClienteSeleccionado);

                    if (cliente != null)
                    {
                        db.Clientes.Remove(cliente);
                        db.SaveChanges();

                        CargarClientes();

                        idClienteSeleccionado = 0;

                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();

                        MessageBox.Show("Cliente eliminado correctamente.");
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarId.Text, out int id))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            using (var db = new EmpresaContext())
            {
                var cliente = db.Clientes.Find(id);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontró ningún cliente con ese ID.");
                    return;
                }

                idClienteSeleccionado = cliente.Id;

                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;

                foreach (DataGridViewRow fila in dgvClientes.Rows)
                {
                    if (fila.Cells["Id"].Value != null &&
                        Convert.ToInt32(fila.Cells["Id"].Value) == cliente.Id)
                    {
                        fila.Selected = true;
                        dgvClientes.CurrentCell = fila.Cells["Id"];
                        break;
                    }
                }
            }
        }
    }
}
