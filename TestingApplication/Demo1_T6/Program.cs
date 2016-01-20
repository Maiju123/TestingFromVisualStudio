using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give distance of your trip: ");
            string line = Console.ReadLine();
            int kmeters = int.Parse(line);
            double kulutus = kmeters * 7.02 / 100;
            double bensa = kulutus * 1.595;

            Console.WriteLine("You use {0} GAS, and it cost {1} euros.", bensa, kulutus);
        }
    }
}
