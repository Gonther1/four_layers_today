using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Application.Repositories;

public class StateRepository : GenericRepository<State>, IStateRepository
{
    private readonly WebApiContext _context;

    public StateRepository(WebApiContext context) : base(context)
    {
        _context = context;
    }
}
