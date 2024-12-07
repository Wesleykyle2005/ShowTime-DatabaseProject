using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
            LoadEventosData();
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            InformacionCliente informacionCliente = new InformacionCliente();
            informacionCliente.ShowDialog(this);
        }

        private void editEvent_Click(object sender, EventArgs e)
        {
            Asignacion_de_Empleados asignacion_De_Empleados = new Asignacion_de_Empleados();
            asignacion_De_Empleados.ShowDialog(this);
        }

        private void payEvent_Click(object sender, EventArgs e)
        {

        }


        private void LoadEventosData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos de los eventos
                    string query = @"
                SELECT 
                    e.Id_evento, 
                    p.Nombre_paquete AS Paquete, 
                    c.Nombre AS Cliente, 
                    e.Fecha_reserva, 
                    e.Fecha_inicio, 
                    e.Hora_inicio, 
                    e.Hora_fin, 
                    e.Cantidad_de_asistentes, 
                    e.Costo_total, 
                    e.Estado
                FROM 
                    Eventos e
                INNER JOIN 
                    Paquetes p ON e.Id_paquete = p.Id_paquete
                INNER JOIN 
                    Clientes c ON e.Id_cliente = c.Id_cliente
                ORDER BY 
                    e.Fecha_reserva DESC"; // Puedes ordenar como desees

                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dgvEventos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
