using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Word_Scrambler
{
    public class File_Class
    {
        public bool Comparer(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int count = 0;

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if(a[i] == b[j])
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
        public void FilePath()
        {
            Console.WriteLine();
            Console.WriteLine("SCRAMBLED WORDS");

            Console.WriteLine("==========================");

            //Scrambled Text File Reader
            string readFile = File.ReadAllText(@"C:\TestFolder\Scrambled.txt");

            string[] scrambledSplit = readFile.Split(',');

            foreach (string item in scrambledSplit)
            {
                Console.WriteLine(" " + item);
            }

            //Unscrambled Text File Reader
            Console.WriteLine();
            Console.WriteLine("UNSCRAMBLED WORDS");
            string compare = File.ReadAllText(@"C:\TestFolder\Unscrambled.txt");

            string[] unscrambledSplit = compare.Split(',');

            foreach (string value in unscrambledSplit)
            {
                Console.WriteLine(" " + value);
            }   
            
            for(int i = 0; i < scrambledSplit.Length; i++)
            {
                for(int j = 0; j < unscrambledSplit.Length; j++)
                {
                    if (Comparer(scrambledSplit[i], unscrambledSplit[j]))
                    {
                        Console.WriteLine(scrambledSplit[i]+" : " +unscrambledSplit[j]+ " : Matched"  );
                    }
                    
                }
            }

        }

    }
}
