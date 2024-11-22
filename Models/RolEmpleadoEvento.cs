using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class RolEmpleadoEvento
{
    public int IdRolEmpleadoEvento { get; set; }

    public int IdEvento { get; set; }

    public int IdEmpleado { get; set; }

    public int IdRol { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Evento IdEventoNavigation { get; set; } = null!;

    public virtual Role IdRolNavigation { get; set; } = null!;
}
