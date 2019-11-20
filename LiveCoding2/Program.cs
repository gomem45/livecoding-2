using System;

namespace LiveCoding2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = {
                "aaa",
                "a",
                "bdsagbgagggaaatttyyyyau",
                "abcdefghijklmnopqrstuvwxyz",
                ""
            };

            string maxWord = "";
            int wordCount = 0;

            foreach (string chr in test)
            {
                if (chr.Length > wordCount)
                {
                    wordCount = chr.Length;
                    maxWord = chr;
                }
            }

            Console.WriteLine("Longest string of chars: {0} \nLenght of longest chars: {1}", maxWord, wordCount);
            Console.ReadLine();
            
        }
    }
}
