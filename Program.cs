using System;
using Handling;
using CarsData;
using System.IO;

namespace PO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            FileSupport file = new FileSupport();

            bool ifData = false;

            while (true)
            {
                switch (Menu.MainList())
                {
                    case 1:

                        Support.WriteCol("--- Wczytywanie z pliku ---", "G");
                        Console.WriteLine();

                        if (File.Exists(file.GetTitle()))
                        {
                            Support.Clear(cars);
                        }
                        ifData = file.Read(cars);

                        break;

                    case 2:

                        Support.WriteCol("--- Zapis do pliku ---", "G");
                        Console.WriteLine();
                        if (ifData)
                        {
                            file.GetTitle();
                            file.Save(cars);
                        }
                        else
                        {
                            Support.WriteCol("Brak danych w bazie do zapisania", "DY");
                        }
                        break;

                    case 3:

                        Support.WriteCol("--- Dodawanie samochodu do bazy ---", "G");
                        Console.WriteLine();
                        cars.Add();
                        ifData = true;
                        break;

                    case 4: 

                        Support.WriteCol("--- Usuwanie samochodu z bazy ---", "G");
                        Console.WriteLine();
                        if (ifData)
                        {
                            cars.Remove(cars.Search());
                        }
                        else
                        {
                            Support.WriteCol("Brak danych w bazie", "DY");
                        }
                        break;

                    case 5:

                        Support.WriteCol("--- Wszystkie samochody ---", "G");
                        Console.WriteLine();
                        cars.PrintAll();
                        break;

                    case 6:

                        Support.WriteCol("--- Warunowa lista samochodow ---", "G");
                        Console.WriteLine();
                        if(ifData)
                        {
                            cars.PrintConditional(Menu.ConditionalList());
                        }
                        else
                        {
                            Support.WriteCol("Brak danych w bazie", "DY");
                        }
                        break;

                    case 7:

                        Support.WriteCol("--- Wyszukiwanie samochodu ---", "G");
                        Console.WriteLine();
                        if (ifData)
                        {
                            cars.Search();
                        }
                        else
                        {
                            Support.WriteCol("Brak danych w bazie", "DY");
                        }
                        break;

                    case 8:

                        Support.WriteCol("--- Posortowana lista samochodow ---", "G");
                        Console.WriteLine();
                        if (ifData)
                        {
                            cars.PrintSorted(Menu.SortingList(), Menu.SortingDeOrIn());
                        }
                        else
                        {
                            Support.WriteCol("Brak danych w bazie", "DY");
                        }
                        break;
                    
                    case 9:

                        return;
                }
                Support.PressEnter();
            }
        }
    }
}