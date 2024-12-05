using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "Server=.; Database=DB_TeamSmile_ShowInfantil; Integrated Security=True; TrustServerCertificate=True";

        public LoginForm()
        {
            
            InitializeComponent();
            CenterForm();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Método para cifrar la contraseña
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

        // Método para verificar el inicio de sesión
        private bool VerifyLogin(string username, string password)
        {
            string query = "SELECT * FROM Empleados WHERE Usuario = @Usuario";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Usuario", username);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedPassword = reader["Contrasena"].ToString();
                        string encryptedPassword = EncryptPassword(password);

                        // Compara la contraseña cifrada
                        return storedPassword == encryptedPassword;
                    }
                    return false; // Usuario no encontrado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para el evento del botón de login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text.Trim();
            string password = Passwordtexbox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa tu nombre de usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica el login
            bool isLoginSuccessful = VerifyLogin(username, password);

            if (isLoginSuccessful)
            {
                // Si el inicio de sesión es exitoso, abre el siguiente formulario
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pasa el nombre de usuario al siguiente formulario
                string userName = username; // Guardar el nombre de usuario

                // Aquí se abre el nuevo formulario y se cierra el formulario actual
                Dashboard dashboard = new Dashboard(userName); // Asume que el formulario que sigue es MainForm
                dashboard.Show();
                this.Hide(); // Cierra el formulario actual de Login
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para el evento del botón de cerrar
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void CenterForm()
        {
            // Obtiene las coordenadas de la pantalla
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            // Establece la ubicación del formulario en el centro
            this.Location = new Point(x, y);
        }
    }
}
