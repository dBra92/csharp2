using Comparisons.Entities;

namespace Comparisons;
class Program
{
    static void Main(string[] args)
    {
        List<Product> prod = new List<Product>();

        prod.Add(new Product("TV", 900.00));
        prod.Add(new Product("Notebook", 1200.00));
        prod.Add(new Product("Tablet", 450.00));

        prod.Sort((prod1, prod2) => prod1.Name.ToUpper().CompareTo(prod2.Name.ToUpper()));

        foreach(Product prod3 in prod)
        {
            System.Console.WriteLine(prod3);
        }
    }
}
