using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Dominio.Interfaces;

public interface ICountryRepository : IGenericRepository<Country>
{
    Task<Country> GetPaisByName(string name);
    Task<Country> GetCountryAndStates();
/*     Task<IEnumerable<Country>> GetCountriesAndStates();
    Task<IEnumerable<Country>> GetCountriesAndCities(); */
}
