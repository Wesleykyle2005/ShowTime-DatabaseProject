using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShowTime_DatabseProject
{
    public partial class Utileria : Form
    {
        // Cadena de conexión obtenida desde el archivo de configuración
        private readonly string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Utileria()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        /// <summary>
        /// Configura los componentes iniciales y sus eventos.
        /// </summary>
        private void InitializeCustomComponents()
        {
            // Cargar datos iniciales en el DataGridView
            LoadDataToDataGridView();

            // Configurar estilos personalizados en botones
            Utils.AgregarBordeInferiorConHover(btnRegisterProp, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateUtileria, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);

            // Desactivar botones hasta que se valide la entrada
            btnRegisterProp.Enabled = false;
            btnUpdateUtileria.Enabled = false;

            // Agregar validación dinámica de entradas de texto
            txtPropName.TextChanged += ValidateInputs;
            txtPropQuantity.TextChanged += ValidateInputs;
        }

        /// <summary>
        /// Valida los campos de entrada y habilita/deshabilita los botones según corresponda.
        /// </summary>
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isNameValid = !string.IsNullOrWhiteSpace(txtPropName.Text);
            bool isQuantityValid = int.TryParse(txtPropQuantity.Text, out _);

            // Habilitar botones solo si los datos son válidos
            btnRegisterProp.Enabled = isNameValid && isQuantityValid;
            btnUpdateUtileria.Enabled = dgvUtileria.SelectedRows.Count > 0 && isNameValid && isQuantityValid;
        }

        /// <summary>
        /// Obtiene todas las utilerías desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Utileria.</returns>
        public IEnumerable<Models.Utileria> GetAll()
        {
            List<Models.Utileria> utilerias = new List<Models.Utileria>();

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Utileria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            utilerias.Add(new Models.Utileria
                            {
                                IdUtileria = Convert.ToInt32(reader["Id_utileria"]),
                                Nombre = reader["Nombre"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al obtener las utilerías", ex);
            }

            return utilerias;
        }

        /// <summary>
        /// Carga los datos de utilería en el DataGridView.
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                dgvUtileria.DataSource = GetAll().ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al cargar los datos en el DataGridView", ex);
            }
        }

        /// <summary>
        /// Registra una nueva utilería en la base de datos.
        /// </summary>
        private void btnRegisterProp_Click(object sender, EventArgs e)
        {
            string propName = txtPropName.Text.Trim();

            if (!int.TryParse(txtPropQuantity.Text, out int propQuantity))
            {
                ShowWarningMessage("Ingrese una cantidad válida (número entero).");
                return;
            }

            string query = "INSERT INTO Utileria (Nombre, Cantidad) VALUES (@Nombre, @Cantidad)";

            try
            {
                using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", propName);
                        cmd.Parameters.AddWithValue("@Cantidad", propQuantity);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ShowInfoMessage("Utilería añadida correctamente.");
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al añadir la utilería", ex);
            }
        }

        /// <summary>
        /// Carga los datos de una fila seleccionada en los campos de texto.
        /// </summary>
        private void dgvUtileria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUtileria.Rows[e.RowIndex];
                txtPropName.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtPropQuantity.Text = row.Cells["Cantidad"].Value?.ToString() ?? string.Empty;
            }
        }

        /// <summary>
        /// Actualiza los datos de una utilería seleccionada.
        /// </summary>
        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (dgvUtileria.SelectedRows.Count == 0)
            {
                ShowWarningMessage("Seleccione una utilería para actualizar.");
                return;
            }

            DataGridViewRow row = dgvUtileria.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IdUtileria"].Value);
            string propName = txtPropName.Text.Trim();

            if (!int.TryParse(txtPropQuantity.Text, out int propQuantity))
            {
                ShowWarningMessage("Ingrese una cantidad válida (número entero).");
                return;
            }

            string query = "UPDATE Utileria SET Nombre = @Nombre, Cantidad = @Cantidad WHERE Id_utileria = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", propName);
                        cmd.Parameters.AddWithValue("@Cantidad", propQuantity);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ShowInfoMessage("Utilería actualizada correctamente.");
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error al actualizar la utilería", ex);
            }
        }

        #region Helper Methods

        /// <summary>
        /// Muestra un mensaje de error.
        /// </summary>
        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de advertencia.
        /// </summary>
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Muestra un mensaje informativo.
        /// </summary>
        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
