using System;
using System.Collections.Generic;

namespace PruebaVideo4.Models;

public partial class Empleado
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public long? IdArea { get; set; }

    public virtual Area? IdAreaNavigation { get; set; }
}
