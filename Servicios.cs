using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShowTime_DatabseProject
{
    public partial class Servicios : Form
    {
        string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public Servicios()
        {
            InitializeComponent();
            LoadServicesWithUtileria();
            LoadUtileriaList();
        }

        private void LoadServicesWithUtileria()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT S.Id_servicio, S.Nombre_servicio, S.Descripcion, S.Costo, 
                               STRING_AGG(U.Nombre, ', ') AS Utilerias
                        FROM Servicios S
                        LEFT JOIN Servicio_Utileria SU ON S.Id_servicio = SU.Id_servicio
                        LEFT JOIN Utileria U ON SU.Id_utileria = U.Id_utileria
                        GROUP BY S.Id_servicio, S.Nombre_servicio, S.Descripcion, S.Costo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvServices.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los servicios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUtileriaList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id_utileria, Nombre FROM Utileria";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    UtileriaList.DataSource = dataTable;
                    UtileriaList.DisplayMember = "Nombre";
                    UtileriaList.ValueMember = "Id_utileria";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la utilería: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterService_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text.Trim();
            string serviceDescription = txtServiceDescription.Text.Trim();
            decimal serviceCost;

            if (!decimal.TryParse(txtServiceCost.Text, out serviceCost))
            {
                MessageBox.Show("Ingrese un costo válido (número decimal).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UtileriaList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una utilería para el servicio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();

                    // Insertar el nuevo servicio
                    string insertServiceQuery = @"
                        INSERT INTO Servicios (Nombre_servicio, Descripcion, Costo) 
                        VALUES (@Nombre, @Descripcion, @Costo);
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(insertServiceQuery, connection);
                    cmd.Parameters.AddWithValue("@Nombre", serviceName);
                    cmd.Parameters.AddWithValue("@Descripcion", serviceDescription);
                    cmd.Parameters.AddWithValue("@Costo", serviceCost);

                    // Obtener el ID del servicio recién insertado
                    int serviceId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insertar las relaciones en Servicio_Utileria
                    foreach (var selectedUtileria in UtileriaList.SelectedItems)
                    {
                        DataRowView row = selectedUtileria as DataRowView;
                        int utileriaId = Convert.ToInt32(row["Id_utileria"]);

                        string insertRelationQuery = @"
                            INSERT INTO Servicio_Utileria (Id_servicio, Id_utileria) 
                            VALUES (@ServiceId, @UtileriaId)";

                        SqlCommand relationCmd = new SqlCommand(insertRelationQuery, connection);
                        relationCmd.Parameters.AddWithValue("@ServiceId", serviceId);
                        relationCmd.Parameters.AddWithValue("@UtileriaId", utileriaId);
                        relationCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Servicio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServicesWithUtileria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                int serviceId = Convert.ToInt32(selectedRow.Cells["Id_servicio"].Value);
                string serviceName = txtServiceName.Text.Trim();
                string serviceDescription = txtServiceDescription.Text.Trim();
                decimal serviceCost;

                if (!decimal.TryParse(txtServiceCost.Text, out serviceCost))
                {
                    MessageBox.Show("Ingrese un costo válido (número decimal).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (UtileriaList.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos una utilería para el servicio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                    {
                        connection.Open();

                        // Actualizar los datos del servicio
                        string updateServiceQuery = @"
                            UPDATE Servicios 
                            SET Nombre_servicio = @Nombre, Descripcion = @Descripcion, Costo = @Costo
                            WHERE Id_servicio = @ServiceId";

                        SqlCommand cmd = new SqlCommand(updateServiceQuery, connection);
                        cmd.Parameters.AddWithValue("@Nombre", serviceName);
                        cmd.Parameters.AddWithValue("@Descripcion", serviceDescription);
                        cmd.Parameters.AddWithValue("@Costo", serviceCost);
                        cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                        cmd.ExecuteNonQuery();

                        // Eliminar las relaciones existentes en Servicio_Utileria
                        string deleteRelationsQuery = "DELETE FROM Servicio_Utileria WHERE Id_servicio = @ServiceId";
                        SqlCommand deleteCmd = new SqlCommand(deleteRelationsQuery, connection);
                        deleteCmd.Parameters.AddWithValue("@ServiceId", serviceId);
                        deleteCmd.ExecuteNonQuery();

                        // Insertar las nuevas relaciones
                        foreach (var selectedUtileria in UtileriaList.SelectedItems)
                        {
                            DataRowView row = selectedUtileria as DataRowView;
                            int utileriaId = Convert.ToInt32(row["Id_utileria"]);

                            string insertRelationQuery = @"
                                INSERT INTO Servicio_Utileria (Id_servicio, Id_utileria) 
                                VALUES (@ServiceId, @UtileriaId)";

                            SqlCommand relationCmd = new SqlCommand(insertRelationQuery, connection);
                            relationCmd.Parameters.AddWithValue("@ServiceId", serviceId);
                            relationCmd.Parameters.AddWithValue("@UtileriaId", utileriaId);
                            relationCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Servicio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServicesWithUtileria();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un servicio para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
