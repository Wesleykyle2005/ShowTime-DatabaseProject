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
        string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Utileria()
        {
            InitializeComponent();
            LoadDataToDataGridView();
            Utils.AgregarBordeInferiorConHover(btnRegisterProp, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdateUtileria, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);

            // Inicialmente desactivar botones
            btnRegisterProp.Enabled = false;
            btnUpdateUtileria.Enabled = false;

            // Validar entrada de texto en tiempo real
            txtPropName.TextChanged += ValidateInputs;
            txtPropQuantity.TextChanged += ValidateInputs;
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            // Validar campos vacíos y entrada numérica para cantidad
            btnRegisterProp.Enabled = !string.IsNullOrWhiteSpace(txtPropName.Text) &&
                                       int.TryParse(txtPropQuantity.Text, out _);

            btnUpdateUtileria.Enabled = dgvUtileria.SelectedRows.Count > 0 &&
                                        !string.IsNullOrWhiteSpace(txtPropName.Text) &&
                                        int.TryParse(txtPropQuantity.Text, out _);
        }

        public IEnumerable<Models.Utileria> GetAll()
        {
            List<Models.Utileria> utilerias = new List<Models.Utileria>();
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Utileria", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Models.Utileria utileria = new Models.Utileria
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
                MessageBox.Show($"Error al obtener la utilería: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return utilerias;
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                dgvUtileria.DataSource = GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterProp_Click(object sender, EventArgs e)
        {
            string propName = txtPropName.Text.Trim();
            int propQuantity;

            if (!int.TryParse(txtPropQuantity.Text, out propQuantity))
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryInsert = "INSERT INTO Utileria (Nombre, Cantidad) VALUES (@Nombre, @Cantidad)";

            try
            {
                using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@Nombre", propName);
                    cmd.Parameters.AddWithValue("@Cantidad", propQuantity);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Utilería añadida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir la utilería: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUtileria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUtileria.Rows[e.RowIndex];
                txtPropName.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtPropQuantity.Text = row.Cells["Cantidad"].Value?.ToString() ?? string.Empty;
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
                    string propName = txtPropName.Text.Trim();
                    int propQuantity;

                    if (!int.TryParse(txtPropQuantity.Text, out propQuantity))
                    {
                        MessageBox.Show("Ingrese una cantidad válida (número entero).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string queryUpdate = @"UPDATE Utileria
                                           SET Nombre = @Nombre, Cantidad = @Cantidad
                                           WHERE Id_utileria = @Id";

                    using (SqlConnection conn = new SqlConnection(sqlServerConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", propName);
                        cmd.Parameters.AddWithValue("@Cantidad", propQuantity);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Utilería actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la utilería: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
