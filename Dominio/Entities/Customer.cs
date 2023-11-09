using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Customer : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Idcustomer { get; set; } = null!;

    public int IdTipoPersonaFk { get; set; }

    public DateOnly DateRegister { get; set; }

    public int IdcityFk { get; set; }

    public virtual PersonType IdTipoPersonaFkNavigation { get; set; } = null!;

    public virtual City IdcityFkNavigation { get; set; } = null!;
}
