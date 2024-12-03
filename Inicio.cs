using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Inicio : Form
    {
        private List<DateTime> fechasResaltadas;
        public Inicio()
        {
            InicializarFechas();
            InitializeComponent();
            ConfigurarMonthCalendar();
            ConfigurarToolTip();
            AgregarTextBoxesAFlowPanel(textos, flowLayoutPanelActvity);
            AgregarTextBoxesAFlowPanel(textos, flowLayoutPanelLog);


        }

        List<string> textos = new List<string>
        {
            "Evento 1",
            "Evento 2",
            "Evento 3",
            "Evento 4"
        };



        private void InicializarFechas()
        {
            // Simula fechas obtenidas de la base de datos
            fechasResaltadas = new List<DateTime>
            {
                new DateTime(2024, 12, 5),
                new DateTime(2024, 12, 12),
                new DateTime(2024, 12, 25),
                new DateTime(2025, 1, 1)
            };
        }

        private void ConfigurarMonthCalendar()
        {
           

            // Configura el MonthCalendar
            eventsCalendar.MaxSelectionCount = 1; // Deshabilita selecciones múltiples

            // Asocia el evento DateChanged para mostrar los días resaltados
            eventsCalendar.DateChanged += MonthCalendar1_DateChanged;

            // Llama al método para resaltar las fechas
            ResaltarFechas();
        }



        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Verifica si la fecha seleccionada está en la lista de fechas resaltadas
            if (fechasResaltadas.Contains(e.Start.Date))
            {
               
            }
        }

        private void ResaltarFechas()
        {
            // Itera sobre las fechas resaltadas y selecciona cada una de ellas
            foreach (var fecha in fechasResaltadas)
            {
                eventsCalendar.AddBoldedDate(fecha);
                // Marca las fechas como "bold"
            }

             // Actualiza el calendario con las fechas resaltadas
        }

        private ToolTip toolTip = new ToolTip();

        private void ConfigurarToolTip()
        {
            eventsCalendar.DateChanged += (s, e) =>
            {
                // Verifica si la fecha está en la lista
                if (fechasResaltadas.Contains(e.Start.Date))
                {
                    toolTip.SetToolTip(eventsCalendar, $"Evento especial en {e.Start.ToShortDateString()}");
                }
                else
                {
                    toolTip.SetToolTip(eventsCalendar, string.Empty);
                }
            };
        }

        private void AgregarTextBoxesAFlowPanel(List<string> textos, FlowLayoutPanel flowLayoutPanel)
        {
            // Limpiar el FlowLayoutPanel antes de agregar nuevos controles, si es necesario
            flowLayoutPanel.Controls.Clear();
            

            foreach (string texto in textos)
            {
                // Crear un nuevo TextBox
                TextBox textBox = new TextBox
                {
                    Text = texto, // Establece el texto del TextBox con el contenido de la lista
                    Width = 200, // Establece el ancho (puedes ajustar según necesites)
                    Margin = new Padding(5), // Espaciado entre los elementos en el FlowLayoutPanel
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.LightYellow,
                    ForeColor = Color.DarkBlue,


                };

                // Agregar el TextBox al FlowLayoutPanel

                flowLayoutPanel.Controls.Add(textBox);
                
            }
        }


    }
}
