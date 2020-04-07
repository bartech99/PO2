using System;
using Handling;
using CarsData;

namespace PO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Cars cars = new Cars();
            FileSupport file = new FileSupport();

            bool ifData = false;

            while (menu.MainList() != 9)
            {
                if (menu.Choise != 0)
                {
                    switch (menu.Choise)
                    {
                        case 1:

                            Support.WriteCol("--- Wczytywanie z pliku ---", "G");
                            Console.WriteLine();
                            file.GetTitle();
                            ifData = file.Read(cars);//dodać pytanie czy opróżnić wektor
                            break;

                        case 2:

                            Support.WriteCol("--- Zapis do pliku ---", "G");
                            Console.WriteLine();
                            file.GetTitle();
                            file.Save(cars);//dodać weryfikację
                            break;

                        case 3:

                            Support.WriteCol("--- Dodawanie samochodu do bazy ---", "G");
                            cars.Add();
                            break;

                        case 4:

                            Support.WriteCol("--- Usuwanie samochodu z bazy ---", "G");
                            Console.WriteLine();
                            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                            break;

                        case 5:

                            Support.WriteCol("--- Wszystkie samochody ---", "G");
                            Console.WriteLine();
                            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                            cars.PrintAll();
                            break;

                        case 6:

                            menu.ConditionalList();
                            Support.WriteCol("--- Warunowa lista samochodow ---", "G");
                            Console.WriteLine();
                            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                            break;

                        case 7:

                            Support.WriteCol("--- Wyszukiwanie samochodu ---", "G");
                            Console.WriteLine();
                            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                            break;

                        case 8:

                            Support.WriteCol("--- Posortowana lista samochodow ---", "G");
                            Console.WriteLine();
                            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                            break;
                    }
                    Support.PressEnter();
                }
            }
        }
    }
}