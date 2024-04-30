using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriqoyp
{
    class ClothingProduct : Product, Shippable, Returnable
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double calculateDiscount()
        {
       
            return price * 0.2; 
        }

        public void shipProduct(string destination)
        {
            Console.WriteLine($"Shipping {name} to {destination}");
        }

        public void initiateReturn(string reason)
        {
            Console.WriteLine($"Initiating return for {name} due to {reason}");
        }

        public void cancelReturn()
        {
            Console.WriteLine($"Return process for {name} cancelled");
        }
    }
}
