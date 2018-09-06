using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public String KlasseNavn { get; set; }
        public List<Studerende> KlasseListe { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void AntalFødselsdag()
        {
            var queryAntalFødsesldag = from studerende in KlasseListe group studerende by studerende.Årstid();
            foreach (IGrouping<string, Studerende> årstid in queryAntalFødsesldag)
            {
                Console.WriteLine("Der er " + årstid.Count() + " der har fødselsdag til " + årstid.Key);
           
            }
        }
    }
}
