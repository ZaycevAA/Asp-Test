﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.core.models
{
    public class photo
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<typephoto> typephotos { get; set; }
        public string img { get; set; }
    }
}