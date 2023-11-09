using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class City : BaseEntity
{
    public string Name { get; set; } = null!;

    public int IdstateFk { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual State IdstateFkNavigation { get; set; } = null!;
}
