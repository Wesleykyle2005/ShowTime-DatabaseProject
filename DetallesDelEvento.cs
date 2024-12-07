using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class DetallesDelEvento : Form
    {
        public EventoTemporal eventoTemp;
        public DetallesDelEvento(EventoTemporal eventoTemporal)
        {
            eventoTemp = eventoTemporal;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateHorariosConFechaReserva();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {


            try
            {
                // Validar FechaReserva y FechaInicio
                if (txtHoraInicio.Value.Date <= DateTime.Now.Date)
                    throw new ArgumentException("La fecha de inicio debe ser posterior a la fecha actual.");

                if (txtHoraInicio.Value.Date <= DateTime.Now.Date || txtHoraFin.Value <= txtHoraInicio.Value)
                    throw new ArgumentException("La fecha y hora de inicio deben ser posteriores a la fecha y hora actuales.");

                // Validar CantidadAsistentes
                if (!int.TryParse(txtCantidadAsistentes.Text, out int cantidadAsistentes) || cantidadAsistentes <= 0)
                    throw new ArgumentException("La cantidad de asistentes debe ser un número mayor a 0.");

                // Validar CostoTotal

                // Parsear y asignar valores al objeto
                eventoTemp.FechaReserva = DateTime.Now; // Fecha de reservación actual
                eventoTemp.FechaInicio = txtHoraInicio.Value.Date; // Fecha del evento
                eventoTemp.HoraInicio = txtHoraInicio.Value.TimeOfDay; // Hora de inicio
                eventoTemp.HoraFin = txtHoraFin.Value.TimeOfDay; // Hora de fin
                eventoTemp.Ubicacion = string.IsNullOrWhiteSpace(txtUbicacion.Text)
                    ? throw new ArgumentException("La ubicación no puede estar vacía.")
                    : txtUbicacion.Text.Trim();

                eventoTemp.Direccion = string.IsNullOrWhiteSpace(txtDireccion.Text)
                    ? throw new ArgumentException("La dirección no puede estar vacía.")
                    : txtDireccion.Text.Trim();

                eventoTemp.CantidadAsistentes = cantidadAsistentes; // Cantidad de asistentes
                eventoTemp.DetallesAdicionales = string.IsNullOrWhiteSpace(txtDetalles.Text)
                    ? null
                    : txtDetalles.Text.Trim();


                // Validación adicional: Costo inicial menor o igual al costo total
                if (eventoTemp.MontoInicial > eventoTemp.CostoTotal)
                    throw new ArgumentException("El monto inicial no puede ser mayor al costo total.");

                MessageBox.Show("Datos validados correctamente.", "Validación exitosa");

                var formPaquetes = new InformacionPaquetesServicios(eventoTemp);
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void UpdateHorariosConFechaReserva()
        {
            // Asegurarse de que los campos de hora (hora de inicio y hora de fin) 
            // estén configurados con la misma fecha de la reserva (solo modificando la hora).
            var fechaReserva = dtpFechaReserva.Value.Date; // Obtener solo la parte de la fecha

            txtHoraInicio.Value = fechaReserva.Add(eventoTemp.HoraInicio); // Establecer la hora de inicio con la fecha de reserva
            txtHoraFin.Value = fechaReserva.Add(eventoTemp.HoraFin); // Establecer la hora de fin con la fecha de reserva
        }


        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaReserva_ValueChanged(object sender, EventArgs e)
        {
            UpdateHorariosConFechaReserva();
        }
    }
}
