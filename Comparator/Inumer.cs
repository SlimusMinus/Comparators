using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator
{
    public class Inumer : IEnumerable
    {
        private Product[] prod;

        public Inumer(Product[] prod_array)
        {
            prod = new Product[prod_array.Length];
            for (int i = 0; i < prod_array.Length; i++)
            {
                prod[i] = prod_array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public InumerEnum GetEnumerator()
        {
            return new InumerEnum(prod);
        }
    }
  
}
