using System;
using System.Collections.Generic;
using System.Text;

namespace Handling
{
    static class Support
    {
        public static void PressEnter()
        {
            Console.WriteLine();
            WriteCol("Nacisnij ENTER, aby kontynuowac", "G");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static void WriteCol(string text, string colour)
        {
            if (colour == "G") 
            { 
                Console.ForegroundColor = ConsoleColor.Green; 
            }
            else if (colour == "R") 
            { 
                Console.ForegroundColor = ConsoleColor.Red; 
            }
            else 
            { 
                Console.ForegroundColor = ConsoleColor.DarkYellow; 
            }
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}