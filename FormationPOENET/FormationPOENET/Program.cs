using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationPOENET
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p1 = new Publisher();
            Publisher p2 = new Publisher { Id = 1, Name = "toto" };
            Media m = new Book { Title = "C#", Price = 20 };
            m.Publisher = p1;
            m.Authors.Add(new Author { Id = 1, Name = "Cyril" });

        }
    }
}
