using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Rows = 0; Rows < 25; Rows++) //skriver först en rad Rows = 0 ändras beroende på vilken rad den loopar!
            {

                switch (Rows % 3) // kör först 0 % 3 villket resulterar i 0 då det finns ingen rest!

                    {
                    
                    case 0: 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                    case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                    case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                    }

                for (int Columns = 0; Columns < 39; Columns++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();

                if (Rows % 2 == 0) // kör nu om Rows = 0 efter Rows % 2 = 0 så gör if satsen ett extra mellanslag!
                {
                    Console.Write(" ");
                }

                Console.ResetColor();

            }
        }
    }
}
