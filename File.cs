using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using CarsData;
using System.Linq;

namespace Handling
{
    class FileSupport
    {
        private string title = "data.txt";

        public bool Read(Cars C)
        {
            try
            {
                using (StreamReader f = new StreamReader(title))
                {
                    string[] input = File.ReadAllLines(title);

                    foreach (var item in input)
                    {
                        Car c = new Car();

                        string[] temp = item.Split("\t");

                        c.Brand = temp[0].ToString();
                        c.Model = temp[1].ToString();
                        c.Year = int.Parse(temp[2]);
                        c.Capacity = int.Parse(temp[3]);
                        c.Milleage = int.Parse(temp[4]);
                        c.Gearbox = temp[5].ToString();

                        C.Push(c);
                    }
                }
            }
            catch
            {
                Support.WriteCol("Podany plik nie istnieje!", "R");
                return false;
            }
            Console.WriteLine("Pomyslnie odczytano dane");
            return true;
        }

        public bool Save(Cars c)
        {
            int mode;
            bool append;

            if (File.Exists(title))
            {
                Console.WriteLine("Plik o podanej nazwie istnieje.");
                Console.Write("Wprowadz 1 - aby go nadpisac, 2 - aby dopisac linie: ");
                while (true)
                {
                    try
                    {
                        mode = int.Parse(Console.ReadLine());

                        if (mode == 1)
                        {
                            File.Delete(title);
                            append = false;
                            break;
                        }
                        else if (mode == 2)
                        {
                            append = true;
                            break;
                        }
                        else
                        {
                            Support.WriteCol("Niepoprawna wartosc!", "DY");
                            Console.Write("Twoj wybor: ");
                        }
                    }
                    catch
                    {
                        Support.WriteCol("Niepoprawna wartosc!", "R");
                        Console.Write("Twoj wybor: ");
                    }
                }
            }
            else
            {
                append = false;
            }

            using (StreamWriter f = new StreamWriter(title,append))
            {
                foreach (Car item in c.list)
                {
                    try
                    {
                        f.WriteLine($"{item.Brand}\t{item.Model}\t{item.Year}\t{item.Capacity}\t{item.Milleage}\t{item.Gearbox}");
                    }
                    catch
                    {
                        Support.WriteCol("Operacja nie powiodla sie", "R");
                        return false;
                    }
                }
            }

            Console.WriteLine("Pomyslnie zapisano dane");
            return true;
        }

        public bool GetTitle()
        {
            string end;

            Console.Write("Podaj nazwe pliku: ");
            title = Console.ReadLine();

            while (title.Length < 1)
            {
                Support.WriteCol("Nie podano nazwy pliku!", "DY");
                Console.Write("Podaj nazwe pliku: ");
                title = Console.ReadLine();
            }

            try 
            { 
                end = title.Substring(title.Length - 4); 
            }
            catch 
            { 
                title = $"../../../{title}.txt";
                return true; 
            }

            if (!end.Equals(".txt", StringComparison.OrdinalIgnoreCase)) 
            { 
                title += ".txt"; 
            }

            title = $"../../../{title}";

            return true;
        }
    }
}