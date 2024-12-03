using Microsoft.Data.SqlClient;
using ShowTime_DatabseProject.Models;
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
    public partial class Empleados : Form
    {

        private string connectionString = "Server=SILVIA\\SQLEXPRESS; Database=DB_TeamSmile_ShowInfantil; Integrated Security=True; TrustServerCertificate=True";

        public Empleados()
        {
            InitializeComponent();
            //CargarEmpleados();
            LoadDataToDataGridView();
        }

        /*public void CargarEmpleados()
        {
            try
            {
                string query = @"SELECT * FROM Empleados";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvEmployees.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }*/

        public IEnumerable<Empleado> GetAll()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Empleados", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["Id_empleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            empleados.Add(empleado);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al obtener la utileria: {ex.Message}");
            }
            return empleados;
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                var empleados = GetAll();
                dgvEmployees.DataSource = empleados.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterEmployee_Click_1(object sender, EventArgs e)
        {

            string employeeName = TxtEmployeeName.Text;
            string employeeLastName = txtEmployeeLastName.Text;
            string employeeEmail = txtEmployeeEmail.Text;
            int employeeNumber = int.Parse(txtEmployeeNumber.Text);
            /*string employeeUser = txtUser.Text;
            string employeePassword = txtPassword.Text;*/

            string queryInsert = "INSERT INTO Empleados (Nombre, Apellido, Telefono, Email) VALUES (@Nombre, @Apellido, @Telefono, @Email)";
            MessageBox.Show("Cuenta añadida correctamente");

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@Nombre", employeeName);
                    cmd.Parameters.AddWithValue("@Apellido", employeeLastName);
                    cmd.Parameters.AddWithValue("@Telefono", employeeNumber);
                    cmd.Parameters.AddWithValue("@Email", employeeEmail);

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
    }
}
