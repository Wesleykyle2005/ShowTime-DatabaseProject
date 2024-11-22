using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class VistaEventosDisponiblesPorPaquete
{
    public int IdEvento { get; set; }

    public DateOnly FechaInicio { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string Ubicacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CantidadDeAsistentes { get; set; }

    public string? DetallesAdicionales { get; set; }

    public string NombrePaquete { get; set; } = null!;

    public decimal CostoPaquete { get; set; }
}
