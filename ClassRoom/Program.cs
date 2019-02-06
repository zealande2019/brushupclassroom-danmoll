using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";

            Studerende elev1 = new Studerende("Daniel Møller", 11, 28);
            Studerende elev2 = new Studerende("Louise Møller", 05, 04);
            klasseRum.KlasseListe.Add(elev1);
            klasseRum.KlasseListe.Add(elev2);

            Console.WriteLine("Klasse: " + klasseRum.KlasseNavn.ToString());
            Console.WriteLine("Indeholder: ");
            foreach (var item in klasseRum.KlasseListe)
            {
                Console.WriteLine("Navn: " + item.Name + ", har fødselsdato d. " + item.BDay + ". i " + item.BMonth + "." );
            }
            Console.ReadLine();
        }
    }
}
