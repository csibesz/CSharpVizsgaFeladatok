using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menetlevelekprog
{
    class Telep
    {
        private string telepNeve;
        private int telepSzama;

        public Telep(string telepNeve, int telepSzama)
        {
            this.TelepNeve = telepNeve;
            this.TelepSzama = telepSzama;
        }

        public string TelepNeve
        {
            get { return TelepNeve; }
            set { TelepNeve = value; }
        }

        
        public int TelepSzama
        {
            get { return TelepSzama; }
            set { TelepSzama = value; }
        }


        public Telep()
        {
            TelepNeve = "";
            TelepSzama = 0;
        }

        public override string ToString()
        {
            return TelepNeve;

        }

    }

}
