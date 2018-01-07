using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menetlevelekprog
{
    class Jarmu
    {
        string rendszam;
        double teherbiras;

        public Jarmu(string rendszam, double teherbiras)
        {
            this.Rendszam = rendszam;
            this.Teherbiras = teherbiras;
        }

        public string Rendszam
        {
            get
            {
                return rendszam;
            }

            set
            {
                if (value.Length == 6)
                {
                    rendszam = value;
                }
                else
                {
                    throw new ArgumentException("A rendszámnak 6 arakteresnek kell lennie");
                }
                rendszam = value;
            }
        }

        public double Teherbiras
        {
            get
            {
                return teherbiras;
            }

            set
            {
                teherbiras = value;
            }
           
        }
        public Jarmu()
        {
            Rendszam = "";
            Teherbiras = 0;
        }
    }
}
