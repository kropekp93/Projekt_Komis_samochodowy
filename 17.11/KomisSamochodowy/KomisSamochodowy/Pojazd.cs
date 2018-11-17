using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Pojazd : Program
    { 
    private float fCenaZakupu = 0;
    private float fMarza = 0;
    private int iRokProdukcji = 0;

        float Marza
        {
            get
            {
                return fMarza;
            }
        }
        float CenaZakupu
        {
            get
            {
                return fCenaZakupu;
            }
        }
        int RokProdukcji
        {
            get
            {
                return iRokProdukcji;
            }
        }

        void wyswietlRok()
        {
            Console.WriteLine("ROK##ROK##");
        }

        float podajCeneKoncowa()
        {
            return CenaZakupu + Marza;
        }

        public abstract string wyswietlMarke();
        public abstract string wyswietlModel();
        public abstract string wyswietlTypPojazdu(); 

     
        
       
     

    }
}
