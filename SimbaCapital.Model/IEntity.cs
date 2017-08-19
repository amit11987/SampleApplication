using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbaCapital.Model
{

    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
