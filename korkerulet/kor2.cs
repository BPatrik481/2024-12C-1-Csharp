﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class kor2
    {
        //osztályváltozók

        private double sugar,
                       kerulet,
                       terulte;

        //konstruktorok

        public kor2()
        {

        }
        public kor2(double r)
        {
            this.sugar = r;
            szamitasok();

        }

        //metodusok

        public void SetSugar(double r)
        {
            this.sugar = r;
            szamitasok();
        }

        private void kalkKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        private double kalkTerulet(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void szamitasok()
        {
            kalkKerulet();
            this.terulte = kalkTerulet(this.sugar);
        }

        public double getker()
        {
            return this.kerulet;
        }
        public double getter()
        {
            return this.terulte;
        }
        public double getsug()
        {
            return this.sugar;
        }
    }
}
