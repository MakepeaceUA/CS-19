using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Laptop
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double ProcessorFrequency { get; set; } 
        public int Cores { get; set; } 
        public double Price { get; set; } 
        public int Year { get; set; } 
        public Laptop(string model, string manufacturer, double processorFrequency, int cores, double price, int year)
        {
            Model = model;
            Manufacturer = manufacturer;
            ProcessorFrequency = processorFrequency;
            Cores = cores;
            Price = price;
            Year = year;
        }
    }
}
