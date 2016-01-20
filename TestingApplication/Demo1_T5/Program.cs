using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_T5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give seconds: ");
            string line = Console.ReadLine();
            int secs = int.Parse(line);
            int hour = secs / 3600;
            int min = secs / 60 - hour * 60;
            int sec = secs % 60;

            Console.WriteLine("Time is: {0}hh {1}min {2}sec", hour, min, sec);
        }
        
    }
}
