﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Ford : Samochod
    {
        public override string wyswietlMarke()
        {
            return "Ford";
        }
    }
}
