using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationPOENET
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public abstract double NetPrice {get;}
        public Publisher Publisher { get; set; }
        public IList<Author> Authors { get; set; } = new List<Author>();
    }
}
