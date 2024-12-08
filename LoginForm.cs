using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario de inicio de sesión para la aplicación.
    /// Maneja la autenticación del usuario y redirige al panel principal.
    /// </summary>
    public partial class LoginForm : Form
    {
        // Cadena de conexión a la base de datos
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        /// <summary>
        /// Constructor del formulario de inicio de sesión.
        /// Inicializa componentes y configura el diseño del formulario.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            CenterForm(); // Centra el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen; // Asegura que el formulario aparezca centrado

            // Agrega estilos de hover a los botones
            Utils.AgregarBordeInferiorConHover(LoginButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
        }

        /// <summary>
        /// Cifra una contraseña usando el algoritmo SHA256.
        /// </summary>
        /// <param name="password">La contraseña en texto plano.</param>
        /// <returns>La contraseña cifrada en formato hexadecimal.</returns>
        private string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                // Convierte cada byte a formato hexadecimal
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
        /// <param name="username">El nombre de usuario ingresado.</param>
        /// <param name="password">La contraseña ingresada en texto plano.</param>
        /// <param name="idCargo">Salida: ID del cargo del usuario.</param>
        /// <param name="nombreEmpleado">Salida: Nombre del empleado.</param>
        /// <returns>Verdadero si las credenciales son correctas; de lo contrario, falso.</returns>
        private bool VerifyLogin(string username, string password, out int idCargo, out string nombreEmpleado)
        {
            idCargo = -1;
            nombreEmpleado = string.Empty;

            // Consulta SQL para obtener la información del usuario
            string query = @"
                SELECT u.Id_Cargo, e.Nombre, u.Contraseña 
                FROM Usuarios u
                INNER JOIN Empleados e ON u.Id_empleado = e.Id_empleado
                WHERE u.Nombre_usuario = @Nombre_usuario AND u.Estado = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Asigna el parámetro para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@Nombre_usuario", username);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Recupera la contraseña almacenada y la compara con la ingresada
                                string storedPassword = reader["Contraseña"].ToString();
                                string encryptedPassword = EncryptPassword(password);

                                if (storedPassword == encryptedPassword)
                                {
                                    idCargo = Convert.ToInt32(reader["Id_Cargo"]);
                                    nombreEmpleado = reader["Nombre"].ToString();
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

            return false; // Usuario no encontrado o contraseña incorrecta
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
            bool isLoginSuccessful = VerifyLogin(username, password, out int idCargo, out string nombreEmpleado);

            if (isLoginSuccessful)
            {
                // Muestra un mensaje de éxito y redirige al panel principal
                MessageBox.Show($"Inicio de sesión exitoso. Bienvenido, {nombreEmpleado}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard(nombreEmpleado); // Pasa el nombre al formulario Dashboard
                dashboard.Show();
                this.Hide(); // Oculta el formulario actual
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Calcula las coordenadas para centrar el formulario
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            // Establece la ubicación calculada
            this.Location = new Point(x, y);
        }
    }
}
