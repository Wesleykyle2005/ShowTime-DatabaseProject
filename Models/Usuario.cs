﻿using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdEmpleado { get; set; }

    public int IdCargo { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
}
