﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Ranger : Ford
    {
        public override string wyswietlModel()
        {
            return "Ranger";
        }
    }
}
