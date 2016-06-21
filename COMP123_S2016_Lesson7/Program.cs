using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // pseudo number object 

            int firstDie = random.Next(1, 7);
            int secondDie = random.Next(1, 7);
            int dice = firstDie + secondDie;

            Console.WriteLine("First: {0}", firstDie);
            Console.WriteLine("Second: {0}", secondDie);
            Console.WriteLine("Result: {0}", dice);
        }
    }
}
