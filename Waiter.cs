using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multy_Threaded_Restaurant
{
    class Waiter
    {
        public void DishReadyEventHandler(object sender, DishEventArgs d)
        {
            Console.WriteLine($"serving the dish {d.DishName} to the customer");
        }
    }
}
