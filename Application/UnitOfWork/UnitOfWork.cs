using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Dominio.Data;
using Dominio.Interfaces;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly WebApiContext _context;
    public CityRepository _cities;
    public CountryRepository _countries;
    public CustomerRepository _customers;
    public PersonTypeRepository _personstypes;
    public StateRepository _states;
    
    public ICityRepository Cities
    {
        get 
        {
            if (_cities == null)
            {
                _cities = new CityRepository(_context);
            }
            return _cities;
        }
    }
    public ICountryRepository Countries
    {
        get 
        {
            if (_countries == null)
            {
                _countries = new CountryRepository(_context);
            }
            return _countries;
        }
    }
    public ICustomerRepository Customers
    {
        get 
        {
            if (_customers == null)
            {
                _customers = new CustomerRepository(_context);
            }
            return _customers;
        }
    }
    public IPersonTypeRepository PersonsTypes
    {
        get 
        {
            if (_personstypes == null)
            {
                _personstypes = new PersonTypeRepository(_context);
            }
            return _personstypes;
        }
    }
    public IStateRepository States
    {
        get 
        {
            if (_states == null)
            {
                _states = new StateRepository(_context);
            }
            return _states;
        }
    }
    public UnitOfWork(WebApiContext context)
    {
        _context = context;
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
