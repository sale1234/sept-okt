﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{

    [Serializable]
    public class Request
    {
        public object RequestObj { get; set; }
        public Operation Operation { get; set; }
    }
}
