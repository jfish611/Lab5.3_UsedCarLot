using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3_UsedCarLot
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Car()
        {
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0;
        }

        public override string ToString()
        {
            return $"{make}\t\t{model}\t\t{year}\t\t{price:C}";
        }
    }
}
