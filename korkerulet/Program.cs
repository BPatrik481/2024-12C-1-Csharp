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

            Console.WriteLine($"A {k1.GetSugar()} sugarú kör,\nkerülete: {k1.GetKerulet()},\nterülete: {k1.GetTerulet()} ");
            #endregion Eof 1.objektum
            #region 2. objektum
            kor k2 = new kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"\n\nA {k2.GetSugar()} sugarú kör,\nkerülete: {k2.GetKerulet()},\nterülete: {k2.GetTerulet()} ");

            #endregion Eof 2. objektum
            #region kor2 haszanalata

            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"\n\nA kör adatai: \nsugár ={k21.getsug()}, \nkerület = {k21.getker()}, \nterület = {k21.getter()}");

            #endregion Eof kor2
            #region henger számítás

            henger h1 = new henger(15, 30);
            Console.WriteLine($"\n\nA henger adatai:\nsugara = {h1.GetSugar()},\nmagassága = {h1.getMagassag()},\nalapterülete = {h1.GetTerulet()} =\ntérfogata = {h1.getTerfogat()}");

            #endregion Eof Henger
            Console.ReadKey();
        }
    }
}
