using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multy_Threaded_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen k = new Kitchen();
            Waiter w = new Waiter();
            k.DishReady += w.DishReadyEventHandler;
            k.PrepareDish("stake");
        }
    }
}
