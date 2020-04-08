using System;
using System.Collections.Generic;
using Handling;

namespace CarsData
{
    //Zawiera wektor przechowujący samochody wraz z metodami do operowania na nim.
    class Cars
    {
        //wektor
        public List<Car> list = new List<Car>();
        
        //metody
        public void Add()
        {
            Car c = new Car();

            if (c.correct)
            {
                Console.Write("Marka: ");
                c.Brand = Console.ReadLine();
            }
            if (c.correct)
            {
                Console.Write("Model: ");
                c.Model = Console.ReadLine();
            }
            if (c.correct)
            {
                Console.Write("Rok produkcji: ");
                c.Year = int.Parse(Console.ReadLine());
            }
            if (c.correct)
            {
                Console.Write("Pojemnosc silnika: ");
                c.Capacity = int.Parse(Console.ReadLine());
            }
            if (c.correct)
            {
                Console.Write("Przebieg: ");
                c.Milleage = int.Parse(Console.ReadLine());
            }
            if (c.correct)
            {
                Console.Write("Typ skrzyni biegow: ");
                c.Gearbox = Console.ReadLine();
            }

            if (c.correct)
            {
                Push(c);
            }
        }

        public void Push(Car c)
        {
            try
            {
                list.Add(c);
            }
            catch
            {
                Support.WriteCol("Blad zapisu w wektorze!", "R");
            }
        }

        public List<int> Search()
        {
            List<int> indx = new List<int>();
            Car c = new Car();
            
            Console.Write("Marka: ");
            c.Brand = Console.ReadLine();
            Console.Write("Model: ");
            c.Model = Console.ReadLine();

            if (c.Brand == "brak" || c.Model == "brak")
            {
                indx.Add(-1);
                return indx;
            }

            int j = 0;
            Console.WriteLine();
            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Brand == c.Brand && list[i].Model == c.Model)
                {
                    j++;
                    Console.WriteLine($"{j}. {list[i]}");
                    indx.Add(i);
                }
            }

            if(j == 0)
            {
                Console.WriteLine("Nie znaleziono pasujacych wynikow.");
                indx.Add(-1);
            }

            return indx;
        }

        public void Remove(List<int> indx)
        {
            int choise;

            if (indx[0] == -1)
            {
                return;
            }

            while(true)
            {
                Console.WriteLine();
                Console.Write("Pozycja do usuniecia: ");
                try
                {
                    choise = int.Parse(Console.ReadLine());

                    if (choise < 1 || choise > indx.Count)
                    {
                        Support.WriteCol("Nieprawidlowa wartosc!", "DY");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Support.WriteCol("Nieprawidlowa wartosc!", "R");
                }
            }

            list.RemoveAt(indx[choise - 1]);

            Console.WriteLine("Pomyslnie usunieto pozycje.");
        }

        public void PrintAll()
        {
            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintSorted(int ch1, int ch2)
        {
            switch (ch1)
            {
                case 1:

                    list.Sort(delegate (Car x, Car y) { return x.Brand.CompareTo(y.Brand); });
                    break;

                case 2:
                    list.Sort(delegate (Car x, Car y) { return x.Model.CompareTo(y.Model); });
                    break;

                case 3:

                    list.Sort(delegate (Car x, Car y) { return x.Year.CompareTo(y.Year); });
                    break;

                case 4:

                    list.Sort(delegate (Car x, Car y) { return x.Capacity.CompareTo(y.Capacity); });
                    break;

                case 5:

                    list.Sort(delegate (Car x, Car y) { return x.Milleage.CompareTo(y.Milleage); });
                    break;

                case 6:

                    list.Sort(delegate (Car x, Car y) { return x.Gearbox.CompareTo(y.Gearbox); });
                    break;
            }

            if(ch2 == 1)
            {
                list.Reverse();
            }

            Console.WriteLine();
            PrintAll();
        }

        public void PrintConditional (int ch)
        {
            Car c = new Car();

            switch(ch)
            {
                case 1:

                    while(c.Brand == "brak")
                    {
                        Console.Write("Marka: ");
                        c.Brand = Console.ReadLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                    foreach (var item in list)
                    {
                        if(item.Brand == c.Brand)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                case 2:

                    while (c.Year == 0)
                    {
                        try
                        {
                            Console.Write("Podaj wartosc progowa: ");
                            c.Year = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Support.WriteCol("Niepoprawny format!", "R");
                        }
                    }

                    Console.WriteLine("0 - mniejsze, 1 - wieksze lub rowne");

                    if (Menu.GetChoise(0,1) == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Year < c.Year)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Year >= c.Year)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    break;

                case 3:

                    while (c.Capacity == 0)
                    {
                        try
                        {
                            Console.Write("Podaj wartosc progowa: ");
                            c.Capacity = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Support.WriteCol("Niepoprawny format!", "R");
                        }
                    }

                    Console.WriteLine("0 - mniejsze, 1 - wieksze lub rowne");

                    if (Menu.GetChoise(0, 1) == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Capacity < c.Capacity)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Capacity >= c.Capacity)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    break;

                case 4:

                    while (c.Milleage == 0)
                    {
                        try
                        {
                            Console.Write("Podaj wartosc progowa: ");
                            c.Milleage = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Support.WriteCol("Niepoprawny format!", "R");
                        }
                    }

                    Console.WriteLine("0 - mniejsze, 1 - wieksze lub rowne");

                    if (Menu.GetChoise(0, 1) == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Milleage < c.Milleage)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                        foreach (var item in list)
                        {
                            if (item.Milleage >= c.Milleage)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    break;

                case 5:

                    while (c.Gearbox == "brak")
                    {
                        try
                        {
                            Console.Write("Podaj rodzaj skrzyni biegow: ");
                            c.Gearbox = Console.ReadLine();
                        }
                        catch
                        {
                            Support.WriteCol("Niepoprawny format!", "R");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
                    foreach (var item in list)
                    {
                        if (item.Gearbox == c.Gearbox)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
            }
        }
    }
}
