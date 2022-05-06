using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP08
{
    class Produkt : Zbozi
    {
        private bool lzeZlevnit = false;

        public Produkt(string nazev, double cena, DateTime datumVyroby, int minTrvanlivost) : base(nazev, cena, datumVyroby, minTrvanlivost)
        { 
        }

        public override double CenasDPH()
        {
            if (SplnujeMinTrvanlivost())
            {
                lzeZlevnit = false;
                return base.CenasDPH();
            }
            else
            {
                lzeZlevnit = true;
                return (base.CenasDPH() / 100) * 60;
            
            }
        }

        public override string ToString()
        {
                return base.ToString();
        }

    }
}
