using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public virtual ICollection<RolEmpleadoEvento> RolEmpleadoEventos { get; set; } = new List<RolEmpleadoEvento>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
