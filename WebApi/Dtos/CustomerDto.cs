using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos;

public class CustomerDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Idcustomer { get; set; } = null!;
    public int IdTipoPersonaFk { get; set; }
    public int IdcityFk { get; set; }
}
