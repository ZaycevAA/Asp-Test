using System;
using Calendar.core.models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.core.interfaces;

namespace Calendar.core.mocks
{
    public  class MockType : ITypes
    {
        public  IEnumerable<type> Types
        {
            get
            {
                return new List<type>
                {
                    new type{ id= 1, name="text"},
                    new type{ id= 2, name="art"}
                };

            }


        }
        public type GetType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
