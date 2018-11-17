using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Motocykl : Pojazd
    {
        public override string wyswietlTypPojazdu()
        {
            return "Motocykl";

        }
    }
}
