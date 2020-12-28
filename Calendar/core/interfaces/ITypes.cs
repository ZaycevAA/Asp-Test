using System;
using Calendar.core.models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.interfaces
{
    public interface ITypes
    {

        IEnumerable<type> Types { get;  }
        type GetType(int id); 
    }
}
