using Handling;

namespace CarsData
{
    //Zawiera dane określające pojedynczy samochód
    class Car
    {
        private string brand;
        private string model;
        private int year;
        private int capacity;
        private int milleage;
        private string gearbox;

        public bool correct = true;

        public string Brand
        {
            get => brand;
            set
            {
                if (value == "Alfa Romeo" || value == "Aston Martin" || value == "Audi" || value == "Bentley"
                    || value == "BMW" || value == "Bugatti" || value == "Buick" || value == "Cadillac"
                    || value == "Chevrolet" || value == "Crysler" || value == "Citroen" || value == "Dacia"
                    || value == "Daewoo" || value == "DAF" || value == "Daihatsu" || value == "Dodge"
                    || value == "Ferrari" || value == "Fiat" || value == "Ford" || value == "FSO" || value == "Honda"
                    || value == "Hyundai" || value == "Inifnity" || value == "Iveco" || value == "Jaguar"
                    || value == "Jeep" || value == "KIA" || value == "Lamborghini" || value == "Land Rover"
                    || value == "Lexus" || value == "Maserati" || value == "Maybach" || value == "Mazda"
                    || value == "McLaren" || value == "Mercedes" || value == "Mini" || value == "Mitsubishi"
                    || value == "Nissan" || value == "Opel" || value == "Peugeot" || value == "Porshe"
                    || value == "Renault" || value == "Rolls Royce" || value == "Rover" || value == "SAAB"
                    || value == "Scania" || value == "Seat" || value == "Skoda" || value == "Smart"
                    || value == "Subaru" || value == "Suzuki" || value == "Tesla" || value == "Toyota"
                    || value == "Volkswagen" || value == "Volvo")
                {
                    try 
                    { 
                        brand = value; 
                    }
                    catch 
                    {
                        correct = false;
                        brand = "brak";
                        Support.WriteCol("Zly format!", "R");
                    }
                }
                else
                {
                    correct = false;
                    brand = "brak";
                    Support.WriteCol($"Niepoprawna nazwa marki: {value}!", "DY");
                }
            }
        }

        public string Model
        {
            get => model;
            set
            {
                try 
                { 
                    model = value; 
                }
                catch 
                {
                    correct = false;
                    model = "brak";
                    Support.WriteCol($"Niepoprawny model: {value}!", "R");
                }
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value > 1950 && value <= 2020)
                {
                    try 
                    { 
                        year = value; 
                    }
                    catch
                    {
                        correct = false;
                        year = 0;
                        Support.WriteCol($"Niepoprawny rok produkcji: {value}!", "R");
                    }
                }
                else
                {
                    correct = false;
                    year = 0;
                    Support.WriteCol($"Niepoprawny rok produkcji: {value}!", "DY");
                }
            }
        }

        public int Capacity
        {
            get => capacity;
            set
            {
                if (value >= 330)
                {
                    try 
                    { 
                        capacity = value; 
                    }
                    catch
                    {
                        correct = false;
                        capacity = 0;
                        Support.WriteCol($"Niepoprawna pojemnosc silnika: {value}!", "R");
                    }
                }
                else
                {
                    correct = false;
                    capacity = 0;
                    Support.WriteCol($"Niepoprawna pojemnosc silnika: {value}!", "DY");
                }
            }
        }

        public int Milleage
        {
            get => milleage;
            set
            {
                if (value > 0)
                {
                    try 
                    { 
                        milleage = value; 
                    }
                    catch
                    {
                        correct = false;
                        milleage = 0;
                        Support.WriteCol($"Niepoprawny przebieg: {value}!", "R");
                    }
                }
                else
                {
                    correct = false;
                    milleage = 0;
                    Support.WriteCol($"Niepoprawny przebieg: {value}!", "DY");
                }
            }
        }

        public string Gearbox
        {
            get => gearbox;
            set
            {
                if (value == "automatyczna" || value == "manualna")
                {
                    try 
                    { 
                        gearbox = value; 
                    }
                    catch
                    {
                        correct = false;
                        gearbox = "brak";
                        Support.WriteCol($"Zly format: {value}!", "R");
                    }
                }
                else 
                {
                    correct = false;
                    gearbox = "brak";
                    Support.WriteCol($"Niepoprawny typ skrzyni biegow: {value}!", "R");
                }
            }
        }

        public Car(string brand = "brak", string model = "brak", int year = 0, int capacity = 0, int milleage = 0, string gearbox = "brak")
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.capacity = capacity;
            this.milleage = milleage;
            this.gearbox = gearbox;
        }

        public override string ToString()
        {
            return brand.ToString() + "\t" + model.ToString() + "\t" + year.ToString() + "\t" + capacity.ToString() + "\t" 
                + milleage.ToString() + "\t" + gearbox.ToString();
        }
    }
}