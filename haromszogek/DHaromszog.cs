using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace haromszogek
{
    class DHaromszog
    {
        private double aOldal; //propfull tabtab

        public double a
        {
            get { return aOldal; }
            set {
                if (value > 0)
                {
                    aOldal = value;
                }
                else
                {
                    throw new HaromszogekKivetel("A(z) a oldal nem lehet 0 vagy negatív!");
                }
            }
        }
        private double bOldal;

        public double b
        {
            get { return bOldal; }
            set
            {
                if (value > 0)
                {
                    bOldal = value;
                }
                else
                {
                    throw new HaromszogekKivetel("A(z) b oldal nem lehet 0 vagy negatív!");
                }
            }
        }

        private double cOldal;

        public double c
        {
            get { return cOldal; }
            set
            {
                if (value > 0)
                {
                    cOldal = value;
                }
                else
                {
                    throw new HaromszogekKivetel("A(z) c oldal nem lehet 0 vagy negatív!");
                }
            }
        }

        private int SorSzama {get; set;}

        public bool EllDerekszogu
        {
            get
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) != Math.Pow(c, 2))
                {
                    throw new HaromszogekKivetel("A háromszög nem derékszögű");
                }
                else
                {
                    return true;
                }
            }
        }
         


        public bool MegSzerkesztheto
        {
            get
            {
                if (a + b < c)
                {
                    throw new HaromszogekKivetel("A háromszöget nem lehet megserkeszteni");
                }
                else
                {
                    return true;
                }

            }
        }

        public bool EllNovekvoSorrend
        {
            get
            {
                if (a > b || b > c)
                {
                    throw new HaromszogekKivetel("Az adatok nincsenek növekvő sorrendben");
                }
                else
                {
                    return true;
                }
            }
        }

        public double Terulet
        {
            get
            {
                return a * b / 2;
            }

        }

        public double Kerulet

        {
            get
            {
                return a + b + c;
            }
        }

        public DHaromszog(string sor, int sorSzama) //ctor tabtab-val létrehozva
        {
            SorSzama = sorSzama;

            string[] atmeneti = sor.Split(' ');

            a = Convert.ToDouble(atmeneti[0]);
            b = Convert.ToDouble(atmeneti[1]);
            c = Convert.ToDouble(atmeneti[2]);

        }

        public override string ToString()
        {
            return SorSzama + ".sor: a=" + a + "b=" + b + "C=" + c;
         
        }

    }
}
