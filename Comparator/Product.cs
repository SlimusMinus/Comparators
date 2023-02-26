using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparator
{
    public class Product : IComparable
    {
        public double price { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public int popularity { get; set; }

        public Product(string brand, string color, double price, int popularity)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
            this.popularity = popularity;
        }

        public int CompareTo(object obj)
        {
            Product product = obj as Product;
            if (product != null)
            {
                if (this.popularity > product.popularity)
                    return -1;
                else if (this.popularity < product.popularity)
                    return 1;
                else
                    return 0;
            }
            else
                throw new Exception("Parametr is not Product");
        }
        public override string ToString()
        {
            return $"{brand}{"\t"}{color} {"color\t"} {"price = "} {price} {"$\tpopularity"} {popularity} {"stars"}";
        }

    }

}
