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
            List<int> diceRolls = new List<int>();
            int[] tally = new int[13];
            int maxRolls = 5000000;

            for (int i = 0; i < maxRolls; i++)
            {
                 int firstDie = random.Next(1, 7);
                 int secondDie = random.Next(1, 7);
                 int dice = firstDie + secondDie;
                 tally[dice]++;
                 diceRolls.Add(dice);
            }
            
            // sort method 
            diceRolls.Sort();

            /** 
            // displays the list 
            foreach (int result in diceRolls) // replace the collection to the list 
            {
                Console.Write(result + " ");
            }
            Console.WriteLine(); */

            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine("{0}: {1} ", i, tally[i]);
            }
            
        }
    }
}
