using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kirajnok
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla('#');

            Console.WriteLine("4. feladat: Az üres tábla");
            t.Megjelenit();

            Console.WriteLine("6. feladat: A feltöltölt tábla:");
            t.Elhelyez(8);
            t.Megjelenit();

            Console.WriteLine("9. feladat: Az Üres oszlopok és sorok száma:");
            Console.WriteLine("Oszlopok: " + t.UresOszlopokSzama);
            Console.WriteLine("Sor: " + t.UresSorokSzama);


            if (File.Exists("tablak64.txt")) //10. feladat
            {
                File.Delete("tablak64.txt");
            }

            for (int i = 1; i <= 64; i++)
            {
                FileStream f = new FileStream("tablak" + i + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter ir = new StreamWriter(f);

                Tabla tabla = new Tabla('*');
                tabla.Elhelyez(i);
                //Változztassuk meg a Console alapértelmezt viselkedését hogy a kijelzőre ír.
               
                Console.SetOut(ir); //így a kiírás nem a kijelzőbe történik hanem a fájlba.
                tabla.Megjelenit();
                // Álltsuk vissza defaultra  aConsle kimenetelét
                Console.SetOut(Console.Out);

                ir.Close();
                f.Close();


            }
            
            Console.ReadKey();

        }
        
    }
}
