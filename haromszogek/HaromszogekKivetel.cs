using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogek
{
    class HaromszogekKivetel : Exception //ős osztálytól származtataás ": Exception"
    {
        public HaromszogekKivetel(string uzenet) : base(uzenet) // 
        {
            
        }
    }
}
