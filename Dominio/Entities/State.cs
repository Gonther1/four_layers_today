using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class State : BaseEntity
{

    public string Name { get; set; } = null!;

    public int IdcountryFk { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country IdcountryFkNavigation { get; set; } = null!;
}
