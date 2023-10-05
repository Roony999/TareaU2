﻿using System;
using System.Collections.Generic;

namespace TareaU2.Models;

public partial class Clase
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Especies> Especies { get; set; } = new List<Especies>();
}
