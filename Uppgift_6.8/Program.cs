using System;
namespace Uppgift_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ÄrPrimt(27));
            Console.WriteLine(ÄrPrimt(37));
        }
        /// <summary>
        /// Kollar om ett tal är primt
        /// </summary>
        /// <param name="tal">Talet som ska kollas</param>
        /// <returns>Om talet är primt eller ej</returns>
        static bool ÄrPrimt(int tal)
        {
            if (tal == 1)
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
    }
}