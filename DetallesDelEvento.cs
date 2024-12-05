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


            eventoTemp.FechaReserva = DateTime.Now;
            eventoTemp.FechaInicio = txtHoraInicio.Value;
            eventoTemp.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            eventoTemp.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            eventoTemp.Ubicacion = txtUbicacion.Text;
            eventoTemp.Direccion = txtDireccion.Text;
            eventoTemp.CantidadAsistentes = int.Parse(txtCantidadAsistentes.Text);
            eventoTemp.DetallesAdicionales = txtDetalles.Text;


            var formPaquetes = new InformacionPaquetesServicios(eventoTemp);
            formPaquetes.ShowDialog();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
