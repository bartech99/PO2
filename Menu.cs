using System;
using System.Collections.Generic;
using System.Text;

namespace Handling
{
    class Menu
    {
        private int choise;
        public int Choise 
        { 
            get => choise;
            private set
            {
                if (value >= 1 && value <= 9) { choise = value; }
                else
                {
                    choise = 0;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Niepoprawny wybor!");
                    PressEnter();
                }
            }
        }

        public int MainList()
        {
            WriteCol("--- MENU ---", "G");
            Console.WriteLine();
            Console.WriteLine("1. Wczytaj z pliku");
            Console.WriteLine("2. Zapisz wyniki w nowym pliku");
            Console.WriteLine();
            Console.WriteLine("3. Dodaj samochod");
            Console.WriteLine("4. Usun samochod");
            Console.WriteLine();
            Console.WriteLine("5. Wyswietl wszystkie samochody");
            Console.WriteLine("6. Wyswietl warunkowo liste samochodow");
            Console.WriteLine("7. Wyswietl dane pojedynczego samochodu");
            Console.WriteLine("8. Posortuj samochody");
            Console.WriteLine();
            Console.WriteLine("9. Wyjscie z programu");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Twoj wybor: ");

            try { Choise = int.Parse(Console.ReadLine()); }
            catch 
            { 
                WriteCol("Zly format", "R");
                choise = 0;
                PressEnter();
            }
            Console.ResetColor();
            Console.Clear();
            return choise;
        }

        public void PressEnter()
        {
            Console.WriteLine();
            WriteCol("Nacisnij ENTER, aby kontynuowac", "G");
            Console.ReadKey();
            Console.Clear();
        }



        public static void WriteCol(string text, string colour)
        {
            if (colour == "G") { Console.ForegroundColor = ConsoleColor.Green; }
            else if (colour == "R") { Console.ForegroundColor = ConsoleColor.Red; }
            else { Console.ForegroundColor = ConsoleColor.DarkYellow; }
            Console.WriteLine(text);
            Console.ResetColor();
        }



        public Menu(int choise = 0)
        {
            this.choise = choise;
        }
    }
}
