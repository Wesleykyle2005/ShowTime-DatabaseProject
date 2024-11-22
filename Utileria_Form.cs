using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShowTime_DatabseProject.Modelos;


namespace ShowTime_DatabseProject
{
    public partial class Utileria_Form : Form
    {
        string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;
        public Utileria_Form()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        public IEnumerable<Utileria> GetAll() {
        List<Utileria> utilerias = new List<Utileria>();
            try
            {
                using (SqlConnection connection= new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Utileria", connection);
                    using (SqlDataReader reader = command.ExecuteReader() )
                    {
                        while (reader.Read())
                        {
                            Utileria utileria = new Utileria
                            {
                                Id_utileria = Convert.ToInt32(reader["Id_utileria"]),
                                Nombre = reader["Nombre"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"])
                            };
                            utilerias.Add(utileria);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al obtener la utileria: {ex.Message}");
            }
            return utilerias;
        }

        private void LoadDataToDataGridView()
        {
            try
            {            
                var utilerias = GetAll();               
                dgvUtileria.DataSource = utilerias.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
