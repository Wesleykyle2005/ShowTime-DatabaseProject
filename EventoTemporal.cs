using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime_DatabseProject
{
    public class EventoTemporal
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoCliente { get; set; }

        // Información del evento
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Ubicacion { get; set; }
        public string Direccion { get; set; }
        public int CantidadAsistentes { get; set; }
        public string DetallesAdicionales { get; set; }
        public decimal CostoTotal { get; set; }
        public string Estado { get; set; } = "Pendiente";

        // Paquetes y servicios contratados
        public List<int> IdsPaquetes { get; set; } = new List<int>();
        public List<int> IdsServicios { get; set; } = new List<int>();
        public decimal MontoInicial { get; set; }
    }
}
