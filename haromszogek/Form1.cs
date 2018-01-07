using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace haromszogek
{
    public partial class Form1 : Form
    {
        List<DHaromszog> haromszogek;


        public Form1()
        {
            InitializeComponent();
            haromszogek = new List<DHaromszog>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader olvas = new StreamReader(openFileDialog1.FileName);
                int sorszam = 0;
                while (!olvas.EndOfStream)
                {
                    try
                    {
                        DHaromszog atmeneti = new DHaromszog(olvas.ReadLine(), ++sorszam);
                        if (atmeneti.EllDerekszogu && atmeneti.MegSzerkesztheto && atmeneti.EllNovekvoSorrend)
                        {
                            haromszogek.Add(atmeneti);
                        }
                    }
                    catch (HaromszogekKivetel ex)
                    {

                        listBox2.Items.Add(sorszam + ".sor: " + ex.Message);

                    }
                
                }

                listBox1.DataSource = haromszogek;
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem is DHaromszog)
            {
                label3.Text = (listBox1.SelectedItem as DHaromszog).Kerulet.ToString();
                label4.Text = (listBox1.SelectedItem as DHaromszog).Terulet.ToString();
            }
        }
    }
}
