using Calendar.core.mocks;
using Calendar.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewsModels
{
    public class PhotoList
    {
        public IEnumerable<photo> Potos { get; set; } 
        public IEnumerable<type> Types { get; set; } 
        public IEnumerable<typephoto> TypePhotos { get; set; } 
        public string Titel { get; set; }
    }
}
