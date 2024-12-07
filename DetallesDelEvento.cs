using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario para gestionar los detalles de un evento temporal.
    /// </summary>
    public partial class DetallesDelEvento : Form
    {
        /// <summary>
        /// Objeto que almacena los datos del evento temporal.
        /// </summary>
        public EventoTemporal EventoTemp { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="DetallesDelEvento"/> con los datos de un evento temporal.
        /// </summary>
        /// <param name="eventoTemporal">Objeto que contiene los datos del evento.</param>
        public DetallesDelEvento(EventoTemporal eventoTemporal)
        {
            EventoTemp = eventoTemporal;
            InitializeComponent();

            // Configuración inicial del formulario
            this.StartPosition = FormStartPosition.CenterScreen;
            ConfigurarBotones();
            UpdateHorariosConFechaReserva();
        }

        /// <summary>
        /// Configura los bordes y estilos de los botones del formulario.
        /// </summary>
        private void ConfigurarBotones()
        {
            Color colorBase = Color.FromArgb(18, 29, 36);
            Color colorHover = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(continueButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(CloseButton, colorBase, 3, colorHover, Color.Black);
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Continuar".
        /// Realiza la validación de los datos y procede a la siguiente etapa.
        /// </summary>
        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatosEvento();

                // Mostrar mensaje de éxito y abrir el siguiente formulario
                MessageBox.Show("Datos validados correctamente.", "Validación exitosa");
                var formPaquetes = new InformacionPaquetesServicios(EventoTemp);
                formPaquetes.ShowDialog();
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Valida los datos ingresados en el formulario y actualiza el objeto <see cref="EventoTemporal"/>.
        /// </summary>
        private void ValidarDatosEvento()
        {
            // Validar FechaReserva y FechaInicio
            if (txtHoraInicio.Value.Date <= DateTime.Now.Date)
                throw new ArgumentException("La fecha de inicio debe ser posterior a la fecha actual.");

            if (txtHoraFin.Value <= txtHoraInicio.Value)
                throw new ArgumentException("La hora de fin debe ser posterior a la hora de inicio.");

            // Validar CantidadAsistentes
            if (!int.TryParse(txtCantidadAsistentes.Text, out int cantidadAsistentes) || cantidadAsistentes <= 0)
                throw new ArgumentException("La cantidad de asistentes debe ser un número mayor a 0.");

            // Validar Ubicación
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
                throw new ArgumentException("La ubicación no puede estar vacía.");

            // Validar Dirección
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                throw new ArgumentException("La dirección no puede estar vacía.");

            // Actualizar los datos del evento temporal
            EventoTemp.FechaReserva = DateTime.Now;
            EventoTemp.FechaInicio = txtHoraInicio.Value.Date;
            EventoTemp.HoraInicio = txtHoraInicio.Value.TimeOfDay;
            EventoTemp.HoraFin = txtHoraFin.Value.TimeOfDay;
            EventoTemp.Ubicacion = txtUbicacion.Text.Trim();
            EventoTemp.Direccion = txtDireccion.Text.Trim();
            EventoTemp.CantidadAsistentes = cantidadAsistentes;
            EventoTemp.DetallesAdicionales = string.IsNullOrWhiteSpace(txtDetalles.Text) ? null : txtDetalles.Text.Trim();

            // Validar monto inicial y costo total
            if (EventoTemp.MontoInicial > EventoTemp.CostoTotal)
                throw new ArgumentException("El monto inicial no puede ser mayor al costo total.");
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Cerrar".
        /// Cierra el formulario actual.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Actualiza las horas de inicio y fin basadas en la fecha seleccionada para la reserva.
        /// </summary>
        private void UpdateHorariosConFechaReserva()
        {
            var fechaReserva = dtpFechaReserva.Value.Date;

            txtHoraInicio.Value = fechaReserva.Add(EventoTemp.HoraInicio);
            txtHoraFin.Value = fechaReserva.Add(EventoTemp.HoraFin);
        }

        /// <summary>
        /// Maneja el cambio de valor en el selector de fecha de reserva.
        /// Actualiza los horarios basados en la nueva fecha seleccionada.
        /// </summary>
        private void dtpFechaReserva_ValueChanged(object sender, EventArgs e)
        {
            UpdateHorariosConFechaReserva();
        }
    }
}
