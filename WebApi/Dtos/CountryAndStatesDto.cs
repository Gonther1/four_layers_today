using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace WebApi.Dtos;

public class CountryAndStatesDto
{
    public int Id { get; set; }    
    public string NamePais { get; set; }
    public List<State> States { get; set; }
}
