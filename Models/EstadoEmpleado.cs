using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class EstadoEmpleado
{
    public int IdEstado { get; set; }

    public string TipoEstado { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
