using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Asignacion_de_Empleados : Form
    {
        public Asignacion_de_Empleados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadComboBoxData();
            LoadEmpleadoRolesEventos(); // Refrescar los datos en el DataGridView

        }

        private void LoadComboBoxData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Llenar comboBoxEvento
                    string queryEventos = "SELECT Id_evento, Detalles_adicionales FROM Eventos";
                    FillComboBox(connection, queryEventos, comboBoxEvento, "Id_evento", "Detalles_adicionales");

                    // Llenar comboBoxEmpleado
                    string queryEmpleados = @"
                        SELECT Id_empleado, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto 
                        FROM Empleados 
                        WHERE Estado_Empleado = (SELECT Id_estado FROM Estado_Empleado WHERE Tipo_estado = 'Disponible')";
                    FillComboBox(connection, queryEmpleados, comboBoxEmpleado, "Id_empleado", "NombreCompleto");

                    // Llenar comboBoxRol
                    string queryRoles = "SELECT Id_rol, Nombre_rol FROM Roles";
                    FillComboBox(connection, queryRoles, comboBoxRol, "Id_rol", "Nombre_rol");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error");
                }
            }
        }

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

        private void Registerrol_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                ValidateInputs();

                string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insertar en la tabla Rol_Empleado_Evento
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

                    // Actualizar estado del empleado a 'En evento'
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
                LoadEmpleadoRolesEventos(); // Refrescar los datos en el DataGridView
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

        private void ValidateInputs()
        {
            if (comboBoxEvento.SelectedValue == null)
                throw new ArgumentException("Seleccione un evento.");

            if (comboBoxEmpleado.SelectedValue == null)
                throw new ArgumentException("Seleccione un empleado.");

            if (comboBoxRol.SelectedValue == null)
                throw new ArgumentException("Seleccione un rol.");
        }

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

        private void Asignacion_de_Empleados_Load(object sender, EventArgs e)
        {
            LoadEmpleadoRolesEventos(); // Cargar datos al abrir el formulario
        }

        private void CierreSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
