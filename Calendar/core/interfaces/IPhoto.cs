using Calendar.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.interfaces
{
    public interface IPhoto
    {
        public IEnumerable<photo> Photos { get; }
        photo GetPhoto(int id);
    }
}
