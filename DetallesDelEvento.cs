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
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            /*if (dtpFechaInicio.Value <= dtpFechaReserva.Value ||
       TimeSpan.Parse(txtHoraFin.Text) <= TimeSpan.Parse(txtHoraInicio.Text) ||
       int.Parse(txtCantidadAsistentes.Text) <= 0)
            {
                MessageBox.Show("Verifica las fechas, horarios y la cantidad de asistentes.", "Validación");
                return;
            }*/

            eventoTemp.FechaReserva = DateTime.Now;
            eventoTemp.FechaInicio = txtHoraInicio.Value;
            eventoTemp.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            eventoTemp.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            eventoTemp.Ubicacion = txtUbicacion.Text;
            eventoTemp.Direccion = txtDireccion.Text;
            eventoTemp.CantidadAsistentes = int.Parse(txtCantidadAsistentes.Text);
            eventoTemp.DetallesAdicionales = txtDetalles.Text;


            var formPaquetes = new InformacionPaquetesServicios(eventoTemp);
            formPaquetes.Show();
            this.Close();
        }
    }
}
