using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para la asignación de roles a empleados en eventos.
    /// </summary>
    public partial class Asignacion_de_Empleados : Form
    {
        /// <summary>
        /// Constructor principal. Configura la posición de inicio del formulario y carga los datos necesarios.
        /// </summary>
        public Asignacion_de_Empleados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadComboBoxData();
            LoadEmpleadoRolesEventos();
            Utils.AgregarBordeInferiorConHover(
                Registerrol,
                Color.FromArgb(18, 29, 36),
                3,
                Color.FromArgb(10, 180, 180, 180),
                Color.Black
            );
        }

        /// <summary>
        /// Carga los datos en los ComboBox de eventos, empleados y roles desde la base de datos.
        /// </summary>
        private void LoadComboBoxData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cargar eventos
                    string queryEventos = "SELECT Id_evento, Detalles_adicionales FROM Eventos";
                    FillComboBox(connection, queryEventos, comboBoxEvento, "Id_evento", "Detalles_adicionales");

                    // Cargar empleados disponibles
                    string queryEmpleados = @"
                        SELECT Id_empleado, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto 
                        FROM Empleados 
                        WHERE Estado_Empleado = (SELECT Id_estado FROM Estado_Empleado WHERE Tipo_estado = 'Disponible')";
                    FillComboBox(connection, queryEmpleados, comboBoxEmpleado, "Id_empleado", "NombreCompleto");

                    // Cargar roles
                    string queryRoles = "SELECT Id_rol, Nombre_rol FROM Roles";
                    FillComboBox(connection, queryRoles, comboBoxRol, "Id_rol", "Nombre_rol");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error");
                }
            }
        }

        /// <summary>
        /// Llena un ComboBox con los datos obtenidos de una consulta SQL.
        /// </summary>
        /// <param name="connection">Conexión SQL abierta.</param>
        /// <param name="query">Consulta SQL para obtener los datos.</param>
        /// <param name="comboBox">ComboBox a llenar.</param>
        /// <param name="valueMember">Campo a usar como valor interno del ComboBox.</param>
        /// <param name="displayMember">Campo a mostrar en el ComboBox.</param>
        private void FillComboBox(SqlConnection connection, string query, ComboBox comboBox, string valueMember, string displayMember)
        {
            var adapter = new SqlDataAdapter(query, connection);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show($"No hay datos disponibles para llenar {comboBox.Name}.", "Advertencia");
            }
            else
            {
                comboBox.DataSource = dataTable;
                comboBox.ValueMember = valueMember;
                comboBox.DisplayMember = displayMember;
            }
        }

        /// <summary>
        /// Maneja el clic en el botón de registro de roles, asignando empleados a eventos y actualizando su estado.
        /// </summary>
        private void Registerrol_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar las entradas del usuario
                ValidateInputs();

                string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insertar datos en Rol_Empleado_Evento
                    string insertQuery = @"
                        INSERT INTO Rol_Empleado_Evento (Id_empleado, Id_evento, Id_rol)
                        VALUES (@IdEmpleado, @IdEvento, @IdRol)";
                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IdEmpleado", comboBoxEmpleado.SelectedValue);
                        command.Parameters.AddWithValue("@IdEvento", comboBoxEvento.SelectedValue);
                        command.Parameters.AddWithValue("@IdRol", comboBoxRol.SelectedValue);
                        command.ExecuteNonQuery();
                    }

                    // Actualizar estado del empleado
                    string updateStateQuery = @"
                        UPDATE Empleados
                        SET Estado_Empleado = (SELECT Id_estado FROM Estado_Empleado WHERE Tipo_estado = 'En evento')
                        WHERE Id_empleado = @IdEmpleado";
                    using (var command = new SqlCommand(updateStateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IdEmpleado", comboBoxEmpleado.SelectedValue);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Asignación registrada correctamente.", "Éxito");
                LoadEmpleadoRolesEventos(); // Refrescar datos
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Valida las entradas del usuario antes de realizar operaciones.
        /// </summary>
        private void ValidateInputs()
        {
            if (comboBoxEvento.SelectedValue == null)
                throw new ArgumentException("Seleccione un evento.");

            if (comboBoxEmpleado.SelectedValue == null)
                throw new ArgumentException("Seleccione un empleado.");

            if (comboBoxRol.SelectedValue == null)
                throw new ArgumentException("Seleccione un rol.");
        }

        /// <summary>
        /// Carga los datos de la tabla Rol_Empleado_Evento y los muestra en un DataGridView.
        /// </summary>
        private void LoadEmpleadoRolesEventos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            REE.Id_evento AS EventoID,
                            CONCAT(E.Nombre, ' ', E.Apellido) AS Empleado,
                            R.Nombre_rol AS Rol,
                            EV.Detalles_adicionales AS Evento
                        FROM Rol_Empleado_Evento REE
                        INNER JOIN Empleados E ON REE.Id_empleado = E.Id_empleado
                        INNER JOIN Roles R ON REE.Id_rol = R.Id_rol
                        INNER JOIN Eventos EV ON REE.Id_evento = EV.Id_evento";

                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvRolesEmpleados.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de roles: {ex.Message}", "Error");
                }
            }
        }

        /// <summary>
        /// Cierra el formulario cuando se hace clic en el botón de cierre de sesión.
        /// </summary>
        private void CierreSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
