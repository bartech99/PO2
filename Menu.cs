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
                    Support.WriteCol("Niepoprawny wybor!", "DY");
                    Support.PressEnter();
                }
            }
        }

        public int MainList()
        {
            Support.WriteCol("--- MENU ---", "G");
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
                Support.WriteCol("Zly format", "R");
                choise = 0;
                Support.PressEnter();
            }
            Console.ResetColor();
            Console.Clear();
            return choise;
        }

        public int ConditionalList()
        {
            Support.WriteCol("--- MENU WARUNKOW ---", "G");
            Console.WriteLine();
            Console.WriteLine("Wyswietl wedlug:");
            Console.WriteLine("1. Marki");
            Console.WriteLine("2. Roku produkcji");
            Console.WriteLine("3. Pojemnosci silnika");
            Console.WriteLine("4. Przebiegu");
            Console.WriteLine("5. Rodzaju skrzyni biegów");
            Console.WriteLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Twoj wybor: ");

                try { Choise = int.Parse(Console.ReadLine()); }
                catch
                {
                    Support.WriteCol("Zly format!", "R");
                    choise = 0;
                    Support.PressEnter();
                }
                Console.Clear();

                if(choise < 1 || choise > 5) { Support.WriteCol("Niepoprawny wybor", "DY"); }

            } while (choise < 1 || choise > 5);
            
            return choise;
        }
        


        public Menu(int choise = 0)
        {
            this.choise = choise;
        }
    }
}
