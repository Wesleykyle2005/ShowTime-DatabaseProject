using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Utileria
{
    public int IdUtileria { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Cantidad { get; set; }

    public virtual ICollection<ServicioUtilerium> ServicioUtileria { get; set; } = new List<ServicioUtilerium>();
}
