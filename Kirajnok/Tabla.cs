using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirajnok
{
    class Tabla
    {
        private char[,] T; //A két dimenziós tömb [,] ha három dimánziós lenne [,,]
        private char Urescella;

        public Tabla(char urescella)
        { //konstruktor létrehozása
            //8*8-as mátrix létrehozása
            T = new char[8, 8];
            Urescella = urescella; // a konstruktor paraméterét átadtuk az Urescella mezőnek
            //mindig annyi ciklus kell ahány dimenziós tömbben dolgozunk, mert a tömbnek ez lesz az indexe
            // az első "i"  sor  a második "j" az oszlop
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = Urescella;
                }
            }

        }

        public void Megjelenit()
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write(T[i, j]);
                    if (j == 7)
                        Console.WriteLine();
                }
            }
        }


        public void Elhelyez(int N)
        {
            Random r = new Random();

            for (int i = 0; i < N; i++)
            {
                int v1;
                int v2;

                do
                {
                    v1 = r.Next(0, 8);
                    v2 = r.Next(0, 8);

                } while (T[v1,v2] != Urescella);
                T[v1, v2] = 'K';
            
            }
        }

        public bool UresOszlop(int oszlop) //7. feladat
        {
            if (oszlop < 0 || oszlop > 7)
            {
                return false;
            }

            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[i, oszlop] != Urescella)
                {
                    return false;
                }
            }
            return true;
        }

        public bool UresSor(int sor) //7. feladat
        {
            if (sor < 0 || sor > 7)
            {
                return false;
            }

            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[sor, i] != Urescella)
                {
                    return false;
                }
            }
            return true;

        }

        public int UresOszlopokSzama //8. feladat
        {
            get
            {
                int oszlop = 0;
                for (int i = 0; i < T.GetLength(1); i++)
                {
                    if (UresOszlop(i))
                    {
                        oszlop++;
                    }
                }
                return oszlop;
            }
        }

        public int UresSorokSzama //8. feladat
        {
            get
            {
                int sor = 0;
                for (int i = 0; i < T.GetLength(1); i++)
                {
                    if (UresSor(i))
                    {
                        sor++;
                    }
                }
                return sor;
            }
        }



    }
}
