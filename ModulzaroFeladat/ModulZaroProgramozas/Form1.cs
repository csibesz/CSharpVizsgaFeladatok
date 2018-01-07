using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulZaroProgramozas
{
    public partial class Form1 : Form
    {
        /*3.Feladat Olvassa be a router.log állományban található adatokat és annak felhasználásával oldja meg a feladatokat!*/
        private List<Naplo> beolvasottNaplo;

        public Form1()
        {
            InitializeComponent();
            beolvasottNaplo = new List<Naplo>(); /*3. feladat*/
        }

        #region Metódusok
        /*3. feladat*/
        public void FájlBeolvasás(string fajlUtvonal)
        {
            string sor;
            string[] sorErtekei;

            using (StreamReader olvaso = new StreamReader(fajlUtvonal))
            {
                while (!olvaso.EndOfStream)
                {
                    sor = olvaso.ReadLine();
                    sorErtekei = sor.Split('\t');
                    beolvasottNaplo.Add(new Naplo(sorErtekei[0], sorErtekei[1], Int64.Parse(sorErtekei[2])));
                }
            }
        }

        /*4.feladat*/
        public void KepernyoreIratas()
        {
            Int64 osszAdatmennyiseg = 0; /*5.feladat*/
            Int64 maxAdatmennyiseg = 0; /*6.feladat*/

            if (beolvasottNaplo.Count != 0)
            {
                treeViewNaplo_4F.Nodes.Clear();
                foreach (var adat in beolvasottNaplo)
                {
                    TreeNode gyoker = new TreeNode();
                    gyoker.Text = adat.MAC;
                    gyoker.Nodes.Add(new TreeNode("IP: " + adat.IP));
                    gyoker.Nodes.Add(new TreeNode("Adatmennyiség [byte]: " + adat.Adatmennyiseg.ToString()));

                    treeViewNaplo_4F.Nodes.Add(gyoker);

                    /*5.feladat*/
                    osszAdatmennyiseg += adat.Adatmennyiseg;

                    /*6.feladat*/
                    if(maxAdatmennyiseg < adat.Adatmennyiseg)
                    {
                        label_MACmax_6F.Text = adat.MAC;
                        maxAdatmennyiseg = adat.Adatmennyiseg;
                    }
                    /*7.feladat*/
                    double test = Math.Round((adat.Adatmennyiseg / Math.Pow(1024, 2)));
                    if (Math.Round((adat.Adatmennyiseg / Math.Pow(1024, 2))) < 500)
                    {
                        label_MACmin_7F.Text = adat.MAC;
                    }
                    else
                    {
                        label_MACmin_7F.Text = "Nincs ilyen munkaállomás!";
                    }
                }
                /*5.feladat*/
                label_Mennyiseg_5F.Text = Math.Round((osszAdatmennyiseg / Math.Pow(1024,3)),2).ToString();

            }
        }
        #endregion

        #region Események
        /*3. feladat*/
        private void btnBeolvasás_3F_Click(object sender, EventArgs e)
        {
            if(openFileDialog_3F.ShowDialog() == DialogResult.OK)
            {
                FájlBeolvasás(openFileDialog_3F.FileName);
                KepernyoreIratas(); /*4.feladat*/
            }

        }
        #endregion
    }
}
