using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Inicio : Form
    {
        private List<EventoInfo> eventosProximos;

        public Inicio()
        {
            InitializeComponent();
            InicializarEventosDesdeBD();
            ConfigurarMonthCalendar();
            AgregarTextBoxesAFlowPanel(eventosProximos, flowLayoutPanelActvity);
        }

        private class EventoInfo
        {
            public DateTime Fecha { get; set; }
            public string Descripcion { get; set; }
            public int CantidadInvitados { get; set; }
        }

        private void InicializarEventosDesdeBD()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;
            eventosProximos = new List<EventoInfo>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        Fecha_inicio AS Fecha,
                        Detalles_adicionales AS Descripcion,
                        Cantidad_de_asistentes AS CantidadInvitados
                    FROM Eventos
                    WHERE Fecha_inicio >= GETDATE()"; // Solo obtén eventos futuros

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

        private void ConfigurarMonthCalendar()
        {
            eventsCalendar.MaxSelectionCount = 1; // Deshabilita selecciones múltiples
            eventsCalendar.DateChanged += MonthCalendar1_DateChanged;
            ResaltarFechas();
        }

        private void ResaltarFechas()
        {
            foreach (var evento in eventosProximos)
            {
                eventsCalendar.AddBoldedDate(evento.Fecha);
            }

            
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var eventosDelDia = eventosProximos
                .Where(ev => ev.Fecha.Date == e.Start.Date)
                .ToList();

            if (eventosDelDia.Any())
            {
                string detalles = string.Join(Environment.NewLine, eventosDelDia.Select(ev =>
                    $"{ev.Fecha.ToShortDateString()}: {ev.Descripcion} ({ev.CantidadInvitados} invitados)"));

                MessageBox.Show(detalles, "Eventos del Día");
            }
        }

        private void AgregarTextBoxesAFlowPanel(List<EventoInfo> eventos, FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var evento in eventos)
            {
                TextBox textBox = new TextBox
                {
                    Text = $"{evento.Fecha.ToShortDateString()} - {evento.Descripcion} ({evento.CantidadInvitados} invitados)",
                    Width = 300,
                    Margin = new Padding(5),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    BackColor = Color.LightYellow,
                    ForeColor = Color.DarkBlue,
                    ReadOnly = true // Hacer que los TextBox sean de solo lectura
                };

                flowLayoutPanel.Controls.Add(textBox);
            }
        }
    }
}
