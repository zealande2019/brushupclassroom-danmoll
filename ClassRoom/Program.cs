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
            //Opretter instans af Klasserum
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";

            //Indsættelse af Studerende i listen KlasseListe
            Studerende elev1 = new Studerende("Daniel Møller", 11, 28);
            Studerende elev2 = new Studerende("Louise Møller", 05, 04);
            klasseRum.KlasseListe.Add(elev1);
            klasseRum.KlasseListe.Add(elev2);


            Console.WriteLine("Klasse: " + klasseRum.KlasseNavn.ToString());
            Console.WriteLine("Indeholder: ");

            //Lægger KlasseListe i en foreach for at kunne pille data ud af de indlagte Studerende.
            foreach (var item in klasseRum.KlasseListe)
            {
                Console.WriteLine("Navn: " + item.Name + ", har fødselsdato d. " + item.BDay + ". i " + item.BMonth + "." );
            }

            //Stopper den fra at bare at fræse igennem.
            Console.ReadLine();
        }
    }
}
