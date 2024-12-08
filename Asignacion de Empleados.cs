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
            LoadEventosData();

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
        /// Registra la asignación de un rol a un empleado para un evento seleccionado.
        /// </summary>
        private void InsertEmpleadoEvento()
        {
            try
            {
                // Validar que se haya seleccionado una fila
                if (dgvEventos.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar un evento.");

                // Obtener el Id_evento de la fila seleccionada
                var selectedRow = dgvEventos.SelectedRows[0];
                int idEvento = Convert.ToInt32(selectedRow.Cells["Id_evento"].Value);

                // Validar las entradas adicionales
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
                        command.Parameters.AddWithValue("@IdEvento", idEvento);
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
                LoadEventosData(); // Refrescar datos
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

            if (comboBoxEmpleado.SelectedValue == null)
                throw new ArgumentException("Seleccione un empleado.");

            if (comboBoxRol.SelectedValue == null)
                throw new ArgumentException("Seleccione un rol.");
        }



        /// <summary>
        /// Cierra el formulario cuando se hace clic en el botón de cierre de sesión.
        /// </summary>

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga los datos de eventos en el DataGridView junto con los empleados asignados.
        /// </summary>
        private void LoadEventosData()
        {
            const string query = @"
        SELECT 
            e.Id_evento, 
            c.Nombre AS Cliente, 
            e.Fecha_inicio, 
            e.Hora_inicio, 
            e.Hora_fin, 
            STRING_AGG(CONCAT(emp.Nombre, ' ', emp.Apellido), ', ') AS EmpleadosAsignados
        FROM 
            Eventos e
        INNER JOIN 
            Clientes c ON e.Id_cliente = c.Id_cliente
        LEFT JOIN 
            Rol_Empleado_Evento ree ON e.Id_evento = ree.Id_evento
        LEFT JOIN 
            Empleados emp ON ree.Id_empleado = emp.Id_empleado
        GROUP BY 
            e.Id_evento, c.Nombre, e.Fecha_inicio, e.Hora_inicio, e.Hora_fin
        ORDER BY 
            e.Fecha_inicio DESC";

            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvEventos.DataSource = dataTable;

                    // Ajustar nombres de columnas para mayor claridad
                    dgvEventos.Columns["Id_evento"].HeaderText = "ID Evento";
                    dgvEventos.Columns["Cliente"].HeaderText = "Cliente";
                    dgvEventos.Columns["Fecha_inicio"].HeaderText = "Fecha Inicio";
                    dgvEventos.Columns["Hora_inicio"].HeaderText = "Hora Inicio";
                    dgvEventos.Columns["Hora_fin"].HeaderText = "Hora Fin";
                    dgvEventos.Columns["EmpleadosAsignados"].HeaderText = "Empleados Asignados";

                    // Ocultar columnas sensibles si es necesario
                    if (dgvEventos.Columns["Id_evento"] != null)
                        dgvEventos.Columns["Id_evento"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los eventos: {ex.Message}", "Error");
            }
        }


        private void Registerrol_Click(object sender, EventArgs e)
        {
            InsertEmpleadoEvento();
        }
    }
}
