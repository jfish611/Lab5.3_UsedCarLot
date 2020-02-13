using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3_UsedCarLot
{
    class CarLot
    {
        //private int lotSize = inventory.Count();
        private List<Car> inventory;
        public int LotSize { get => inventory.Count; }
        //internal List<Car> Inventory { get => inventory; set => inventory = value; }

        public void AddCar(Car car)
        {
            inventory.Add(car);
        }

        public CarLot()
        {
            inventory = new List<Car>();
        }
        public void ListCars()
        {
            Console.WriteLine("\tMake\t\tModel\t\tYear\t\tPrice\t\tMileage");
            Console.WriteLine("___________________________________________________________________________________");
            for (int i = 0; i<inventory.Count; i++)
            {
                
                Console.WriteLine($"{i+1}\t{inventory[i]}");
            }
            Console.WriteLine("\nSelect a car above to purchase, or an additional option below.");
            Console.WriteLine($"  {inventory.Count + 1}. Add a car to our lot.");
            Console.WriteLine($"  {inventory.Count + 2}. Quit");

        }

        public void purchase(int choice)
        {
            inventory.Remove(inventory[choice - 1]);
        }

    }
}

