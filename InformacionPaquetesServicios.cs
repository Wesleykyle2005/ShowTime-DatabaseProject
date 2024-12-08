using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para seleccionar paquetes y servicios relacionados a un evento.
    /// </summary>
    public partial class InformacionPaquetesServicios : Form
    {
        private readonly EventoTemporal _eventoInfo;

        public InformacionPaquetesServicios(EventoTemporal evento)
        {
            InitializeComponent();
            _eventoInfo = evento;

            ConfigureUI();
            LoadPaquetesServicios();
        }


        

        /// <summary>
        /// Configura elementos visuales e inicializa eventos.
        /// </summary>
        private void ConfigureUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configurar bordes personalizados
            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(registerEvent, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, baseColor, 3, hoverColor, Color.Black);

            // Eventos para validación y cálculo
            txtMontoInicial.TextChanged += txtMontoInicial_TextChanged;
        }

        /// <summary>
        /// Maneja el evento del botón "Registrar Evento".
        /// </summary>
        private void registerEvent_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                SaveEventData();

                MessageBox.Show("Evento registrado exitosamente junto con el pago inicial.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Carga los paquetes y servicios desde la base de datos.
        /// </summary>
        private void LoadPaquetesServicios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Cargar datos en ListBox
                string paquetesQuery = "SELECT Id_paquete, Nombre_paquete AS Nombre, Costo FROM Paquetes WHERE Disponibilidad = 1";
                FillListBox(connection, paquetesQuery, listBoxPaquetes, "Id_paquete", "Nombre");

                string serviciosQuery = "SELECT Id_servicio, Nombre_servicio AS Nombre, Costo FROM Servicios";
                FillListBox(connection, serviciosQuery, listBoxServicios, "Id_servicio", "Nombre");
            }

            // Recalcular costo total al seleccionar opciones
            listBoxPaquetes.SelectedIndexChanged += (_, _) => CalculateTotalCost();
            listBoxServicios.SelectedIndexChanged += (_, _) => CalculateTotalCost();
        }

        /// <summary>
        /// Calcula y actualiza el costo total en base a los elementos seleccionados.
        /// </summary>
        private void CalculateTotalCost()
        {
            decimal totalCost = 0;

            // Sumar el costo del paquete seleccionado
            if (listBoxPaquetes.SelectedItem is DataRowView paquete)
            {
                totalCost += (decimal)paquete["Costo"];
            }

            // Sumar el costo de los servicios seleccionados
            foreach (DataRowView servicio in listBoxServicios.SelectedItems)
            {
                totalCost += (decimal)servicio["Costo"];
            }

            txtCostoTotal.Text = totalCost.ToString("F2");
        }

        /// <summary>
        /// Rellena un ListBox con datos de una consulta SQL.
        /// </summary>
        private void FillListBox(SqlConnection connection, string query, ListBox listBox, string valueMember, string displayMember)
        {
            var adapter = new SqlDataAdapter(query, connection);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            listBox.DataSource = dataTable;
            listBox.ValueMember = valueMember;
            listBox.DisplayMember = displayMember;
        }

        /// <summary>
        /// Valida las entradas del formulario.
        /// </summary>
        private void ValidateInputs()
        {
            // Validar paquetes seleccionados
            _eventoInfo.IdsPaquetes = listBoxPaquetes.SelectedItems
                .Cast<DataRowView>()
                .Select(row => (int)row["Id_paquete"])
                .ToList();

            if (_eventoInfo.IdsPaquetes.Count > 1)
            {
                throw new ArgumentException("Solo puedes seleccionar un paquete por evento.");
            }

            // Validar servicios seleccionados
            _eventoInfo.IdsServicios = listBoxServicios.SelectedItems
                .Cast<DataRowView>()
                .Select(row => (int)row["Id_servicio"])
                .ToList();

            // Validar montos
            if (!decimal.TryParse(txtMontoInicial.Text, out var montoInicial) || montoInicial <= 0)
                throw new ArgumentException("El monto inicial debe ser un número positivo.");

            if (!decimal.TryParse(txtCostoTotal.Text, out var costoTotal) || costoTotal <= 0)
                throw new ArgumentException("El costo total debe ser un número positivo.");

            if (montoInicial < (costoTotal * 0.5m))
                throw new ArgumentException("El monto inicial no puede ser menor al 50% del costo total.");

            if (montoInicial > costoTotal)
                throw new ArgumentException("El monto inicial no puede ser mayor al costo total.");

            _eventoInfo.MontoInicial = montoInicial;
            _eventoInfo.CostoTotal = costoTotal;
        }

        /// <summary>
        /// Muestra errores relacionados al monto inicial.
        /// </summary>
        private void txtMontoInicial_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoInicial.Text, out var montoInicial) &&
                decimal.TryParse(txtCostoTotal.Text, out var costoTotal))
            {
                if (montoInicial < (costoTotal * 0.5m))
                {
                    lblErrorMontoInicial.Text = "El monto inicial debe ser al menos el 50% del costo total.";
                    lblErrorMontoInicial.Visible = true;
                }
                else if (montoInicial > costoTotal)
                {
                    lblErrorMontoInicial.Text = "El monto inicial no puede superar el costo total.";
                    lblErrorMontoInicial.Visible = true;
                }
                else
                {
                    lblErrorMontoInicial.Visible = false;
                }
            }
            else
            {
                lblErrorMontoInicial.Visible = false;
            }
        }

        /// <summary>
        /// Guarda los datos del evento y sus relaciones en la base de datos.
        /// </summary>
        private void SaveEventData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int idCliente = InsertCliente(connection, transaction);
                        int idEvento = InsertEvento(connection, transaction, idCliente);
                        InsertEventoServicios(connection, transaction, idEvento);
                        InsertPago(connection, transaction, idEvento);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // Métodos para Insertar Cliente, Evento, Servicios y Pagos están iguales en lógica.
    

    private int InsertCliente(SqlConnection connection, SqlTransaction transaction)
        {
            var query = @"INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico) 
                          OUTPUT INSERTED.Id_cliente 
                          VALUES (@Nombre, @Apellido, @Telefono, @Correo)";
            var command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@Nombre", _eventoInfo.NombreCliente);
            command.Parameters.AddWithValue("@Apellido", _eventoInfo.ApellidoCliente);
            command.Parameters.AddWithValue("@Telefono", _eventoInfo.TelefonoCliente);
            command.Parameters.AddWithValue("@Correo", (object)_eventoInfo.CorreoCliente ?? DBNull.Value);

            return (int)command.ExecuteScalar();
        }

        private int InsertEvento(SqlConnection connection, SqlTransaction transaction, int idCliente)
        {
            string queryInsertEvento = @"
        INSERT INTO Eventos (Id_paquete, Id_cliente, Fecha_reserva, Fecha_inicio, Hora_inicio, Hora_fin, Ubicacion, Direccion, Cantidad_de_asistentes, Detalles_adicionales, Costo_total, Estado)
        VALUES (@IdPaquete, @IdCliente, @FechaReserva, @FechaInicio, @HoraInicio, @HoraFin, @Ubicacion, @Direccion, @CantidadAsistentes, @DetallesAdicionales, @CostoTotal, @Estado);
        SELECT SCOPE_IDENTITY();";

            var command = new SqlCommand(queryInsertEvento, connection, transaction);

            // Verifica si el usuario seleccionó un paquete
            if (_eventoInfo.IdsPaquetes.Any())
            {
                command.Parameters.AddWithValue("@IdPaquete", _eventoInfo.IdsPaquetes.First());
            }
            else
            {
                command.Parameters.AddWithValue("@IdPaquete", DBNull.Value); // No seleccionó paquete
            }

            command.Parameters.AddWithValue("@IdCliente", idCliente);
            command.Parameters.AddWithValue("@FechaReserva", _eventoInfo.FechaReserva);
            command.Parameters.AddWithValue("@FechaInicio", _eventoInfo.FechaInicio);
            command.Parameters.AddWithValue("@HoraInicio", _eventoInfo.HoraInicio);
            command.Parameters.AddWithValue("@HoraFin", _eventoInfo.HoraFin);
            command.Parameters.AddWithValue("@Ubicacion", _eventoInfo.Ubicacion);
            command.Parameters.AddWithValue("@Direccion", _eventoInfo.Direccion);
            command.Parameters.AddWithValue("@CantidadAsistentes", _eventoInfo.CantidadAsistentes);
            command.Parameters.AddWithValue("@DetallesAdicionales", (object)_eventoInfo.DetallesAdicionales ?? DBNull.Value);
            command.Parameters.AddWithValue("@CostoTotal", _eventoInfo.CostoTotal);
            command.Parameters.AddWithValue("@Estado", _eventoInfo.Estado);

            return Convert.ToInt32(command.ExecuteScalar());
        }


        private void InsertEventoServicios(SqlConnection connection, SqlTransaction transaction, int idEvento)
        {
            foreach (var idServicio in _eventoInfo.IdsServicios)
            {
                string query = "INSERT INTO Evento_Servicios (Id_evento, Id_servicio) VALUES (@IdEvento, @IdServicio)";
                using (var command = new SqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@IdEvento", idEvento);
                    command.Parameters.AddWithValue("@IdServicio", idServicio);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void InsertEventoServicio(SqlConnection connection, SqlTransaction transaction, int idEvento, int id, bool isPaquete)
        {
            string query = isPaquete
                ? "INSERT INTO Evento_Servicios (Id_evento, Id_paquete) VALUES (@IdEvento, @Id)"
                : "INSERT INTO Evento_Servicios (Id_evento, Id_servicio) VALUES (@IdEvento, @Id)";
            var command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@IdEvento", idEvento);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }

        private void InsertPago(SqlConnection connection, SqlTransaction transaction, int idEvento)
        {
            var query = "INSERT INTO Pagos (Id_evento, Monto, Fecha_pago, Metodo_pago) VALUES (@IdEvento, @Monto, @FechaPago, @MetodoPago)";
            var command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@IdEvento", idEvento);
            command.Parameters.AddWithValue("@Monto", _eventoInfo.MontoInicial);
            command.Parameters.AddWithValue("@FechaPago", DateTime.Now);
            command.Parameters.AddWithValue("@MetodoPago", "Inicial");
            command.ExecuteNonQuery();
        }

    }
}
