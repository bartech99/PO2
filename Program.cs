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

            while (menu.MainList() != 9)
            {
                if (menu.Choise != 0)
                {
                    switch (menu.Choise)
                    {
                        case 1:

                            Menu.WriteCol("--- a ---", "G");
                            break;

                        case 2:

                            Menu.WriteCol("--- a ---", "G");
                            break;

                        case 3:

                            Menu.WriteCol("--- a ---", "G");
                            cars.Add();
                            break;

                        case 4:

                            Menu.WriteCol("--- a ---", "G");
                            break;

                        case 5:

                            Menu.WriteCol("--- a ---", "G");
                            cars.PrintAll();
                            break;

                        case 6:

                            Menu.WriteCol("--- a ---", "G");
                            break;

                        case 7:

                            Menu.WriteCol("--- a ---", "G");
                            break;

                        case 8:

                            Menu.WriteCol("--- a ---", "G");
                            break;
                    }
                    menu.PressEnter();
                }
            }
        }
    }
}