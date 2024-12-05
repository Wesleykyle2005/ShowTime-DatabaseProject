using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public int? IdPaquete { get; set; }

    public int IdCliente { get; set; }

    public DateOnly FechaReserva { get; set; }

    public DateOnly FechaInicio { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string Ubicacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CantidadDeAsistentes { get; set; }

    public string? DetallesAdicionales { get; set; }

    public decimal CostoTotal { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<EventoServicio> EventoServicios { get; set; } = new List<EventoServicio>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Paquete? IdPaqueteNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<RolEmpleadoEvento> RolEmpleadoEventos { get; set; } = new List<RolEmpleadoEvento>();
}
