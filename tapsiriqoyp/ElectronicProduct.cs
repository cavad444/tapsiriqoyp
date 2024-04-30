using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriqoyp
{
    class ElectronicProduct: Product, Reviewable
    {
        private List<string> reviews = new List<string>();
        public ElectronicProduct(string name, double price): base(name, price) { }
        public override double calculateDiscount()
        {
            return price * 0.1;
        }
        public void leaveReview(string review)
        {
            reviews.Add(review);
        }
        public void viewReviews()
        {
            foreach (var review in reviews) 
            { 
                Console.WriteLine(review);
            }
        }
    }
}
