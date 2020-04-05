using System;
using System.Collections.Generic;
using System.Text;
using Handling;

namespace CarsData
{
    //Zawiera wektor przechowujący samochody wraz z metodami do operowania na nim.
    class Cars
    {
        //wektor
        private List<Car> list = new List<Car>();



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
                try { list.Add(c); }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Blad zapisu w wektorze!");
                    Console.ResetColor();
                }
            }
        }

        public void PrintOne(int i)
        {
            try { Console.WriteLine(list[i].ToString()); }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Próba odczytu wartosci wykraczajacej poza wektor!");
                Console.ResetColor();
            }
        }

        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
