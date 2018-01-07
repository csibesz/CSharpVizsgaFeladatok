using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menetlevelekprog
{
    class Menetlevel
    {
        int menetlevelSzama;
        string telephely;
        string auto;
        string sofor;
        string hova;
        string kinek;
        string mikor;
        string mit;

        public Menetlevel(int menetlevelSzama, string telephely, string sofor, string hova, string kinek, string mikor, string mit)
        {
            MenetlevelSzama = menetlevelSzama;
            Telephely = telephely;
            Auto = string.Empty;
            Sofor = sofor;
            Hova = hova;
            Kinek = kinek;
            Mikor = mikor;
            Mit = mit;
        }

        public Menetlevel()
        {
            MenetlevelSzama = 0;
            Telephely = "";
            Auto = string.Empty;
            Sofor = "";
            Hova = "";
            Kinek = "";
            Mikor = "";
            Mit = "";
        }

        public override string ToString()
        {
            return MenetlevelSzama + "\t" + Telephely + "\t" + Auto + "\t" + Sofor + "\t" + Hova + "\t" + Kinek + "\t" + Mikor + "\t" + Mit;
        }

        public int MenetlevelSzama
        {
            get
            {
                return menetlevelSzama;
            }

            set
            {
                menetlevelSzama = value;
            }
        }

        public string Telephely
        {
            get
            {
                return telephely;
            }

            set
            {
                telephely = value;
            }
        }

        public string Sofor
        {
            get
            {
                return sofor;
            }

            set
            {
                sofor = value;
            }
        }

        public string Hova
        {
            get
            {
                return hova;
            }

            set
            {
                hova = value;
            }
        }

        public string Kinek
        {
            get
            {
                return kinek;
            }

            set
            {
                kinek = value;
            }
        }

        public string Mikor
        {
            get
            {
                return mikor;
            }

            set
            {
                mikor = value;
            }
        }

        public string Mit
        {
            get
            {
                return mit;
            }

            set
            {
                mit = value;
            }
        }

        public string Auto
        {
            get
            {
                return auto;
            }

            set
            {
                auto = value;
            }
        }
    }
}
