using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class PaqueteServicio
{
    public int IdPaqueteServicios { get; set; }

    public int IdPaquete { get; set; }

    public int IdServicio { get; set; }

    public virtual Paquete IdPaqueteNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
