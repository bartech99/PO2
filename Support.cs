using System;
using CarsData;

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

        public static void Clear(Cars c)
        {
            if (c.list.Count != 0)
            {
                string choise;

                Console.WriteLine("Baza danych programu zawiera juz dane. Czy chcesz je skasowac?");

                while (true)
                {
                    try
                    {
                        Console.Write("y - tak, n - nie: ");
                        choise = Console.ReadLine();

                        if (choise[0] == 'y')
                        {
                            c.list.Clear();
                            Console.WriteLine("Baza danych zostala oprozniona.");
                            break;
                        }
                        else if (choise[0] == 'n')
                        {
                            break;
                        }
                        else
                        {
                            Support.WriteCol("Niepoprawna wartosc!", "DY");
                        }
                    }
                    catch
                    {
                        Support.WriteCol("Niepoprawna wartosc!", "R");
                    }
                }
            }
        }
    }
}