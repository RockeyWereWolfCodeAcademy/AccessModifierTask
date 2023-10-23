using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersTask.Models
{
    public class Product
    {
        int _count;
        double _price;

        public int Count
        {
            get => _count;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Count must be positive");
                }
                else
                {
                    _count = value;
                }
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price must be positive");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public Product(int count, double price)
        {
            Count = count;
            Price = price;
        }
    }
}
