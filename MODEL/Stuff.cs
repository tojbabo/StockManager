﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.MODEL
{
    public class Stuff
    {
        public int id { get; set; }
        public string name { get; set; }

        public string ToString()
        {
            return $"{id},{name}";
        }
    }
}
