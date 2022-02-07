using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class ReverseSentence
    {
        public static void Main(string[] args)
        {
            reversebywords();
        }
        static void reversebywords()
        {
            Console.WriteLine("Enter Your Sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
