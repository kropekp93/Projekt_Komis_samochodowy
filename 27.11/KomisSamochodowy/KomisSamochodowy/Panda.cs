using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Panda : Fiat
    {
        public override string wyswietlModel()
        {
            return "Panda";
        }
    }
}
