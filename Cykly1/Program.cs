using System;
using System.Threading; // Tento namespace je třeba pro metodu Thread.Sleep

namespace Cykly
{
    class Program
    {  
        // Ukázkový program pro zápis iteračních cyklů a základy metod
        static void Main(string[] args)
        {
            Console.WriteLine("Přesně za 2,5 vteřiny napišeš za trest 100 krát : \"Už nikdy nebudu házet křídou po spolužákovi!\" !!");
            Thread.Sleep(2500); // Uspí hlavní vlákno programu na 2500 milisekund

            // Cha, tak to pro mě není žádný trest...
            for (int i = 1; i <= 100; i++) // -> provádí se, dokud platí, že i < 100
                Console.WriteLine("Už nikdy nebudu házet křídou po spolužákovi!");

           
            
            Console.WriteLine("Odpočívej 3 vteřiny...");
            Console.WriteLine("... a pak jistotu ještě jednou to samé 100x...");
            
            Thread.Sleep(3000); // Zase uspí program na 3000 milisekund...

            // A teď to samé, jenom zapsáno trochu jinak...
            int k = 0; 
            while (k < 100) // -> provádí se, dokud platí, že k < 100
            {
                Console.WriteLine("Už nikdy nebudu házet křídou po spolužákovi!");
                k++;
            }
                        
            
            Console.WriteLine("Odpočívej 3 vteřiny...");
            Console.WriteLine("... a pak vypíšeš všechna čísla od 10 do 1...");
            Thread.Sleep(3000);

            
            k = k/10; // poděl k 10 (=> k = 10)

            for (; k > 0; k--) // -> provádí se, dokud platí k > 0
               Console.WriteLine("{0}", k);



            Console.WriteLine(); // Vypíše prázný řádek - tzn. "odřádkuje"
            Console.WriteLine("Pětkrát pípni!");

            // Cyklus o pěti iteracích zapsaný trošku jinak:
            for (;;)
            {
                if (k == 5) // Když je k rovno pěti ...
                  break;    //... skončí cyklus a vystoupí z bloku

                Console.WriteLine("\a"); // Tento speciální znak vypsaný do konzole by měl generovat pípnutí speakru
                ++k;
            }



            // ... a nakonec
            Console.WriteLine("Teď sečteš všechna čísla od 1 do 10...");
            int součet = SečtiVšechnaČísla(1, 10);
            Console.WriteLine("Dobře, výsledek je {0}", součet);

            Console.Read();
        }

        /// <summary>
        /// Sčítá všechna čísla v daném rozmezí
        /// </summary>
        /// <param name="OdČísla">Dolní mez sumy</param>
        /// <param name="doČísla">Horní mez sumy</param>
        /// <returns>Suma všech čísel v daných mezích</returns>
        static int SečtiVšechnaČísla(int OdČísla, int doČísla)
        {
            int výsledek = 0;
            for (int k = OdČísla; k <= doČísla; k++)
                výsledek += k;

            return výsledek;
        }
    }
}
