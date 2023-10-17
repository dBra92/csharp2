using System.Collections.Generic;
using HSExerc.Entities;

namespace HSExerc;
class Program
{
    //Usando hashset pq ele é mais rapido e não requer ordenação
    static void Main(string[] args)
    {
        HashSet<LRecords> lr = new HashSet<LRecords>();
        System.Console.Write("Enter file full path:");
        string path = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);

                    lr.Add(new LRecords { UserName = name, Instant = instant });
                }
                System.Console.WriteLine($"Total users:{lr.Count()}");
            }
        }
        catch (IOException ioe)
        {
            System.Console.WriteLine(ioe.Message);
        }
    }
}

