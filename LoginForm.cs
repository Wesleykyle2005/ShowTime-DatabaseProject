using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class LoginForm : Form
    {
        // Cadena de conexión a la base de datos
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            CenterForm(); // Centra el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Agrega estilos de hover a los botones
            Utils.AgregarBordeInferiorConHover(LoginButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
        }

        /// <summary>
        /// Cifra una contraseña usando el algoritmo SHA256.
        /// </summary>
        private string EncryptPassword(string password)
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

        /// <summary>
        /// Verifica las credenciales del usuario contra la base de datos.
        /// </summary>
        private bool VerifyLogin(string username, string password, out int idCargo, out string nombreEmpleado, out string nombreCargo)
        {
            idCargo = -1;
            nombreEmpleado = string.Empty;
            nombreCargo = string.Empty;

            string query = @"
                SELECT u.Id_Cargo, e.Nombre, c.Nombre_cargo, u.Contraseña 
                FROM Usuarios u
                INNER JOIN Empleados e ON u.Id_empleado = e.Id_empleado
                INNER JOIN Cargos c ON u.Id_Cargo = c.Id_cargo
                WHERE u.Nombre_usuario = @Nombre_usuario AND u.Estado = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre_usuario", username);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Contraseña"].ToString().ToLower();
                                string encryptedPassword = EncryptPassword(password).ToString().ToLower();
                                
                                if (storedPassword == encryptedPassword)
                                {
                                    idCargo = Convert.ToInt32(reader["Id_Cargo"]);
                                    nombreEmpleado = reader["Nombre"].ToString();
                                    nombreCargo = reader["Nombre_cargo"].ToString();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de inicio de sesión.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text.Trim();
            string password = Passwordtexbox.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa tu nombre de usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica las credenciales del usuario
            bool isLoginSuccessful = VerifyLogin(username, password, out int idCargo, out string nombreEmpleado, out string nombreCargo);

            if (isLoginSuccessful)
            {
                MessageBox.Show($"Inicio de sesión exitoso. Bienvenido, {nombreEmpleado}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pasa el nombre y cargo al panel principal
                Dashboard dashboard = new Dashboard(nombreEmpleado, nombreCargo);
                dashboard.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show($"Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de cerrar.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        /// <summary>
        /// Centra el formulario en la pantalla principal.
        /// </summary>
        private void CenterForm()
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
    }
}
