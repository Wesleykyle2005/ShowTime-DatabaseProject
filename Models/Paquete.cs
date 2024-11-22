using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Paquete
{
    public int IdPaquete { get; set; }

    public string NombrePaquete { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Disponibilidad { get; set; }

    public decimal Costo { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();

    public virtual ICollection<PaqueteServicio> PaqueteServicios { get; set; } = new List<PaqueteServicio>();
}
