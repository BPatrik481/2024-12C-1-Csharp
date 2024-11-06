using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class henger : kor
    {
        //osztályváltozók

        private double magasság,
            terfogat;

        public henger(double r, double m)
        {
            this.sugar = r;
            this.magasság = m;
            SetTerulet();
            this.terfogat = this.terulet * this.magasság;
        }
        public double getTerfogat()
        {
            return this.terfogat;
        }
        public double getMagassag()
        {
            return this.magasság;
        }
    }
}
