using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Application.Repositories
{
    public class PersonTypeRepository : GenericRepository<PersonType>, IPersonTypeRepository
    {
        private readonly WebApiContext _context;
    
        public PersonTypeRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}