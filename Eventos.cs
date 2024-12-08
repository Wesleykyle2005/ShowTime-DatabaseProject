using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para la gestión de eventos.
    /// </summary>
    public partial class Eventos : Form
    {
        /// <summary>
        /// Cadena de conexión a la base de datos, obtenida del archivo de configuración.
        /// </summary>
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Eventos()
        {
            InitializeComponent();
            ConfigureUI();
            LoadEventosData();
        }

        /// <summary>
        /// Configura los elementos de la interfaz de usuario.
        /// </summary>
        private void ConfigureUI()
        {


            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(registerEvent, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(btnAsignarEmpleado, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(btnRealizarPago, baseColor, 3, hoverColor, Color.Black);
        }

        /// <summary>
        /// Carga los datos de los eventos desde la base de datos al DataGridView.
        /// </summary>
        private void LoadEventosData()
        {
            const string query = @"
                SELECT 
    e.Id_evento, 
    c.Nombre AS Cliente, 
    e.Fecha_reserva AS 'Reservado', 
    e.Fecha_inicio AS 'Inicio', 
    e.Hora_inicio AS 'Hora de inicio', 
    e.Hora_fin AS 'Hora final', 
    e.Cantidad_de_asistentes AS 'Asistentes', 
    e.Costo_total AS 'Costo', 
    p.Nombre_paquete AS Paquete, 
    COALESCE(STRING_AGG(s.Nombre_servicio, ', '), 'sin servicios') AS 'Servicios',  -- Reemplaza NULL con 'sin servicios'
    e.Estado
FROM 
    Eventos e
INNER JOIN 
    Paquetes p ON e.Id_paquete = p.Id_paquete
INNER JOIN 
    Clientes c ON e.Id_cliente = c.Id_cliente
LEFT JOIN 
    Evento_Servicios es ON e.Id_evento = es.Id_evento
LEFT JOIN 
    Servicios s ON es.Id_servicio = s.Id_servicio
GROUP BY
    e.Id_evento, c.Nombre, e.Fecha_reserva, e.Fecha_inicio, e.Hora_inicio, e.Hora_fin, 
    e.Cantidad_de_asistentes, e.Costo_total, p.Nombre_paquete, e.Estado
ORDER BY 
    e.Fecha_reserva DESC

";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dgvEventos.DataSource = dataTable;

                    if (dgvEventos.Columns["Id_evento"] != null)
                    {
                        dgvEventos.Columns["Id_evento"].Visible = false;
                    }

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el formulario de información del cliente al registrar un evento.
        /// </summary>
        private void registerEvent_Click(object sender, EventArgs e)
        {
            try
            {
                using (var informacionCliente = new InformacionCliente())
                {
                    informacionCliente.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar un evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el formulario para la asignación de empleados a un evento.
        /// </summary>
        private void editEvent_Click(object sender, EventArgs e)
        {
            try
            {
                using (var asignacionDeEmpleados = new Asignacion_de_Empleados())
                {
                    asignacionDeEmpleados.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el pago de un evento. (Pendiente de implementación)
        /// </summary>
        private void payEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de pago aún no implementada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                using (var registrarPagosDeEventos = new RegistrarPagosDeEventos())
                {
                    registrarPagosDeEventos.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar un evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
