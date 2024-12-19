using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training
{
    internal class Product
    {
        private string name;
        private int price;
        private bool isAvailable = true;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }

    }
}
