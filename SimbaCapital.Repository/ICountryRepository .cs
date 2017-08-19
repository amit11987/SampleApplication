using SimbaCapital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbaCapital.Repository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int id);
    }
}
