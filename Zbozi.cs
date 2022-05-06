using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP08
{
    class Zbozi
    {

        protected string nazev;
        protected double cena;
        protected DateTime datumVyroby;
        protected int minTrvanlivost;


        public Zbozi(string nazev, double cena, DateTime datumVyroby, int minTrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.minTrvanlivost = minTrvanlivost;
        }

        public bool SplnujeMinTrvanlivost()
        {
            bool prekrocilo = false;
            DateTime trvanlivost = datumVyroby.AddDays(minTrvanlivost);

            if (trvanlivost < DateTime.Now)
            {
                prekrocilo = false;
            }
            if (trvanlivost >= DateTime.Now)
            {
                prekrocilo = true;
            }
            return prekrocilo;
        }

        public virtual double CenasDPH()
        {
            double cenasDPH;
            cenasDPH = (cena / 100) * 121;
            return cenasDPH;
        }

        public override string ToString()
        {
            string s = "";
            if (SplnujeMinTrvanlivost())
            {
                s = "\nNazev je " + nazev
                  + "\nCena bez DPH je " + cena
                  + "\nCena s DPH je " + CenasDPH()
                  + "\nDatum vyroby je " + datumVyroby
                  + "\nMinimalni trvanlivost " + minTrvanlivost + " dni"
                  + "\nSplnuje minimalni trvanlivost";
            }
            else 
            {
                s = "\nNazev je " + nazev
                  + "\nCena bez DPH je " + cena
                  + "\nCena s DPH je " + CenasDPH()
                  + "\nDatum vyroby je " + datumVyroby
                  + "\nMinimalni trvanlivost " + minTrvanlivost + " dni"
                  + "\nNesplnuje minimalni trvanlivost";
            }
            return base.ToString() + s;
        }

    }
}
