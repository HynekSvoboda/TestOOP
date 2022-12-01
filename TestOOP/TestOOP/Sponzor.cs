using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP
{
    class Sponzor
    {
        int penize;
        string nazev;
        double zisk;
        public int Penize
        {
            get
            {
                return penize;
            }
        }
        public string Nazev
        {
            get
            {
                return nazev;
            }
        }
        double Zisk()
        {
            zisk = penize;
            return zisk*=.05;
        }
        public Sponzor()
        {
        }
        public string Odmena()
        {
            if (penize > 50) return "Sponzor zísává zlatého blutišťáka";
            else return "Tým vám děkuje za podporu";
        }
        public Sponzor(string nazev,int penize)
        {
            this.nazev = nazev;
            this.penize = penize;
        }
        public override string ToString()
        {
            return "Jmeno sponzora: " + Nazev + " a jeho investice do tymu: " + Penize+ " tisíc Kč "+Odmena()+ " a váš zisk z týmu je: "+Zisk()+" tísíc Kč";
        }
    }
}
