using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using HashSorted.Entities;
namespace HashSorted;
class Program
{
    static void Main(string[] args)
    {
        //Aula 219
        HashSet<Product> prodA = new HashSet<Product>();
        prodA.Add(new Product("Mouse", 54.00));
        prodA.Add(new Product("TV", 2000.00));

        HashSet<Point> prodB = new HashSet<Point>();
        prodB.Add(new Point(5, 3));
        prodB.Add(new Point(4, 7));

        //Nova instanciação
        Product pd = new Product("TV", 2000.00);
        System.Console.WriteLine(prodA.Contains(pd));

        Point point = new Point(5, 3);
        System.Console.WriteLine(prodB.Contains(point));
    }
}
