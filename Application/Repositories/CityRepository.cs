using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class CityRepository : GenericRepository<City>, ICityRepository
{
    private readonly WebApiContext _context;

    public CityRepository(WebApiContext context) : base(context)
    {
        _context = context;
    }
    public async Task<City> GetCustomerByCityName(string city)
    {
        return await _context.Cities.Where(_cities => _cities.Name.Trim().ToLower() == city.ToLower()).Include(s => s.Customers).FirstAsync();
    }
}
