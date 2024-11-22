using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? CorreoElectronico { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
