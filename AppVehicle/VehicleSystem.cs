using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehicle
{
    class VehicleSystem
    {
        List<Vehicle> vehicleList = new List<Vehicle>();
        static int countStatic = 0;

        static void Main(string[] args)
        {
            VehicleSystem vSystem = new VehicleSystem();

            vSystem.Run();

        }

        private void Menu()
        {
            string input = "";
            bool run = true;

            do
            {
                Console.WriteLine("1. Add a Vehicle");
                Console.WriteLine("2. Print a Vehicle");
                Console.WriteLine("3. Exit");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddVehicle();
                        Console.Clear();
                        Console.WriteLine("Vehicle added!");
                        Console.ReadKey();
                        break;
                    case "2":
                        PrintVehicle();
                        Console.ReadKey();
                        break;
                    case "3":
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;

                }

                Console.Clear();

            } while (run);
        }

        private void PrintVehicle()
        {
            int increment = 0;
            Console.Clear();

            Console.WriteLine("*** ALL YEAR & MODEL OF VEHICLES LISTED *** ");

            Console.WriteLine("\n There are {0} vehicles!", countStatic);

            foreach (Vehicle vehicle in vehicleList)
            {
                ++increment;

                Console.WriteLine("\n-Vehicle {0}", increment);
                Console.Write("Year: ");
                Console.WriteLine(vehicle.Year);
                Console.Write("Model: ");
                Console.WriteLine(vehicle.Model);

            }
        }

        private List<Vehicle> AddVehicle()
        {
            int year;
            string model;

            int choice;

            Console.Clear();

            Console.WriteLine("Is it a car or a truck? ");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Truck");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAdd the Vehicles's Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAdd the Vehicles's Model: ");
            model = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    vehicleList.Add(new Car(year, model));
                    break;
                case 2:
                    vehicleList.Add(new Truck(year, model));
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            countStatic++;

            return vehicleList;

        }

        private void Run()
        {
            Menu();

        }
    }
}
