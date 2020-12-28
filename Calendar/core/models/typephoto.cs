using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.models
{
    public class typephoto
    {
        public int id { get; set; }
        public virtual type type { get; set; }
        public virtual photo photo { get; set; }
    }
}
