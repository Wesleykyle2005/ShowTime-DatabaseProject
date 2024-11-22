using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class ServicioUtilerium
{
    public int IdServicioUtileria { get; set; }

    public int IdServicio { get; set; }

    public int IdUtileria { get; set; }

    public virtual Servicio IdServicioNavigation { get; set; } = null!;

    public virtual Utileria IdUtileriaNavigation { get; set; } = null!;
}
