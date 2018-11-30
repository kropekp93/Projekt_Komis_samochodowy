using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    abstract class Pojazd : Program
    { 
         private int iRokProdukcji;
         private float fCenaZakupu;
         private float fMarza;
         public Pojazd (int year, float price, float sallary)
        {  
            iRokProdukcji = year;     
            fCenaZakupu = price;
            fMarza = sallary;
        }
            int RokProdukcji
        {
            get
            {
                return iRokProdukcji;
            }
        }
           float CenaZakupu
        {
            get
            {
                return fCenaZakupu;
            }
        }
         float Marza
        {
            get
            {
                return fMarza;
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

     //   public abstract string wyswietlMarke();
      //  public abstract string wyswietlModel();
      //  public abstract string wyswietlTypPojazdu(); 

     
        
       
     

    }
}
