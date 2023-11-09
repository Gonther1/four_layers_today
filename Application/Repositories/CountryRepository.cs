using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class CountryRepository : GenericRepository<Country>, ICountryRepository
{
    private readonly WebApiContext _context;

    public CountryRepository(WebApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Country> GetPaisByName(string country)
    {
        return await _context.Countries.Where(_country => _country.Name.Trim().ToLower() == country.Trim().ToLower()).FirstAsync();
    }
}
