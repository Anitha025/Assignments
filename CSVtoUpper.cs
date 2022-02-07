using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class CSVtoUpper
    {
        public static void DumpandUpper()
        {
            string name = @"C:\Users\Anitha\source\repos\Assignments2\Assignments2\EmpData.csv";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {
            DumpandUpper();
        }
    }
    
}

