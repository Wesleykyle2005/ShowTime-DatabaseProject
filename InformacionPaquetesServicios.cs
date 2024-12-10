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
        /// Configura eventos y límites iniciales para controles.
        /// </summary>
        private void ConfigureUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configurar bordes personalizados
            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(registerEvent, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, baseColor, 3, hoverColor, Color.Black);

            // Configurar el NumericUpDown
            numMontoInicial.DecimalPlaces = 2;
            numMontoInicial.Minimum = 0;
            numMontoInicial.Maximum = 1000000; // Valor alto inicial, ajustado dinámicamente en CalculateTotalCost

            // Eventos para cálculo
            txtCostoTotal.TextChanged += (_, _) => CalculateTotalCost();
           
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

                MessageBox.Show("Evento registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public event Action OnCloseRequested;

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
            try
            {
                decimal totalCost = 0;

                // Sumar el costo del paquete seleccionado
                if (listBoxPaquetes.SelectedItem is DataRowView paquete)
                {
                    if (paquete["Costo"] is decimal costoPaquete)
                    {
                        totalCost += costoPaquete;
                    }
                    else
                    {
                        throw new InvalidCastException("El costo del paquete no es un valor decimal.");
                    }
                }

                // Sumar el costo de los servicios seleccionados
                foreach (DataRowView servicio in listBoxServicios.SelectedItems)
                {
                    if (servicio["Costo"] is decimal costoServicio)
                    {
                        totalCost += costoServicio;
                    }
                    else
                    {
                        throw new InvalidCastException("El costo del servicio no es un valor decimal.");
                    }
                }

                txtCostoTotal.Text = totalCost.ToString("F2");

                // Configurar el rango del NumericUpDown
                numMontoInicial.Maximum = totalCost;
                numMontoInicial.Value = Math.Min(numMontoInicial.Value, totalCost);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculando el costo total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            decimal montoInicial = numMontoInicial.Value;

            _eventoInfo.CostoTotal = decimal.Parse(txtCostoTotal.Text);


            _eventoInfo.MontoInicial = montoInicial;
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

                        // Solo insertar el pago inicial si el monto es mayor a 0
                        if (_eventoInfo.MontoInicial > 0)
                        {
                            InsertPago(connection, transaction, idEvento);
                        }

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
            // Consulta para verificar si el cliente ya existe
            var checkQuery = @"SELECT Id_cliente 
                       FROM Clientes 
                       WHERE  
                          Telefono = @Telefono 
                         AND Correo_electronico = @Correo";

            // Creamos el comando para verificar la existencia
            var checkCommand = new SqlCommand(checkQuery, connection, transaction);
            
            checkCommand.Parameters.AddWithValue("@Telefono", _eventoInfo.TelefonoCliente);
            checkCommand.Parameters.AddWithValue("@Correo", (object)_eventoInfo.CorreoCliente ?? DBNull.Value);

            // Ejecutamos la consulta y verificamos si el cliente ya existe
            var existingClientId = checkCommand.ExecuteScalar();
            if (existingClientId != null)
            {
                // Si el cliente ya existe, devolvemos el Id_cliente del cliente existente
                return (int)existingClientId;
            }

            // Si el cliente no existe, lo insertamos
            var insertQuery = @"INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico) 
                        OUTPUT INSERTED.Id_cliente 
                        VALUES (@Nombre, @Apellido, @Telefono, @Correo)";

            var insertCommand = new SqlCommand(insertQuery, connection, transaction);
            insertCommand.Parameters.AddWithValue("@Nombre", _eventoInfo.NombreCliente);
            insertCommand.Parameters.AddWithValue("@Apellido", _eventoInfo.ApellidoCliente);
            insertCommand.Parameters.AddWithValue("@Telefono", _eventoInfo.TelefonoCliente);
            insertCommand.Parameters.AddWithValue("@Correo", (object)_eventoInfo.CorreoCliente ?? DBNull.Value);

            // Ejecutamos el insert y devolvemos el Id_cliente insertado
            return (int)insertCommand.ExecuteScalar();
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
