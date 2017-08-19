using SimbaCapital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbaCapital.Service
{

    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int Id);
    }
}
