using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Application.Repositories;

public class CityRepository : GenericRepository<City>, ICityRepository
{
    private readonly WebApiContext _context;

    public CityRepository(WebApiContext context) : base(context)
    {
        _context = context;
    }
}
