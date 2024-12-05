using System;
using System.Collections.Generic;

namespace ShowTime_DatabseProject.Models;

public partial class Pago
{
    public int IdPago { get; set; }

    public int IdEvento { get; set; }

    public decimal Monto { get; set; }

    public DateOnly FechaPago { get; set; }

    public string MetodoPago { get; set; } = null!;

    public virtual Evento IdEventoNavigation { get; set; } = null!;
}
