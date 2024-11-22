using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string NombreServicio { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Costo { get; set; }

    public virtual ICollection<EventoServicio> EventoServicios { get; set; } = new List<EventoServicio>();

    public virtual ICollection<PaqueteServicio> PaqueteServicios { get; set; } = new List<PaqueteServicio>();

    public virtual ICollection<ServicioUtilerium> ServicioUtileria { get; set; } = new List<ServicioUtilerium>();
}
