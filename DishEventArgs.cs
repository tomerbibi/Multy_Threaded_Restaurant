using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multy_Threaded_Restaurant
{
    class DishEventArgs : EventArgs
    {
        public DishEventArgs(string dishName)
        {
            DishName = dishName;
        }

        public string DishName { get; set; }
    }
}
