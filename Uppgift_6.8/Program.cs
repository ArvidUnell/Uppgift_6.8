using System;
namespace Uppgift_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int tal = ReadInt();

            Console.WriteLine($"Det finns {NrPrimtalUnder(tal)} primtal under {tal}");
        }
        /// <summary>
        /// Returnerar antalet primtal under talet n
        /// </summary>
        /// <param name="n">Talet n</param>
        /// <returns>Hur många primtal som finns under n</returns>
        static int NrPrimtalUnder(int n)
        {
            int summa = 0;
            for (int i = 2; i < n; i++)
            {
                if (ÄrPrimt(i))
                {
                    summa++;
                }
            }
            return summa;
        }
        /// <summary>
        /// Kollar om ett tal är primt
        /// </summary>
        /// <param name="tal">Talet som ska kollas</param>
        /// <returns>Om talet är primt eller ej</returns>
        static bool ÄrPrimt(int tal)
        {
            if (tal == 1 || tal == 0)
            {
                return false;
            }

            for (int i = 2; i <= tal / 2; i++)
            {
                if (tal % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Läser in ett int-tal från användaren
        /// </summary>
        /// <returns>Talet användaren skrev</returns>
        static int ReadInt()
        {
            int tal;
            while (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Ogiltigt svar. Försök igen");
            }
            return tal;
        }
    }
}