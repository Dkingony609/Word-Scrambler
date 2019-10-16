using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace Word_Scrambler
{
    public class Input
    {

        public void InputMethod()
        {
            Console.WriteLine("Select A Method Of Input : " + "\n" + "1. File Method" + "\n" + "2. Manual Method");
            Console.WriteLine("==========================");
            int request = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");

            if (request == 1)
            {
                File_Class file = new File_Class();
                file.FilePath();
            }
            else if (request == 2)
            {
                Manual_Class manually = new Manual_Class();
                manually.Manually();
            }
            else
            {
                Console.WriteLine("! Incorrect Input Format");
                for (int i = 0; i >= 0; i++)
                {
                    InputMethod();
                }
            }


        }
    }
}
