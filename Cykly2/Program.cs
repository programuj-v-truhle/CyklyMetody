using System;
using System.Threading;

namespace Cykly2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Krmivo generátoru vytvoř ze součinu momentální milisekundy a sekundy
            int mojeKrmivo = DateTime.Now.Millisecond*DateTime.Now.Second;
            int číslo = mojeKrmivo;
            
            // Generuj pseudonáhodné číslo...
            for (int i = 0; i < DateTime.Now.Second%5; i++)
               číslo = ZískejPseudonáhodnéČíslo(číslo);            

            // Vypiš číslo...
            Console.WriteLine("Pseudonáhodné číslo je : {0}, stiskni libovolnou klávesu pro pokračování...", číslo);
            Console.Read();

            // ...a teď vypiš všechna čísla od 1 do náhodného čísla a přitom přeskakuj všechna sudá
            VypisujČísla(1, číslo, 2);

            Console.Read();
        }

        /// <summary>
        /// Vypíše všechna čísla vyjma násobků daného čísla
        /// </summary>
        /// <param name="Od">Od čísla</param>
        /// <param name="Do">Do čísla</param>
        /// <param name="PřeskakujNásobky">Vynechat násobky tohoto čísla</param>
        static void VypisujČísla(int Od, int Do, int PřeskakujNásobky)
        {
            for (int k = Od; k <= Do; k++)
            {
                if (k > 0 && k % PřeskakujNásobky == 0)
                    continue;

                Console.WriteLine("{0}", k);
            }
        }

        /// <summary>
        /// Získá pseudonáhodné číslo von Neumannovou metodou prostředních čtverců
        /// </summary>
        /// <param name="Seed">Krmivo generátoru</param>
        /// <returns>Pseudonáhodné číslo</returns>
        static int ZískejPseudonáhodnéČíslo(int Seed)
        {
            Int64 NaDruhou = Seed * Seed;

            string ČísloJakoŘetězec = NaDruhou.ToString();
            
            int délka = ČísloJakoŘetězec.Length;

            while (ČísloJakoŘetězec.Length > (délka / 2)+1)
            {
                ČísloJakoŘetězec = ČísloJakoŘetězec.Remove(0, 1);
                ČísloJakoŘetězec = ČísloJakoŘetězec.Remove(ČísloJakoŘetězec.Length - 1, 1);
            }

            return int.Parse(ČísloJakoŘetězec);
            
        }
    }
}
