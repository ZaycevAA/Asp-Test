using Calendar.core.interfaces;
using Calendar.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.mocks
{
    public class MockTypePhoto : IPhotoType
    {
    
        private static readonly ITypes _types = new MockType();
        private static readonly IPhoto _photos = new MockPhoto();

        private List<typephoto> typephotos = new List<typephoto>
        {
            new typephoto{ id=1, photo=_photos.Photos.First(),type=_types.Types.Last() },
            new typephoto{ id=1, photo=_photos.Photos.Last(),type=_types.Types.First() },
        };
       
        public IEnumerable<typephoto> PhotoTypes { get => typephotos; }
        public IEnumerable<typephoto> TypePhotos { get => typephotos; }
    }
}
