using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetel
{
    class kivetelclass
    {
        public kivetelclass() { }
        //Általános kivételkezelés
        public void KivKezOs()
        {
            Console.WriteLine("Nincs kivételezés\nAdjon meg egy karaktert!");
            try
            {
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám {0}", szam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();

        }
    }
}
