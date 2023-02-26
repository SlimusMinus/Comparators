using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator
{
    internal class Sort_price : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.price < y.price)
                return 1;
            else if (x.price > y.price)
                return -1;
            else 
                return 0;
        }
    }
}
