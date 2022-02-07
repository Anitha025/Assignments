using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class TMul
    {
        public static void Tmultiply()
        {
            int a = 1;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (a <= 10)
            {
                Console.WriteLine($"{n} * {a} ={n * a }");
                a++;
            }
        }

        public static void Main(string[] args)
        {
            Tmultiply();
        }
    }
}
