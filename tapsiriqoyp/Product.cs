using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriqoyp
{
    abstract class Product  
    {
        protected string name;
        protected double price;
        protected static int totalProducts;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
            totalProducts++;
        }

        public abstract double calculateDiscount();

        public void printDetails()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, Total Products: {totalProducts}");
        }
    }
}
