using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pojazd> listaPojazdow = new List<Pojazd>();
            //listaPojazdow.Add

            void DodajPojazd()
            {
                Console.Clear();
                Console.WriteLine("### Samochód ###:");
                Console.WriteLine("#Ford");
                Console.WriteLine("  1. Mustang");
                Console.WriteLine("  2. Ranger");
                Console.WriteLine("#Fiat");
                Console.WriteLine("  3. Panda");
                Console.WriteLine("  4. Multipla");
                Console.WriteLine("### Motocykl ###");
                Console.WriteLine("#Suzuki");
                Console.WriteLine("  5. SuperSport");
                Console.WriteLine("#Honda");
                Console.WriteLine("###");
                Console.WriteLine("  0. Powrót");


                int number;
                string input = Console.ReadLine();
                bool tryToParse = Int32.TryParse(input, out number);
                if(tryToParse)
                    {
                        switch (number)
                        {
                        case 1:
                            Console.WriteLine("Chcesz dodać Forda Mustanga?");
                            Console.WriteLine("Podaj XYZ");
                            Console.ReadLine();
                            DodajPojazd();
                            break;
                        case 2:
                            Console.WriteLine("Chcesz dodać Forda Rangera?");
                            Console.ReadLine();
                            DodajPojazd();
                            break;
                        case 3:
                            Console.WriteLine("Chcesz dodać Fiata Pande?");
                            Console.ReadLine();
                            DodajPojazd();
                            break;
                        case 4:
                            Console.WriteLine("Chcesz dodać Fiata Multiple?");
                            Console.ReadLine();
                            DodajPojazd();
                            break;
                        case 5:
                            Console.WriteLine("Chcesz dodać Suzuki SuperSport??");
                            Console.ReadLine();
                            DodajPojazd();
                            break;
                        case 0: 
                            Menu();
                            break;
                        default:
                            Console.WriteLine("Buraku, nie ma takiej opcji! (enter)");
                            Console.ReadLine();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    }
                else
                        {   
                            Console.WriteLine("Eee... Kolego potrzebujesz elementarza? (enter)");
                            Console.ReadLine();
                            Console.Clear();
                            DodajPojazd();
                        }
            }




             void Powrot()
            {
                Console.WriteLine("0. Powrót");
                int number;
                string input = Console.ReadLine();
                bool tryToParse = Int32.TryParse(input, out number);
                if (number == 0) 
                {   
                Console.Clear();
                Menu();
                }      
                else
                    {
                Console.WriteLine("Eee... Kolego potrzebujesz elementarza? (enter)");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();

                    }
            }

             void Menu()
             {
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine("$$$$$$$ KOMIS MIRKA $$$$$$$");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine("1. Wyświetl listę pojazdów");
                Console.WriteLine("2. Dodaj nowy pojazd");
                Console.WriteLine("3. Wyszukaj pojazdy");
                Console.WriteLine("4. Sprzedaj pojazd");  
                Console.WriteLine("0. Menu");
                int number;
                string input = Console.ReadLine();
                bool tryToParse = Int32.TryParse(input, out number);
                if(tryToParse)
                    {
                        switch (number)
                        {
                        case 1:
                        
                            Console.WriteLine("### Lista Pojazdów ###");
                            Console.WriteLine("WYSWIETLAM LISTE POJAZDOW");
                            Powrot();
                            break;
                        case 2:
                            Console.WriteLine("### Dodaj nowy pojazd ###");
                            DodajPojazd();
                            break;
                        case 3:
                            Console.WriteLine("### Wyszukaj pojazdy ###");
                            Powrot();
                            break;
                        case 4:
                            Console.WriteLine("### Sprzedaj pojazd ###");
                            Powrot();
                            break;
                        case 0: 
                            Menu();
                            break;
                        default:
                            Console.WriteLine("Buraku, nie ma takiej opcji! (enter)");
                            Console.ReadLine();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    }
                else
                        {
                            Console.WriteLine("Eee... Kolego potrzebujesz elementarza? (enter) ");
                            Console.ReadLine();
                            Console.Clear();
                            Menu();
                        }

             }  


            Menu();






        }
    }
}
