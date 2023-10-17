using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashSorted.Entities
{
    public class Product
    {
        //Aula 219
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product? pOther = obj as Product;
            return Name.Equals(pOther.Name) && Price.Equals(pOther.Price);
        }
    }
}