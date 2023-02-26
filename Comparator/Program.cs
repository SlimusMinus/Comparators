using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkBlue;
            Product Nike1 = new Product("Nike air max", "black", 100.55, 9);
            Product Nike2 = new Product("Nike Cortez", "white", 95.13, 7);
            Product Nike3 = new Product("Nike Blazer", "black", 105.89, 7);
            Product Adidas1 = new Product("Adidas Superstar", "red", 70.88, 6);
            Product Adidas2 = new Product("Adidas Stan Smith", "blue", 150.58, 8);
            Product Adidas3 = new Product("Adidas Stockholm", "green", 125.6, 5);
            Product[] Shoes = { Nike1, Nike2, Nike3, Adidas1, Adidas2, Adidas3 };
            Inumer inum = new Inumer(Shoes);

            WriteLine("Welcome in our shop, we have next shoes");
            WriteLine("**************************************************************");
            foreach (var item in inum)
            {
                WriteLine($"{item.brand}{"\t"}{item.color} {"color\t"} {"price = "} {item.price} {"\tpopularity"} {item.popularity} {"stars"}");
            }
            WriteLine("**************************************************************");
            WriteLine("Press Enter");
            ReadLine();
            while (true)
            {
                Clear();
                WriteLine("Choose sort: press 1 - popularity, 2 - price, 3 - brand");
                ConsoleKey key = ReadKey().Key;
                switch (key)
                {
                   
                    case ConsoleKey.D1:
                        {
                            Clear(); 
                            Array.Sort(Shoes);
                            WriteLine("**************************************************************");
                            foreach (var item in Shoes)
                                WriteLine(item);
                            WriteLine("**************************************************************");
                            WriteLine("Press Enter");
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Clear(); 
                            Array.Sort(Shoes, new Sort_price());
                            WriteLine("**************************************************************");
                            foreach (var item in Shoes)
                                WriteLine(item);
                            WriteLine("**************************************************************");
                            WriteLine("Press Enter");
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Clear(); 
                            Array.Sort(Shoes, new Sort_brand());
                            WriteLine("**************************************************************");
                            foreach (var item in Shoes)
                                WriteLine(item);
                            WriteLine("**************************************************************");
                            WriteLine("Press Enter");
                        }
                        break;
                    default:
                        WriteLine("\nThis number is error, press Enter");
                        break;
                }
                ReadLine();
            } 

        }
    }
}
