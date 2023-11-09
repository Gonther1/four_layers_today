using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces;

public interface IUnitOfWork
{
    ICityRepository Cities { get; }
    ICountryRepository Countries { get; }
    ICustomerRepository Customers { get; }
    IPersonTypeRepository PersonsTypes { get; }
    IStateRepository States { get; }
    Task<int> SaveAsync();
}
