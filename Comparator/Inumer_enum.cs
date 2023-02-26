using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator
{
    public class InumerEnum : IEnumerator
    {
        public Product[] inumers;
        int position = -1;
        public InumerEnum(Product[] list)
        { inumers = list; }

        public bool MoveNext()
        {
            position++;
            return (position < inumers.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current { get { return Current; } }

        public Product Current
        {
            get
            {
                try
                {
                    return inumers[position];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
 
}
