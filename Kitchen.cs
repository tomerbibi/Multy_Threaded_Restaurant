using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multy_Threaded_Restaurant
{
    class Kitchen
    {
        public event EventHandler<DishEventArgs> DishReady;
        public void OnDishReady(string dishName)
        {
            if(DishReady != null)
                DishReady(this, new DishEventArgs(dishName));
        }
        public void PrepareDish(string dishName) 
        {
            Console.WriteLine("preparing dish");
            OnDishReady(dishName);
        }
    }
}
