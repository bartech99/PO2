using System;

namespace Handling
{
    static class Menu
    {
        public static int MainList()
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

            int choise = GetChoise(1,9);            
            Console.Clear();
            return choise;
        }

        public static int ConditionalList()
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
            Console.ForegroundColor = ConsoleColor.Green;

            return GetChoise(1, 5);
        }

        public static int SortingList()
        {
            Support.WriteCol("--- MENU SORTOWANIA ---", "G");
            Console.WriteLine();
            Console.WriteLine("Sortuj wedlug:");
            Console.WriteLine("1. Marki alfabetycznie");
            Console.WriteLine("2. Modelu alfabetycznie");
            Console.WriteLine("3. Roku produkcji");
            Console.WriteLine("4. Pojemnosci silnika");
            Console.WriteLine("5. Przebiegu");
            Console.WriteLine("6. Rodzaju skrzyni biegów");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            return GetChoise(1, 6);
        }

        public static int SortingDeOrIn()
        {
            Support.WriteCol("0 - rosnaco, 1 - malejaco","G");
            return GetChoise(0, 1);
        }
        
        public static int GetChoise(int a, int b)
        {
            int choise;

            while (true)
            {
                try
                {                  
                    Console.Write("Twoj wybor: ");
                    choise = int.Parse(Console.ReadLine());

                    if (choise < a || choise > b)
                    {
                        Support.WriteCol("Niewlasciwy wybor!", "DY");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Support.WriteCol("Niepoprawny format", "R");
                }
            }

            Console.ResetColor();
            return choise;
        }
    }
}
