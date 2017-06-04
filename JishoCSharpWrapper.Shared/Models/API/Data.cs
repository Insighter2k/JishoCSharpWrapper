﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JishoCSharpWrapper.Shared.Models.API
{
    public class Data
    {
        public bool is_common { get; set; }
        public List<object> tags { get; set; }
        public List<Japanese> japanese { get; set; }
        public List<Senses> senses { get; set; }
        public Attribution attribution { get; set; }
    }
   
}
