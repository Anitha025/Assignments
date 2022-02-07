using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class ArrayToCSV
    {
        public static void ArrayFile()
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Greetings";
            files[0, 1] = "Hi";
            files[0, 2] = "Hello";
            files[0, 3] = "Good Morning";
            files[0, 4] = "Good Afternoon";

            files[1, 0] = "Good night";
            files[1, 1] = "Welcome";
            files[1, 2] = "Have a Good Day";
            files[1, 3] = "Nice to meet you";
            files[1, 4] = "See u soon";

            StreamWriter sw = File.CreateText("ReadFile.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");

        }
        public static void Main(string[] args)
        {
            ArrayFile();
        }
    }
}
