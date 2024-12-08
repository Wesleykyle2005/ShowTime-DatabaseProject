using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class RegistrarPagosDeEventos : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_S"].ConnectionString;

        public RegistrarPagosDeEventos()
        {
            InitializeComponent();
            LoadEventosData();
            LoadMetodosPago();
            ConfigureUI();
        }

        /// <summary>
        /// Configura la interfaz de usuario (botones y posiciones).
        /// </summary>
        private void ConfigureUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Color baseColor = Color.FromArgb(18, 29, 36);
            Color hoverColor = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(btnRealizarPagos, baseColor, 3, hoverColor, Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, baseColor, 3, hoverColor, Color.Black);
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga los eventos junto con el monto pendiente de pago en el DataGridView.
        /// </summary>
        private void LoadEventosData()
        {
            const string query = @"
                SELECT 
                    e.Id_evento, 
                    
                    c.Nombre AS Cliente,                     
                    e.Fecha_inicio,
                    e.Detalles_adicionales,
                    e.Costo_total, 
                    dbo.CalcularPagoRestante(e.Id_evento) AS PagoRestante
                FROM 
                    Eventos e
                INNER JOIN 
                    Clientes c ON e.Id_cliente = c.Id_cliente
                ORDER BY 
                    e.Fecha_reserva DESC";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dgvEventos.DataSource = dataTable;

                    if (dgvEventos.Columns["Id_evento"] != null)
                        dgvEventos.Columns["Id_evento"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Registra un pago para el evento seleccionado y actualiza el DataGridView.
        /// </summary>
        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un evento para registrar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener datos del evento seleccionado
                var selectedRow = dgvEventos.SelectedRows[0];
                int idEvento = Convert.ToInt32(selectedRow.Cells["Id_evento"].Value);
                decimal montoPago = numericMontoPago.Value;
                string metodoPago = comboBoxMetodoPago.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(metodoPago))
                {
                    MessageBox.Show("Seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Registrar el pago en la base de datos
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO Pagos (Id_evento, Monto, Metodo_pago, Fecha_pago)
                        VALUES (@IdEvento, @Monto, @MetodoPago, GETDATE())";

                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IdEvento", idEvento);
                        command.Parameters.AddWithValue("@Monto", montoPago);
                        command.Parameters.AddWithValue("@MetodoPago", metodoPago);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView
                LoadEventosData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Carga una lista básica de métodos de pago en el comboBoxMetodoPago.
        /// </summary>
        private void LoadMetodosPago()
        {
            try
            {
                // Definir una lista básica de métodos de pago
                var metodosPago = new List<string>
        {
            "Efectivo",
            "Tarjeta de Crédito",
            "Transferencia Bancaria",
            "Cheque"
        };

                // Limpiar elementos existentes en el ComboBox
                comboBoxMetodoPago.Items.Clear();

                // Agregar los métodos de pago al ComboBox
                comboBoxMetodoPago.Items.AddRange(metodosPago.ToArray());

                // Seleccionar el primer método como predeterminado
                if (comboBoxMetodoPago.Items.Count > 0)
                {
                    comboBoxMetodoPago.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los métodos de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
