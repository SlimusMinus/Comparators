using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator
{
    internal class Sort_brand : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x is Product && y is Product) { return string.Compare((x as Product).brand, (y as Product).brand); }
            throw new NotImplementedException();
        }
    }
}
    