using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulZaroProgramozas
{
    /*1. feladat: Készítsen egy Naplo nevű osztályt, mely az alábbi tulajdonságokat tartalmazza:
                Mac, Ip, AdatMennyiseg! */
    public class Naplo
    {
        #region Változók
        private string mac;
        private Int64 adatmennyiseg;
        private string ip;
        #endregion

        #region Metódusok
        /*2. feladat: A Naplo osztályhoz készítsen paraméteres konstruktort, mely az előző feladatban
                        megadott tulajdonságokat állítja be!*/
        public Naplo(string _mac,string _ip, Int64 _adatmennyiség)
        {
            this.mac = _mac;
            this.ip = _ip;
            this.adatmennyiseg = _adatmennyiség;
        }
        #endregion

        #region Tulajdonságok
        public string MAC
        {
            get { return mac; }
            set { mac = value; }
        }

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
        
        public Int64 Adatmennyiseg
        {
            get { return adatmennyiseg; }
            set { adatmennyiseg = value; }
        }
        #endregion
    }
}
