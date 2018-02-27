using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class product
    {
        public string name;
        public double price;
        public int quantity;
        public string type;

        public product()
        {
        }

        public product(string name, double price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Qauntity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }    
   
}
