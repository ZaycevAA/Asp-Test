using Calendar.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.interfaces
{
    public interface IPhotoType
    {
        public IEnumerable<typephoto> PhotoTypes { get;}
        public IEnumerable<typephoto> TypePhotos { get;}
    }
}
