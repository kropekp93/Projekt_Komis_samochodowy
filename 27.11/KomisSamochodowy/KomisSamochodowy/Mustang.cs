using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Mustang : Ford
    {
        public override string wyswietlModel()
        {
            return "Mustang";
        }
    }
}
