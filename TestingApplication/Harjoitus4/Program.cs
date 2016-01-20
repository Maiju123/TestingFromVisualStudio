using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give age: ");
            string line = Console.ReadLine(); // "23"
            int age = int.Parse(line); // 23
            if (age < 18)
            {
                Console.WriteLine("You are under-age.");
            } else if (age >=18 && age <=65)
                {
                Console.WriteLine("You are adult.");
            } else
            {
                Console.WriteLine("You are senior.");
            }
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
