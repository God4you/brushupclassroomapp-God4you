using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opret en instans af KlasseRum
            KlasseRum kr = new KlasseRum();
            

            kr.KlasseNavn = "3b";
            kr.SemesterStart = new DateTime(2018,9,3);

            kr.KlasseListe = new List<Studerende>();
            kr.KlasseListe.Add(new Studerende("Benjamin",6,18));
            kr.KlasseListe.Add(new Studerende("Arlind", 4, 24));
            kr.KlasseListe.Add(new Studerende("Zaki", 6, 6));

            Console.WriteLine(kr.KlasseNavn);            
            Console.WriteLine(kr.SemesterStart);



            foreach (Studerende elev in kr.KlasseListe)
            {
                Console.WriteLine(elev);
                
            }

            Console.ReadKey();
        }

        
    }
}
