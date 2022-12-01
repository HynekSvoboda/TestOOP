using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP
{
    class Vedouci
    {
        string jmeno;
        string prijmeni;
        DateTime datumnarozeni;
        int plat;

        public DateTime DatumNarozeni
        {
            get
            {
                return datumnarozeni;
            }
            set
            {

                if (datumnarozeni < DateTime.Now) datumnarozeni = value;
                else MessageBox.Show("ŠPATNÉ DATUM");
            }
        }
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
        }
        public Vedouci()
        {
            this.jmeno = "Default";
            this.prijmeni = "Default";
        }
        bool starsi30()
        {
            TimeSpan rozdil = DateTime.Now - datumnarozeni;
            double roky = (rozdil.TotalDays)/365.25;
            if (roky > 29) return true;
            else return false;
        }
       public void bohaty()
        {
            if (plat > 50) MessageBox.Show( Jmeno+" je bohatý, protože má více jak50tísíc");
            else MessageBox.Show(Jmeno+" je chudší, protože má méně jak 50tisíc");
        }
        public Vedouci(string jmeno,string prijmeni,DateTime datumnarozeni,int plat)
        {
            this.datumnarozeni = datumnarozeni;
            this.jmeno = jmeno;
            this.plat = plat;
            this.prijmeni = prijmeni;
        }
        public override string ToString()
        {
            if (starsi30()) return "Jmeno a prijmeni: " + Jmeno +" "+ prijmeni + " datum narozeni: " + DatumNarozeni + " je starsi jak 30 let";
            else return "Jmeno a prijmeni: " + Jmeno+" "+ prijmeni + " datum narozeni: " + DatumNarozeni + " neni starsi jak 30 let";
        }
    }
}
