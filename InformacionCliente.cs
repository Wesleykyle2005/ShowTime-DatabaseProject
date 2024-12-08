using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para recopilar información del cliente antes de proceder con la creación del evento.
    /// </summary>
    public partial class InformacionCliente : Form
    {

        private readonly string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public InformacionCliente()
        {
            InitializeComponent();
            ConfigureUI();
            LoadClientesToDataGridView();
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        /// <summary>
        /// Configura los elementos de la interfaz de usuario, como bordes personalizados.
        /// </summary>
        private void ConfigureUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(continueButton, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, baseColor, 3, hoverColor, Color.Black);
        }

        /// <summary>
        /// Cierra el formulario cuando se presiona el botón de cerrar.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento del botón de continuar, validando los campos y pasando a la siguiente etapa.
        /// </summary>
        private void continueButton_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear instancia del evento temporal con los datos ingresados
            var eventoTemporal = new EventoTemporal
            {
                NombreCliente = txtNombre.Text.Trim(),
                ApellidoCliente = txtApellido.Text.Trim(),
                TelefonoCliente = txtTelefono.Text.Trim(),
                CorreoCliente = txtCorreo.Text.Trim() // Opcional
            };

            // Abrir formulario de detalles del evento
            try
            {
                using (var detalles = new DetallesDelEvento(eventoTemporal))
                {
                    detalles.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al continuar con el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que los campos obligatorios no estén vacíos.
        /// </summary>
        /// <returns>Verdadero si los campos son válidos; falso en caso contrario.</returns>
        private bool ValidateFields()
        {
            return !(string.IsNullOrWhiteSpace(txtNombre.Text) ||
                     string.IsNullOrWhiteSpace(txtApellido.Text) ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text));
        }



        private void LoadClientesToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    // Actualizamos la consulta para reflejar los campos correctos
                    string query = "SELECT Nombre, Apellido, Telefono, Correo_electronico FROM Clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvClientes.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que se ha seleccionado una fila válida
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Carga los datos de la fila seleccionada en los TextBox
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                txtCorreo.Text = row.Cells["Correo_electronico"].Value?.ToString() ?? string.Empty;
            }
        }

        
    }



}
