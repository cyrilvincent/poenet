using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationPOENET
{
    public class Book : Media
    {
        public override double NetPrice
        {
            get { return Price * 1.05; }
        }
    }
}
