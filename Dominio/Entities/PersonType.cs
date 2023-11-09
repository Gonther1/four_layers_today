using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class PersonType : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
