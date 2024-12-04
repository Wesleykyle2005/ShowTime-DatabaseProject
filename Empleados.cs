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

        private string connectionString = "Server=.; Database=DB_TeamSmile_ShowInfantil; Integrated Security=True; TrustServerCertificate=True";

        public Empleados()
        {
            InitializeComponent();
            //CargarEmpleados();
            LoadDataToDataGridView();
            Utils.AgregarBordeInferiorConHover(btnRegisterEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnDeleteEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnFiltlerEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);

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
            MessageBox.Show("Empleado añadido correctamente");

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

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                TxtEmployeeName.Text = row.Cells["Nombre"].Value.ToString();
                txtEmployeeLastName.Text = row.Cells["Apellido"].Value.ToString();
                txtEmployeeNumber.Text = row.Cells["Telefono"].Value.ToString();
                txtEmployeeEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvEmployees.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["IdEmpleado"].Value);

                    string query = @"UPDATE Empleados
                         SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email
                         WHERE Id_empleado = @Id";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empleado actualizado correctamente.");
                    LoadDataToDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar Empleado: " + ex.Message);
                }
            }
        }
    }
}
