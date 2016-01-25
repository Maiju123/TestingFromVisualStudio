using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1De
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            string line = Console.ReadLine();
            int luku = int.Parse(line);
            int summa = luku + luku;


            if (luku != 0) {
                Console.WriteLine("Anna luku: ");
                Console.ReadLine();
            }

            else if (luku == 0) {
                Console.WriteLine(summa);
            }


            /*do {
                Console.WriteLine("Anna luku: ");
                Console.ReadLine();
            }

            while (luku == 0);
            Console.WriteLine(summa);
                
         //   Console.WriteLine("Lukujen summa on yhteensä: {0}", summa);
           

            /*       Console.WriteLine("Anna luku: ");
                     line = Console.ReadLine();
                     int luku2 = int.Parse(line);

                     Console.WriteLine("Anna luku: ");
                     line = Console.ReadLine();
                     int luku3 = int.Parse(line); */
        }
    }
}
