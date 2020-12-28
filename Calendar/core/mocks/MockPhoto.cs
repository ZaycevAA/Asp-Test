using Calendar.core.interfaces;
using Calendar.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.mocks
{
    public class MockPhoto : IPhoto
    {
        public IEnumerable<photo> Photos
        {
            get
            {
                return new List<photo>{
                    new photo{ id=1, name="js", img=@"\img\AutoSave_0257_640x360.bmp"},
                    new photo{ id=2, name="css", img=@"\img\QuickSave_640x360.bmp"}
                };
            }
        }

        public photo GetPhoto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
