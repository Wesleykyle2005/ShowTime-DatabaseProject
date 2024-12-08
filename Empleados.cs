using Microsoft.Data.SqlClient;
using ShowTime_DatabseProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para la gestión de empleados.
    /// </summary>
    public partial class Empleados : Form
    {
        /// <summary>
        /// Cadena de conexión a la base de datos.
        /// </summary>
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Empleados()
        {
            InitializeComponent();
            ConfigureUI();
            LoadDataToDataGridView();
        }

        /// <summary>
        /// Configura el diseño visual del formulario.
        /// </summary>
        private void ConfigureUI()
        {
            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(btnRegisterEmployee, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateEmployee, baseColor, 3, hoverColor, Color.Black);
        }

        /// <summary>
        /// Obtiene la lista de todos los empleados desde la base de datos.
        /// </summary>
        /// <returns>Lista de empleados.</returns>
        private IEnumerable<Empleado> GetAllEmployees()
        {
            List<Empleado> empleados = new List<Empleado>();
            const string query = @"
                SELECT e.Id_empleado, e.Nombre, e.Apellido, e.Telefono, e.Email, e.Estado_Empleado, 
                       u.Id_usuario, u.Nombre_usuario, u.Estado 
                FROM Empleados e
                LEFT JOIN Usuarios u ON e.Id_empleado = u.Id_empleado";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
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
                                EstadoEmpleado = Convert.ToInt32(reader["Estado_Empleado"])
                            });
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
        /// Carga los datos de empleados en el DataGridView.
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                dgvEmployees.DataSource = GetAllEmployees().ToList();
                if (dgvEmployees.Columns["EstadoEmpleado"] != null)
                {
                    dgvEmployees.Columns["EstadoEmpleado"].HeaderText = "Estado";
                    dgvEmployees.CellFormatting += DgvEmployees_CellFormatting;
                }
                if (dgvEmployees.Columns["EstadoEmpleadoNavigation"] != null)
                    dgvEmployees.Columns["EstadoEmpleadoNavigation"].Visible = false;

                if (dgvEmployees.Columns["RolEmpleadoEventos"] != null)
                    dgvEmployees.Columns["RolEmpleadoEventos"].Visible = false;

                if (dgvEmployees.Columns["Usuarios"] != null)
                    dgvEmployees.Columns["Usuarios"].Visible = false;

                if (dgvEmployees.Columns["IdEmpleado"] != null)
                    dgvEmployees.Columns["IdEmpleado"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        /// <summary>
        /// Evento para formatear las celdas del DataGridView.
        /// Reemplaza los valores numéricos en la columna EstadoEmpleado con descripciones.
        /// </summary>
        private void DgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "EstadoEmpleado" && e.Value != null)
            {
                // Convertir los valores numéricos a descripciones
                switch (e.Value)
                {
                    case 1:
                        e.Value = "Disponible";
                        break;
                    case 2:
                        e.Value = "En Evento";
                        break;
                    case 3:
                        e.Value = "Inactivo";
                        break;
                    default:
                        e.Value = "Desconocido";
                        break;
                }

                e.FormattingApplied = true; // Indica que el formato personalizado se ha aplicado
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de registro de empleados.
        /// </summary>
        private void btnRegisterEmployee_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            const string queryInsertEmpleado = @"
                INSERT INTO Empleados (Nombre, Apellido, Telefono, Email, Estado_Empleado)
                OUTPUT INSERTED.Id_empleado
                VALUES (@Nombre, @Apellido, @Telefono, @Email, @EstadoEmpleado)";
            const string queryInsertUsuario = @"
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
                        // Insertar empleado
                        SqlCommand cmdEmpleado = new SqlCommand(queryInsertEmpleado, conn, transaction);
                        cmdEmpleado.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@EstadoEmpleado", 3); // Default: Disponible
                        int idEmpleado = (int)cmdEmpleado.ExecuteScalar();

                        // Insertar usuario asociado
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

        /// <summary>
        /// Maneja el evento de clic en el botón de actualización de empleados.
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

            const string queryUpdateEmpleado = @"
                UPDATE Empleados
                SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Estado_Empleado = @EstadoEmpleado
                WHERE Id_empleado = @IdEmpleado";
            const string queryUpdateUsuario = @"
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
                        // Actualizar empleado
                        SqlCommand cmdEmpleado = new SqlCommand(queryUpdateEmpleado, conn, transaction);
                        cmdEmpleado.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmdEmpleado.Parameters.AddWithValue("@Nombre", TxtEmployeeName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Apellido", txtEmployeeLastName.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Telefono", txtEmployeeNumber.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text.Trim());
                        cmdEmpleado.Parameters.AddWithValue("@EstadoEmpleado", 3);
                        cmdEmpleado.ExecuteNonQuery();

                        // Actualizar usuario
                        SqlCommand cmdUsuario = new SqlCommand(queryUpdateUsuario, conn, transaction);
                        cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmdUsuario.Parameters.AddWithValue("@NombreUsuario", txtUser.Text.Trim());
                        cmdUsuario.Parameters.AddWithValue("@Contrasena", encryptedPassword);
                        cmdUsuario.Parameters.AddWithValue("@Estado", 1);
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

        /// <summary>
        /// Valida los campos de entrada del formulario.
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
        /// Limpia los campos de entrada del formulario.
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

        /// <summary>
        /// Cifra una contraseña utilizando SHA256.
        /// </summary>
        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
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
