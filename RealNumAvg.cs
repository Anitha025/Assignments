using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class RealNumAvg
    {

        public static void RealNums()
        {
            int PositiveSum = 0;
            int NagetiveSum = 0;
            int PositiveCount = 0;
            int NagetiveCount = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter The Numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    PositiveCount += 1;
                    PositiveSum += n;
                }
                else
                {
                    NagetiveCount += 1;
                    NagetiveSum += n;
                }
            }
            try
            {
                Console.WriteLine($"The Average of the Positive numbers is: {PositiveSum / PositiveCount} and Average of Negative Numbers is: {NagetiveSum / NagetiveCount}");
            }
            catch (Exception)
            {

                throw new Exception("Please add Some Negative values to Process");
            }

        }
        public static void Main(string[] args)
        {
            RealNums();
        }
    }
}
