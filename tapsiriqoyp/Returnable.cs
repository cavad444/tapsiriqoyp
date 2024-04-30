using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriqoyp
{
    interface Returnable
    {
        void initiateReturn(string reason);
        void cancelReturn();
    }
}
