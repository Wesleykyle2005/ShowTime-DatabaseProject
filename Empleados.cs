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

        private void InitializeUI()
        {
            Utils.AgregarBordeInferiorConHover(btnRegisterEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateEmployee, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
        }

        public IEnumerable<Empleado> GetAllEmployees()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT e.Id_empleado, e.Nombre, e.Apellido, e.Telefono, e.Email, e.Estado_Empleado, 
                               u.Id_usuario, u.Nombre_usuario, u.Estado 
                        FROM Empleados e
                        LEFT JOIN Usuarios u ON e.Id_empleado = u.Id_empleado";
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
                                    EstadoEmpleado = Convert.ToInt32(reader["Estado_Empleado"]),
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

        private void btnRegisterEmployee_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string queryInsertEmpleado = @"
                INSERT INTO Empleados (Nombre, Apellido, Telefono, Email, Estado_Empleado)
                OUTPUT INSERTED.Id_empleado
                VALUES (@Nombre, @Apellido, @Telefono, @Email, @EstadoEmpleado)";

            string queryInsertUsuario = @"
                INSERT INTO Usuarios (Id_empleado, Id_Cargo, Nombre_usuario, Contraseña, Estado)
                VALUES (@IdEmpleado, @IdCargo, @NombreUsuario, @Contrasena, @Estado)";

            string encryptedPassword = EncryptPassword(txtPassword.Text.Trim());

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        SqlCommand cmdEmpleado = new SqlCommand(queryInsertEmpleado, conn, transaction);
                        cmdEmpleado.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@EstadoEmpleado", 3); // Default: Disponible
                        int idEmpleado = (int)cmdEmpleado.ExecuteScalar();

                        SqlCommand cmdUsuario = new SqlCommand(queryInsertUsuario, conn, transaction);
                        cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmdUsuario.Parameters.AddWithValue("@IdCargo", 2); // Default: Empleado
                        cmdUsuario.Parameters.AddWithValue("@NombreUsuario", txtUser.Text.Trim());
                        cmdUsuario.Parameters.AddWithValue("@Contrasena", encryptedPassword);
                        cmdUsuario.Parameters.AddWithValue("@Estado", 1); // Activo por defecto
                        cmdUsuario.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

            string queryUpdateEmpleado = @"
                UPDATE Empleados
                SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Estado_Empleado = @EstadoEmpleado
                WHERE Id_empleado = @IdEmpleado";

            string queryUpdateUsuario = @"
                UPDATE Usuarios
                SET Nombre_usuario = @NombreUsuario, Contraseña = @Contrasena, Estado = @Estado
                WHERE Id_empleado = @IdEmpleado";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        SqlCommand cmdEmpleado = new SqlCommand(queryUpdateEmpleado, conn, transaction);
                        cmdEmpleado.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmdEmpleado.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@EstadoEmpleado", 3); // Update as needed
                        cmdEmpleado.ExecuteNonQuery();

                        SqlCommand cmdUsuario = new SqlCommand(queryUpdateUsuario, conn, transaction);
                        cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmdUsuario.Parameters.AddWithValue("@NombreUsuario", txtUser.Text.Trim());
                        cmdUsuario.Parameters.AddWithValue("@Contrasena", encryptedPassword);
                        cmdUsuario.Parameters.AddWithValue("@Estado", 1); // Update as needed
                        cmdUsuario.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resto del código no cambia significativamente

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
