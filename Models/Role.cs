using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<RolEmpleadoEvento> RolEmpleadoEventos { get; set; } = new List<RolEmpleadoEvento>();
}
