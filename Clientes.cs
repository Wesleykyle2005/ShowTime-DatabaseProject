using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShowTime_DatabseProject
{
    public partial class Clientes : Form
    {
        // Cadena de conexión obtenida desde el archivo de configuración
        private readonly string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Clientes()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        /// <summary>
        /// Configura los componentes iniciales y sus eventos.
        /// </summary>
        private void InitializeCustomComponents()
        {
            // Cargar datos iniciales en el DataGridView
            LoadDataToDataGridView();

            // Desactivar botones hasta que se valide la entrada
            btnRegisterCliente.Enabled = false;
            btnUpdateCliente.Enabled = false;

            // Agregar validación dinámica de entradas de texto
            TxtClienteName.TextChanged += ValidateInputs;
            txtClienteLastName.TextChanged += ValidateInputs;
            numTelefono.TextChanged += ValidateInputs;
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        /// <summary>
        /// Valida los campos de entrada y habilita/deshabilita los botones según corresponda.
        /// </summary>
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isNameValid = !string.IsNullOrWhiteSpace(TxtClienteName.Text);
            bool isLastNameValid = !string.IsNullOrWhiteSpace(txtClienteLastName.Text);
            bool isPhoneValid = !string.IsNullOrWhiteSpace(numTelefono.Text);

            // Habilitar botones solo si los datos son válidos
            btnRegisterCliente.Enabled = isNameValid && isLastNameValid && isPhoneValid;
            btnUpdateCliente.Enabled = dgvClientes.SelectedRows.Count > 0 && isNameValid && isLastNameValid && isPhoneValid;
        }

        /// <summary>
        /// Obtiene todos los clientes desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Cliente.</returns>
        public IEnumerable<Models.Cliente> GetAll()
        {
            List<Models.Cliente> clientes = new List<Models.Cliente>();

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Clientes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Models.Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["Id_cliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                CorreoElectronico = reader["Correo_electronico"]?.ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al obtener los clientes", ex);
            }

            return clientes;
        }

        /// <summary>
        /// Carga los datos de clientes en el DataGridView.
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                dgvClientes.DataSource = GetAll().ToList();

                if (dgvClientes.Columns["Idcliente"] != null)
                    dgvClientes.Columns["Idcliente"].Visible = false;

                if (dgvClientes.Columns["Eventos"] != null)
                    dgvClientes.Columns["Eventos"].Visible = false;



            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al cargar los datos en el DataGridView", ex);
            }
        }

        /// <summary>
        /// Registra un nuevo cliente en la base de datos.
        /// </summary>
        private void btnRegisterCliente_Click(object sender, EventArgs e)
        {
            string clientName = TxtClienteName.Text.Trim();
            string clientLastName = txtClienteLastName.Text.Trim();
            string phoneNumber = numTelefono.Text.Trim();
            string email = txtClienteEmail.Text.Trim();

            string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico) VALUES (@Nombre, @Apellido, @Telefono, @Correo)";

            try
            {
                using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", clientName);
                        cmd.Parameters.AddWithValue("@Apellido", clientLastName);
                        cmd.Parameters.AddWithValue("@Telefono", phoneNumber);
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ShowInfoMessage("Cliente añadido correctamente.");
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al añadir el cliente", ex);
            }
        }

        /// <summary>
        /// Carga los datos de una fila seleccionada en los campos de texto.
        /// </summary>
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                TxtClienteName.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtClienteLastName.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                numTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                txtClienteEmail.Text = row.Cells["CorreoElectronico"].Value?.ToString() ?? string.Empty;
            }
        }

        /// <summary>
        /// Actualiza los datos de un cliente seleccionado.
        /// </summary>
        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                ShowWarningMessage("Seleccione un cliente para actualizar.");
                return;
            }

            DataGridViewRow row = dgvClientes.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IdCliente"].Value);
            string clientName = TxtClienteName.Text.Trim();
            string clientLastName = txtClienteLastName.Text.Trim();
            string phoneNumber = numTelefono.Text.Trim();
            string email = txtClienteEmail.Text.Trim();

            string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo_electronico = @Correo WHERE Id_cliente = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", clientName);
                        cmd.Parameters.AddWithValue("@Apellido", clientLastName);
                        cmd.Parameters.AddWithValue("@Telefono", phoneNumber);
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ShowInfoMessage("Cliente actualizado correctamente.");
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al actualizar el cliente", ex);
            }
        }

        #region Helper Methods

        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
