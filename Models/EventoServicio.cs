using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class EventoServicio
{
    public int IdEventoServicios { get; set; }

    public int IdEvento { get; set; }

    public int IdServicio { get; set; }

    public virtual Evento IdEventoNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
