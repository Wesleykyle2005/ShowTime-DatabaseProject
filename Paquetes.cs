using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para la gestión de paquetes y sus servicios asociados.
    /// </summary>
    public partial class Paquetes : Form
    {
        // Cadena de conexión configurada en App.config
        private readonly string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public Paquetes()
        {
            InitializeComponent();
            LoadPackagesToDataGridView();
            LoadServicesToListBox();
            LoadDisponibilidadOptions();
            Utils.AgregarBordeInferiorConHover(btnRegisterPackage, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(btnUpdatePackage, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
        }

        /// <summary>
        /// Carga las opciones de disponibilidad en el ComboBox.
        /// </summary>
        private void LoadDisponibilidadOptions()
        {
            comboBoxDisponibilidad.Items.Clear();
            comboBoxDisponibilidad.Items.Add("Disponible");
            comboBoxDisponibilidad.Items.Add("No disponible");
            comboBoxDisponibilidad.SelectedIndex = 0; // Por defecto: "Disponible"
        }

        /// <summary>
        /// Carga la lista de servicios en el ListBox.
        /// </summary>
        private void LoadServicesToListBox()
        {
            try
            {
                List<string> services = new List<string>();
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    const string query = "SELECT Id_servicio, Nombre_servicio FROM Servicios";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string service = $"{reader["Id_servicio"]} - {reader["Nombre_servicio"]}";
                            services.Add(service);
                        }
                    }
                }

                ServicesListBox.DataSource = services;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los servicios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los paquetes existentes en el DataGridView.
        /// </summary>
        private void LoadPackagesToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    const string query = @"
                        SELECT 
                            P.Id_paquete, 
                            P.Nombre_paquete, 
                            P.Descripcion, 
                            P.Disponibilidad, 
                            P.Costo, 
                            P.Cantidad, 
                            STRING_AGG(S.Nombre_servicio, ', ') AS Servicios
                        FROM Paquetes P
                        LEFT JOIN Paquete_Servicios PS ON P.Id_paquete = PS.Id_paquete
                        LEFT JOIN Servicios S ON PS.Id_servicio = S.Id_servicio
                        GROUP BY P.Id_paquete, P.Nombre_paquete, P.Descripcion, P.Disponibilidad, P.Costo, P.Cantidad";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvPackages.DataSource = dataTable;
                    if (dgvPackages.Columns["Id_paquete"] != null)
                        dgvPackages.Columns["Id_paquete"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los paquetes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de registro de un nuevo paquete.
        /// </summary>
        private void btnRegisterPackage_Click(object sender, EventArgs e)
        {
            string packageName = txtPackageName.Text.Trim();
            string packageDescription = txtPackageDescription.Text.Trim();
            decimal packageCost;

            // Validación de costo
            if (!decimal.TryParse(txtPackageCost.Text.Trim(), out packageCost))
            {
                MessageBox.Show("El costo del paquete debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad;
            if (!int.TryParse(comboboxCantidad.Text.Trim(), out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool disponibilidad = comboBoxDisponibilidad.SelectedItem.ToString() == "Disponible";

            List<int> selectedServiceIds = ServicesListBox.SelectedItems
                .Cast<string>()
                .Select(item => int.Parse(item.Split('-')[0].Trim()))
                .ToList();

            if (selectedServiceIds.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();

                    // Inserta el paquete
                    const string insertPackageQuery = @"
                        INSERT INTO Paquetes (Nombre_paquete, Descripcion, Disponibilidad, Costo, Cantidad)
                        OUTPUT INSERTED.Id_paquete
                        VALUES (@Nombre_paquete, @Descripcion, @Disponibilidad, @Costo, @Cantidad)";
                    using (SqlCommand cmd = new SqlCommand(insertPackageQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre_paquete", packageName);
                        cmd.Parameters.AddWithValue("@Descripcion", packageDescription);
                        cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                        cmd.Parameters.AddWithValue("@Costo", packageCost);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                        int packageId = (int)cmd.ExecuteScalar();

                        // Inserta relaciones con servicios
                        const string insertRelationQuery = "INSERT INTO Paquete_Servicios (Id_paquete, Id_servicio) VALUES (@Id_paquete, @Id_servicio)";
                        foreach (int serviceId in selectedServiceIds)
                        {
                            using (SqlCommand relationCmd = new SqlCommand(insertRelationQuery, connection))
                            {
                                relationCmd.Parameters.AddWithValue("@Id_paquete", packageId);
                                relationCmd.Parameters.AddWithValue("@Id_servicio", serviceId);
                                relationCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Paquete registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPackagesToDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el paquete: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de actualización de un paquete existente.
        /// </summary>
        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un paquete para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvPackages.SelectedRows[0];
            int packageId = Convert.ToInt32(selectedRow.Cells["Id_paquete"].Value);

            string packageName = txtPackageName.Text.Trim();
            string packageDescription = txtPackageDescription.Text.Trim();
            decimal packageCost;

            // Validación de costo
            if (!decimal.TryParse(txtPackageCost.Text.Trim(), out packageCost))
            {
                MessageBox.Show("El costo del paquete debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad;
            if (!int.TryParse(comboboxCantidad.Text.Trim(), out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool disponibilidad = comboBoxDisponibilidad.SelectedItem.ToString() == "Disponible";

            List<int> selectedServiceIds = ServicesListBox.SelectedItems
                .Cast<string>()
                .Select(item => int.Parse(item.Split('-')[0].Trim()))
                .ToList();

            if (selectedServiceIds.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();

                    // Actualiza el paquete
                    const string updatePackageQuery = @"
                        UPDATE Paquetes
                        SET Nombre_paquete = @Nombre_paquete, 
                            Descripcion = @Descripcion, 
                            Disponibilidad = @Disponibilidad, 
                            Costo = @Costo,
                            Cantidad = @Cantidad
                        WHERE Id_paquete = @Id_paquete";
                    using (SqlCommand cmd = new SqlCommand(updatePackageQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre_paquete", packageName);
                        cmd.Parameters.AddWithValue("@Descripcion", packageDescription);
                        cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                        cmd.Parameters.AddWithValue("@Costo", packageCost);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Id_paquete", packageId);
                        cmd.ExecuteNonQuery();
                    }

                    // Elimina las relaciones existentes con servicios
                    const string deleteRelationsQuery = "DELETE FROM Paquete_Servicios WHERE Id_paquete = @Id_paquete";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteRelationsQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@Id_paquete", packageId);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Inserta nuevas relaciones con servicios
                    const string insertRelationQuery = "INSERT INTO Paquete_Servicios (Id_paquete, Id_servicio) VALUES (@Id_paquete, @Id_servicio)";
                    foreach (int serviceId in selectedServiceIds)
                    {
                        using (SqlCommand relationCmd = new SqlCommand(insertRelationQuery, connection))
                        {
                            relationCmd.Parameters.AddWithValue("@Id_paquete", packageId);
                            relationCmd.Parameters.AddWithValue("@Id_servicio", serviceId);
                            relationCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Paquete actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPackagesToDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el paquete: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
