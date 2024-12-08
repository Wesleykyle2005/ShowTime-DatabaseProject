using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShowTime_DatabseProject.Models;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario principal que muestra los eventos futuros, resalta las fechas en un calendario 
    /// y lista los detalles en un panel interactivo.
    /// </summary>
    public partial class Inicio : Form
    {
        /// <summary>
        /// Lista que almacena información de los eventos futuros.
        /// </summary>
        private List<EventoInfo> eventosProximos;

        /// <summary>
        /// Inicializa el formulario, cargando eventos desde la base de datos y configurando la interfaz gráfica.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            InicializarEventosDesdeBD();
            ConfigurarMonthCalendar();
            AgregarTextBoxesAFlowPanel(eventosProximos, flowLayoutPanelActvity);
        }

        /// <summary>
        /// Clase que representa la información básica de un evento.
        /// </summary>
        

        /// <summary>
        /// Carga los eventos futuros desde la base de datos y los almacena en una lista.
        /// </summary>
        private void InicializarEventosDesdeBD()
        {
            // Recupera la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;
            eventosProximos = new List<EventoInfo>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            Fecha_inicio AS Fecha,
                            Detalles_adicionales AS Descripcion,
                            Cantidad_de_asistentes AS CantidadInvitados
                        FROM Eventos
                        WHERE Fecha_inicio >= GETDATE()
                        ORDER BY Fecha_inicio ASC
                           "; // Solo eventos futuros

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eventosProximos.Add(new EventoInfo
                            {
                                Fecha = reader.GetDateTime(0),
                                Descripcion = reader.IsDBNull(1) ? "Sin descripción" : reader.GetString(1),
                                CantidadInvitados = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura las propiedades del calendario, permitiendo destacar las fechas de los eventos.
        /// </summary>
        private void ConfigurarMonthCalendar()
        {
            eventsCalendar.MaxSelectionCount = 1; // Deshabilita selecciones múltiples
            eventsCalendar.DateChanged += MonthCalendar1_DateChanged; // Evento al cambiar de fecha
            ResaltarFechas();
        }

        /// <summary>
        /// Resalta las fechas del calendario que corresponden a eventos futuros.
        /// </summary>
        private void ResaltarFechas()
        {
            foreach (var evento in eventosProximos)
            {
                eventsCalendar.AddBoldedDate(evento.Fecha);
            }

            
        }

        /// <summary>
        /// Maneja el evento de cambio de fecha en el calendario, mostrando eventos del día seleccionado.
        /// </summary>
        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Filtra eventos que coincidan con la fecha seleccionada
            var eventosDelDia = eventosProximos
                .Where(ev => ev.Fecha.Date == e.Start.Date)
                .ToList();

            if (eventosDelDia.Any())
            {
                // Construye un mensaje con los detalles de los eventos del día
                string detalles = string.Join(Environment.NewLine, eventosDelDia.Select(ev =>
                    $"{ev.Fecha.ToShortDateString()}: {ev.Descripcion} ({ev.CantidadInvitados} invitados)"));

                MessageBox.Show(detalles, "Eventos del Día", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Muestra los eventos hasta dentro de un mes en un panel fluido, añadiendo un cuadro de texto para cada evento.
        /// </summary>
        private void AgregarTextBoxesAFlowPanel(List<EventoInfo> eventos, FlowLayoutPanel flowLayoutPanel)
        {
            // Limpia el panel antes de agregar nuevos elementos
            flowLayoutPanel.Controls.Clear();

            // Filtrar eventos dentro del próximo mes
            DateTime hoy = DateTime.Now;
            DateTime dentroDeUnMes = hoy.AddMonths(1);

            var eventosFiltrados = eventos
                .Where(e => e.Fecha >= hoy && e.Fecha < dentroDeUnMes)
                .OrderBy(e => e.Fecha) // Ordenar por fecha de inicio
                .ToList();

            foreach (var evento in eventosFiltrados)
            {
                // Crea un TextBox para representar los detalles del evento
                TextBox textBox = new TextBox
                {
                    Text = $"{evento.Fecha.ToShortDateString()} - {evento.Descripcion} ({evento.CantidadInvitados} invitados)",
                    Width = 300,
                    Margin = new Padding(5),
                    Font = new Font("Courier New", 10, FontStyle.Bold),
                    BackColor = Color.FromArgb(150, 150, 150),
                    ForeColor = Color.Black,
                    BorderStyle = BorderStyle.None,
                    Height = 50,
                    Multiline = true,
                    ReadOnly = true // Hacer que los TextBox sean de solo lectura
                };

                flowLayoutPanel.Controls.Add(textBox);
            }
        }

    }
}
