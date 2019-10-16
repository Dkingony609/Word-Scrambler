using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace Word_Scrambler
{
    public class Manual_Class
    {
        public bool Comparer(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        count += 1;
                    }
                }
            }
            if (count == a.Length && count == b.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Manually()
        {
            Console.WriteLine();
            Console.WriteLine("Please Input Scrambled Words (Please seperate with a comma(,) )");
            Console.WriteLine();
            Console.WriteLine("Note : Case Sensitive ( USE lowercase )");

            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine("UNSCRAMBLE WORDS");
            Console.WriteLine();
            Console.WriteLine("=========================================");

            string compare = File.ReadAllText(@"C:\TestFolder\Unscrambled.txt");

            string[] compareSplit = compare.Split(',');

            foreach (string value in compareSplit)
            {
                Console.WriteLine(" " + value);
            }

            Console.WriteLine("=========================================");

            string wordInput = Console.ReadLine();

            string[] getInput =  wordInput.Split(',');
            Console.WriteLine("=========================================");

            foreach (string value in getInput)
            {
                Console.WriteLine(" " + value);
            }

            for (int i = 0; i < getInput.Length; i++)
            {
                for (int j = 0; j < compareSplit.Length; j++)
                {
                    if (Comparer(getInput[i], compareSplit[j]))
                    {
                        Console.WriteLine(getInput[i] + " : " + compareSplit[j] + " : Matched");
                    }
                }
            }

            //Console.WriteLine("File Contains The Words");
            //Console.WriteLine("Words Not Found");
            //for (int i = 0; i <= 0; i++)
            //{
            //Manually();
            //}              
        }
    }
}
