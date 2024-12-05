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
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            eventoInfo.IdsPaquetes = listBoxPaquetes.SelectedItems.Cast<int>().ToList();
            eventoInfo.IdsServicios = listBoxServicios.SelectedItems.Cast<int>().ToList();
            eventoInfo.MontoInicial = decimal.Parse(txtMontoInicial.Text);
            eventoInfo.CostoTotal = decimal.Parse(txtCostoTotal.Text);




            //De aqui ba abajo



            string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(sqlServerConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar cliente
                        var queryCliente = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico) " +
                                           "OUTPUT INSERTED.Id_cliente VALUES (@Nombre, @Apellido, @Telefono, @Correo)";
                        var cmdCliente = new SqlCommand(queryCliente, connection, transaction);
                        cmdCliente.Parameters.AddWithValue("@Nombre", eventoInfo.NombreCliente);
                        cmdCliente.Parameters.AddWithValue("@Apellido", eventoInfo.ApellidoCliente);
                        cmdCliente.Parameters.AddWithValue("@Telefono", eventoInfo.TelefonoCliente);
                        cmdCliente.Parameters.AddWithValue("@Correo", eventoInfo.CorreoCliente ?? (object)DBNull.Value);
                        var idCliente = (int)cmdCliente.ExecuteScalar();

                        // Insertar evento
                        var queryEvento = "INSERT INTO Eventos (Id_cliente, Fecha_reserva, Fecha_inicio, Hora_inicio, Hora_fin, Ubicacion, Direccion, Cantidad_de_asistentes, Detalles_adicionales, Costo_total, Estado) " +
                                          "OUTPUT INSERTED.Id_evento VALUES (@IdCliente, @FechaReserva, @FechaInicio, @HoraInicio, @HoraFin, @Ubicacion, @Direccion, @CantidadAsistentes, @Detalles, @Costo, @Estado)";
                        var cmdEvento = new SqlCommand(queryEvento, connection, transaction);
                        cmdEvento.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmdEvento.Parameters.AddWithValue("@FechaReserva", eventoInfo.FechaReserva);
                        cmdEvento.Parameters.AddWithValue("@FechaInicio", eventoInfo.FechaInicio);
                        cmdEvento.Parameters.AddWithValue("@HoraInicio", eventoInfo.HoraInicio);
                        cmdEvento.Parameters.AddWithValue("@HoraFin", eventoInfo.HoraFin);
                        cmdEvento.Parameters.AddWithValue("@Ubicacion", eventoInfo.Ubicacion);
                        cmdEvento.Parameters.AddWithValue("@Direccion", eventoInfo.Direccion);
                        cmdEvento.Parameters.AddWithValue("@CantidadAsistentes", eventoInfo.CantidadAsistentes);
                        cmdEvento.Parameters.AddWithValue("@Detalles", eventoInfo.DetallesAdicionales ?? (object)DBNull.Value);
                        cmdEvento.Parameters.AddWithValue("@Costo", eventoInfo.CostoTotal);
                        cmdEvento.Parameters.AddWithValue("@Estado", eventoInfo.Estado);
                        var idEvento = (int)cmdEvento.ExecuteScalar();

                        // Insertar paquetes
                        foreach (var idPaquete in eventoInfo.IdsPaquetes)
                        {
                            var queryPaquete = "INSERT INTO Evento_Servicios (Id_evento, Id_paquete) VALUES (@IdEvento, @IdPaquete)";
                            var cmdPaquete = new SqlCommand(queryPaquete, connection, transaction);
                            cmdPaquete.Parameters.AddWithValue("@IdEvento", idEvento);
                            cmdPaquete.Parameters.AddWithValue("@IdPaquete", idPaquete);
                            cmdPaquete.ExecuteNonQuery();
                        }

                        // Insertar servicios
                        foreach (var idServicio in eventoInfo.IdsServicios)
                        {
                            var queryServicio = "INSERT INTO Evento_Servicios (Id_evento, Id_servicio) VALUES (@IdEvento, @IdServicio)";
                            var cmdServicio = new SqlCommand(queryServicio, connection, transaction);
                            cmdServicio.Parameters.AddWithValue("@IdEvento", idEvento);
                            cmdServicio.Parameters.AddWithValue("@IdServicio", idServicio);
                            cmdServicio.ExecuteNonQuery();
                        }

                        // Insertar pago inicial
                        var queryPago = "INSERT INTO Pagos (Id_evento, Monto, Fecha_pago, Metodo_pago) VALUES (@IdEvento, @Monto, @FechaPago, @MetodoPago)";
                        var cmdPago = new SqlCommand(queryPago, connection, transaction);
                        cmdPago.Parameters.AddWithValue("@IdEvento", idEvento);
                        cmdPago.Parameters.AddWithValue("@Monto", eventoInfo.MontoInicial);
                        cmdPago.Parameters.AddWithValue("@FechaPago", DateTime.Now);
                        cmdPago.Parameters.AddWithValue("@MetodoPago", "Inicial"); 
                        cmdPago.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Evento registrado exitosamente, junto con el pago inicial.", "Éxito");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
