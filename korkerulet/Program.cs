using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class Program
    {
        static void Main(string[] args)
        {
            //A kor osztály felhsználása
            //1. objektum
            #region 1.objektum
            kor k1 = new kor(); // Sugár példány létrehozása üresen
            k1.ReadSugar(15.0); //sugár megadása
            k1.SetKerulet(); //Kiszámoltatjuk a kerületet
            k1.SetTerulet(); //Kiszámoltatjuk a területet

            Console.WriteLine($"A {k1.GetSugar()} sugarú kör, kerülete: {k1.GetKerulet()}, területe: {k1.GetTerulet()} ");
            #endregion Eof 1.objektum
            #region 2. objektum
            kor k2 = new kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"A {k2.GetSugar()} sugarú kör, kerülete: {k2.GetKerulet()}, területe: {k2.GetTerulet()} ");

            #endregion Eof 2. objektum
            #region kor2 haszanalata

            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"A kör adatai: \nsugár ={k21.getsug()}, \nkerület = {k21.getker()}, \nterület = {k21.getter()}");

            #endregion Eof kor2
            Console.ReadKey();
        }
    }
}
