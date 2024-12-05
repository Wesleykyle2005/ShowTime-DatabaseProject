using Microsoft.Data.SqlClient;
using ShowTime_DatabseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Empleados : Form
    {
        private readonly string connectionString = "Server=.; Database=DB_TeamSmile_ShowInfantil; Integrated Security=True; TrustServerCertificate=True";

        public Empleados()
        {
            InitializeComponent();
            InitializeUI();
            LoadDataToDataGridView();
        }

        // Configuración inicial de la interfaz
        private void InitializeUI()
        {
            Utils.AgregarBordeInferiorConHover(btnRegisterEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
        }

        /// <summary>
        /// Obtiene todos los empleados de la base de datos.
        /// </summary>
        /// <returns>Lista de empleados.</returns>
        public IEnumerable<Empleado> GetAllEmployees()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Empleados";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                empleados.Add(new Empleado
                                {
                                    IdEmpleado = Convert.ToInt32(reader["Id_empleado"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Usuario = reader["Usuario"].ToString(),

                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return empleados;
        }

        /// <summary>
        /// Carga los datos de los empleados en el DataGridView.
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                dgvEmployees.DataSource = GetAllEmployees().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Registra un nuevo empleado.
        /// </summary>
        private void btnRegisterEmployee_Click_1(object sender, EventArgs e)
        {
            // Validación de campos
            if (!ValidateInputs()) return;

            string queryInsert = @"
                INSERT INTO Empleados (Nombre, Apellido, Telefono, Email, Usuario, Contrasena) 
                VALUES (@Nombre, @Apellido, @Telefono, @Email, @Usuario, @Contrasena)";
            string encryptedPassword = EncryptPassword(txtPassword.Text.Trim());
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Usuario", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@Contrasena", encryptedPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza la información de un empleado seleccionado.
        /// </summary>
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un empleado para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            int idEmpleado = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["IdEmpleado"].Value);
            string encryptedPassword = EncryptPassword(txtPassword.Text.Trim());
            string queryUpdate = @"
                UPDATE Empleados
                SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Usuario = @Usuario, Contrasena = @Contrasena
                WHERE Id_empleado = @IdEmpleado";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Usuario", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@Contrasena", encryptedPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los datos del empleado seleccionado en los campos de entrada.
        /// </summary>
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                TxtEmployeeName.Text = row.Cells["Nombre"].Value.ToString();
                txtEmployeeLastName.Text = row.Cells["Apellido"].Value.ToString();
                txtEmployeeNumber.Text = row.Cells["Telefono"].Value.ToString();
                txtEmployeeEmail.Text = row.Cells["Email"].Value.ToString();
                txtUser.Text = row.Cells["Usuario"].Value.ToString();
                txtPassword.Text = row.Cells["Contrasena"].Value.ToString();
            }
        }

        /// <summary>
        /// Valida los campos de entrada.
        /// </summary>
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(TxtEmployeeName.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Limpia los campos de entrada.
        /// </summary>
        private void ClearInputs()
        {
            TxtEmployeeName.Clear();
            txtEmployeeLastName.Clear();
            txtEmployeeNumber.Clear();
            txtEmployeeEmail.Clear();
            txtUser.Clear();
            txtPassword.Clear();
        }

        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convierte la contraseña en bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convierte los bytes a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        
    }
}
