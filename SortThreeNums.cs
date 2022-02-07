using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class SortThreeNums
    {
        public static void SortNums()
        {
            Console.WriteLine("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a >= b) && (a >= c))
            {
                if (b >= c)
                {
                    Console.WriteLine($"Ascending order: {a},{b},{c}");

                }
                else
                {
                    Console.WriteLine($"Ascending order: {b},{c},{a}");
                }
            }
            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    Console.WriteLine($"Ascending order: {c},{a},{b}");
                }
                else
                {
                    Console.WriteLine($"Ascending order: {a},{c},{b}");
                }
            }
            else if ((c >= a) && (c >= b))
            {
                if (a >= b)
                {
                    Console.WriteLine($"Ascending order: {b},{a},{c}");
                }
                else
                {
                    Console.WriteLine($"Ascending order: {a},{b},{c}");
                }
            }
        }
        static void Main(string[] args)
        {
            SortNums();
        }
    }
}
