using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class PatternMatch
    {
        public static void star()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //PatternMatch p = new PatternMatch();
            star();
        }
    }
}
