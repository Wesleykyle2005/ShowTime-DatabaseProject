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
using ShowTime_DatabseProject.Models;


namespace ShowTime_DatabseProject
{
    public partial class Utileria_Form : Form
    {
        string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        private string connectionString = "Server=SILVIA\\SQLEXPRESS; Database=DB_TeamSmile_ShowInfantil; Integrated Security=True; TrustServerCertificate=True";

        public Utileria_Form()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        public IEnumerable<Utileria> GetAll()
        {
            List<Utileria> utilerias = new List<Utileria>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Utileria", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Utileria utileria = new Utileria
                            {
                                IdUtileria = Convert.ToInt32(reader["Id_utileria"]),
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

        private void btnRegisterProp_Click(object sender, EventArgs e)
        {

            string propName = txtPropName.Text;
            string propQuantity = txtPropQuantity.Text;

            string queryInsert = "INSERT INTO Utileria (Nombre, Cantidad) VALUES (@Nombre, @Cantidad)";
            MessageBox.Show("Utileria añadida correctamente");

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@Nombre", propName);
                    cmd.Parameters.AddWithValue("@Cantidad", propQuantity);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    LoadDataToDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvUtileria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUtileria.Rows[e.RowIndex];
                txtPropName.Text = row.Cells["Nombre"].Value.ToString();
                txtPropQuantity.Text = row.Cells["Cantidad"].Value.ToString();
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (dgvUtileria.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvUtileria.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["IdUtileria"].Value);

                    string query = @"UPDATE Utileria
                         SET Nombre = @Nombre, Cantidad = @Cantidad
                         WHERE Id_utileria = @Id";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", txtPropName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cantidad", txtPropQuantity.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Utileria actualizada correctamente.");
                    LoadDataToDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la Utileria: " + ex.Message);
                }
            }
        }
    }
}
