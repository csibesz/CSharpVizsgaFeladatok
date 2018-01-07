using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menetlevelekprog
{
    class Sofor
    {
        int soforAzonosíto;
        string soforNeve;

        public Sofor(int soforAzonosíto, string soforNeve)
        {
            this.SoforAzonosíto = soforAzonosíto;
            this.SoforNeve = soforNeve;
        }

        public int SoforAzonosíto
        {
            get
            {
                return soforAzonosíto;
            }

            set
            {
                soforAzonosíto = value;
            }
        }

        public string SoforNeve
        {
            get
            {
                return soforNeve;
            }

            set
            {
                soforNeve = value;
            }
        }

        public Sofor()
        {

            SoforAzonosíto = 0;
            SoforNeve = "";
        }
        public override string ToString()
        {
            return SoforNeve;
        }

    }
}
