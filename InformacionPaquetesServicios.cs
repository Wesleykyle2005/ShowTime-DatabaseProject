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
    public partial class InformacionPaquetesServicios : Form
    {
        public EventoTemporal eventoInfo;

        public InformacionPaquetesServicios(EventoTemporal evento)
        {
            InitializeComponent();
            eventoInfo = evento;
            
            txtMontoInicial.TextChanged += txtMontoInicial_TextChanged; // Vincula el evento de validación
            LoadPaquetesServicios(); // Carga datos al inicializar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Evento para el botón de registro
        private void registerEvent_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs(); // Valida los datos de entrada

                SaveEventData(); // Guarda los datos en la base de datos

                MessageBox.Show("Evento registrado exitosamente, junto con el pago inicial.", "Éxito");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // Carga los paquetes y servicios desde la base de datos
        private void LoadPaquetesServicios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Cargar paquetes
                var queryPaquetes = "SELECT Id_paquete, Nombre_paquete AS Nombre, Costo FROM Paquetes WHERE Disponibilidad = 1";
                FillListBox(connection, queryPaquetes, listBoxPaquetes, "Id_paquete", "Nombre");

                // Cargar servicios
                var queryServicios = "SELECT Id_servicio, Nombre_servicio AS Nombre, Costo FROM Servicios";
                FillListBox(connection, queryServicios, listBoxServicios, "Id_servicio", "Nombre");
            }

            // Eventos para recalcular el costo total
            listBoxPaquetes.SelectedIndexChanged += (_, _) => CalculateTotalCost();
            listBoxServicios.SelectedIndexChanged += (_, _) => CalculateTotalCost();
        }


        private void CalculateTotalCost()
        {
            decimal totalCost = 0;

            // Sumar el costo del paquete seleccionado
            if (listBoxPaquetes.SelectedItem is DataRowView selectedPaquete)
            {
                totalCost += (decimal)selectedPaquete["Costo"];
            }

            // Sumar el costo de los servicios seleccionados
            foreach (DataRowView selectedServicio in listBoxServicios.SelectedItems)
            {
                totalCost += (decimal)selectedServicio["Costo"];
            }

            // Actualizar el TextBox de costo total
            txtCostoTotal.Text = totalCost.ToString("F2");
        }


        private void FillListBox(SqlConnection connection, string query, ListBox listBox, string valueMember, string displayMember)
        {
            var adapter = new SqlDataAdapter(query, connection);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            listBox.DataSource = dataTable;
            listBox.ValueMember = valueMember;
            listBox.DisplayMember = displayMember;
        }

        private void ValidateInputs()
        {
            // Validar selección de paquetes y servicios
            eventoInfo.IdsPaquetes = listBoxPaquetes.SelectedItems
                .Cast<DataRowView>()
                .Select(row => (int)row["Id_paquete"])
                .ToList();

            if (eventoInfo.IdsPaquetes.Count > 1)
            {
                throw new ArgumentException("Solo puedes seleccionar un paquete por evento.");
            }

            eventoInfo.IdsServicios = listBoxServicios.SelectedItems
                .Cast<DataRowView>()
                .Select(row => (int)row["Id_servicio"])
                .ToList();

            // Validar monto inicial y costo total
            if (!decimal.TryParse(txtMontoInicial.Text, out var montoInicial) || montoInicial <= 0)
                throw new ArgumentException("El monto inicial debe ser un número positivo.");

            if (!decimal.TryParse(txtCostoTotal.Text, out var costoTotal) || costoTotal <= 0)
                throw new ArgumentException("El costo total debe ser un número positivo.");

            if (montoInicial < (costoTotal * 0.5m))
                throw new ArgumentException("El monto inicial no puede ser menor al 50% del costo total.");

            if (montoInicial > costoTotal)
                throw new ArgumentException("El monto inicial no puede ser mayor al costo total.");

            eventoInfo.MontoInicial = montoInicial;
            eventoInfo.CostoTotal = costoTotal;
        }

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
                lblErrorMontoInicial.Visible = false; // Oculta errores si no hay datos válidos
            }
        }

        



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

        private int InsertCliente(SqlConnection connection, SqlTransaction transaction)
        {
            var query = @"INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico) 
                          OUTPUT INSERTED.Id_cliente 
                          VALUES (@Nombre, @Apellido, @Telefono, @Correo)";
            var command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@Nombre", eventoInfo.NombreCliente);
            command.Parameters.AddWithValue("@Apellido", eventoInfo.ApellidoCliente);
            command.Parameters.AddWithValue("@Telefono", eventoInfo.TelefonoCliente);
            command.Parameters.AddWithValue("@Correo", (object)eventoInfo.CorreoCliente ?? DBNull.Value);

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
            if (eventoInfo.IdsPaquetes.Any())
            {
                command.Parameters.AddWithValue("@IdPaquete", eventoInfo.IdsPaquetes.First());
            }
            else
            {
                command.Parameters.AddWithValue("@IdPaquete", DBNull.Value); // No seleccionó paquete
            }

            command.Parameters.AddWithValue("@IdCliente", idCliente);
            command.Parameters.AddWithValue("@FechaReserva", eventoInfo.FechaReserva);
            command.Parameters.AddWithValue("@FechaInicio", eventoInfo.FechaInicio);
            command.Parameters.AddWithValue("@HoraInicio", eventoInfo.HoraInicio);
            command.Parameters.AddWithValue("@HoraFin", eventoInfo.HoraFin);
            command.Parameters.AddWithValue("@Ubicacion", eventoInfo.Ubicacion);
            command.Parameters.AddWithValue("@Direccion", eventoInfo.Direccion);
            command.Parameters.AddWithValue("@CantidadAsistentes", eventoInfo.CantidadAsistentes);
            command.Parameters.AddWithValue("@DetallesAdicionales", (object)eventoInfo.DetallesAdicionales ?? DBNull.Value);
            command.Parameters.AddWithValue("@CostoTotal", eventoInfo.CostoTotal);
            command.Parameters.AddWithValue("@Estado", eventoInfo.Estado);

            return Convert.ToInt32(command.ExecuteScalar());
        }


        private void InsertEventoServicios(SqlConnection connection, SqlTransaction transaction, int idEvento)
        {
            foreach (var idServicio in eventoInfo.IdsServicios)
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
            command.Parameters.AddWithValue("@Monto", eventoInfo.MontoInicial);
            command.Parameters.AddWithValue("@FechaPago", DateTime.Now);
            command.Parameters.AddWithValue("@MetodoPago", "Inicial");
            command.ExecuteNonQuery();
        }

    }
}
