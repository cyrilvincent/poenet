using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationPOENET
{
    public class Publisher
    {
        private int id;

        public int Id // Property
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get; set; }
    }
}
