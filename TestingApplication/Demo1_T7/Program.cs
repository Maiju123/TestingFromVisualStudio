using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosi: ");
            string line = Console.ReadLine();
            int year = int.Parse(line);
            int vuosi = year / 4;
            int taysvuosi = year / 4 * 100;
            int vuosisadat = year / 400;

            if (year % 4 == 0) {
                if (vuosi % 100 == 0) {
                    if (vuosi % 400 == 0) {
                        Console.WriteLine("On karkausvuosi.");
                    } else
                    {
                        Console.WriteLine("Ei ole karkausvuosi.");
                    }
                } else 
                    {
                        Console.WriteLine("On Karkausvuosi.");}
            }
            else 
                    {
                        Console.WriteLine("Ei ole karkausvuosi.");
            }
        }
    }
}

