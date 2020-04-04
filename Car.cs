using System;
using System.Collections.Generic;
using System.Text;

namespace PO2
{
    class Car
    {
        private string brand;
        private string model;
        private uint year;
        private uint capacity;
        private uint milleage;
        private string gearbox;

        public string Brand
        {
            get => brand;
            set
            {
                if (value == "Alfa Romeo" || value == "Audi" || value == "Bentley"
                    || value == "BMW" || value == "Bugatti" || value == "Chevrolet"
                    || value == "Crysler" || value == "Citroen" || value == "Dacia"
                    || value == "Dodge" || value == "Ferrari" || value == "Fiat"
                    || value == "Ford" || value == "Hyundai" || value == "Jaguar"
                    || value == "Jeep" || value == "Lamborghini" || value == "Land Rover"
                    || value == "Łada")
                {
                    try { brand = value; }
                    catch { Console.WriteLine("Zly format!"); }
                }
                else { Console.WriteLine("Niepoprawna nazwa marki!"); }
            }
        }
        public string Model
        {
            get => model;
            set
            {
                try { model = value; }
                catch { Console.WriteLine("Niepoprawny model!"); }
            }
        }
        public uint Year
        {
            get => year;
            set
            {
                try { year = value; }
                catch { Console.WriteLine("Niepoprawny rok produkcji!"); }
            }
        }
        public uint Capacity
        {
            get => capacity;
            set
            {
                try { capacity = value; }
                catch { Console.WriteLine("Niepoprawna pojemnosc silnika!"); }
            }
        }
        public uint Milleage
        {
            get => milleage;
            set
            {
                try { milleage = value; }
                catch { Console.WriteLine("Niepoprawny przebieg!"); }
            }
        }
        public string Gearbox
        {
            get => gearbox;
            set
            {
                if (value == "automatyczna" || value == "manualna")
                {
                    try { gearbox = value; }
                    catch { Console.WriteLine("Zly format!"); }
                }
                else { Console.WriteLine("Niepoprawny typ skrzyni biegow!"); }
            }
        }

        public Car(string brand = "brak", string model = "brak", uint year = 0, uint capacity = 0, uint milleage = 0, string gearbox = "brak")
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.capacity = capacity;
            this.milleage = milleage;
            this.gearbox = gearbox;
        }
    }
}