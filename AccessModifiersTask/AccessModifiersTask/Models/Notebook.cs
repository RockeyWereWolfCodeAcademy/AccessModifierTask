using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersTask.Models
{
    public class Notebook : Product
    {
        string _model;
        string _brand;
        int _ram;
        int _storage;

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 3 && value.Length > 30)
                {
                    Console.WriteLine("Model name must be greater than 3 but lesser than 30");
                }
                else
                {
                    _model = value;
                }
            }
        }

        public string Brand
        {
            get => _brand;
            set { _brand = value; }
        }

        public int RAM
        {
            get => _ram;
            set
            {
                if (value < 0 && value > 128)
                {
                    Console.WriteLine("RAM size must be a positive number lesser than 128");
                }
                else
                {
                    _ram = value;
                }
            }
        }

        public int Storage
        {
            get => _storage;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Storage size must be a positive number");
                }
                else
                {
                    _storage = value;
                }
            }
        }

        public Notebook(int count, double price, string model, string brand, int ram, int storage)
            : base(count, price)
        {
            Model = model;
            Brand = brand;
            RAM = ram;
            Storage = storage;
        }
    }
}
