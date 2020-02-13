using System;

namespace Lab5._3_UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            CarLot carlot = new CarLot();
            carlot.AddCar(new Car("Toyota", "Camry", 2010, 15000.00));
            carlot.AddCar(new Car("Lexus", "GS50", 2019, 35000.00));
            //carlot.AddCar(new Car("Mercedes", "S-Class", 2019, 65000.00));
            carlot.AddCar(new Car("Honda", "Accord", 2019, 30000));
            carlot.AddCar(new Car("Tesla", "Model-S", 2019, 50000));
            carlot.AddCar(new Car("Subaru", "Impreza", 2019, 35000));
            carlot.AddCar(new UsedCar("Ford", "F150", 2019, 50000, 80000));
            carlot.AddCar(new UsedCar("Toyota", "4Runner", 2019, 55000, 120000));
            carlot.AddCar(new UsedCar("Ford", "Mustang", 2019, 50000, 80000));

            //carlot.AddCar(new UsedCar("Toyota", "Highlander", 2010, 15000, 140000));

            while (keepGoing == true)
            {
                carlot.ListCars();

                int.TryParse(Console.ReadLine(), out int choice);
                if (choice <= carlot.LotSize)
                {
                    carlot.purchase(choice);
                }
                else if (choice == (carlot.LotSize + 1))
                {
                    Console.WriteLine("Enter Make:");
                    string makeInput = Console.ReadLine();
                    Console.WriteLine("Enter Model:");
                    string modelInput = Console.ReadLine();
                    Console.WriteLine("What is the year?");
                    int.TryParse(Console.ReadLine(), out int yearInput);
                    Console.WriteLine("What do you want for it?");
                    double.TryParse(Console.ReadLine(), out double purchasePrice);
                    double ourPrice = purchasePrice + 5000;
                    Console.WriteLine("How many miles are on it?");
                    double.TryParse(Console.ReadLine(), out double milesInput);
                    if (milesInput > 500)
                    {
                        carlot.AddCar(new UsedCar(makeInput, modelInput, yearInput, ourPrice, milesInput));
                    }
                    else
                    {
                        carlot.AddCar(new Car(makeInput, modelInput, yearInput, ourPrice));

                    }
                }
                else if (choice == (carlot.LotSize + 2))
                {
                    keepGoing = false;
                    Console.WriteLine("Byeeeeee");
                }

                //carlot.ListCars();
            }
        }
    }
}

