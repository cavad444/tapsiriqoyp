using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriqoyp
{
    interface Shippable
    {
        void shipProduct(string destination);
        static void trackShipment(string trackingNumber)
        {
            Console.WriteLine($"Tracking shipment with tracking number {trackingNumber}");
        }
    }
}
