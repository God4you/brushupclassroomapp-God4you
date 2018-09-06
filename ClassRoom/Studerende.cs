using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private int _fødselsmåned;
        public String Navn { get; set; }

        public int Fødselsmåned
        {
            get => _fødselsmåned;
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _fødselsmåned = value;
                }
                else
                {
                    throw new Exception("Der er kun 12 måneder");
                }
            }
        }

        public int Fødselsdag { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        public string Årstid()
        {
            string årstid = null;
            switch (Fødselsmåned)
            {
                case 12:
                case 1:
                case 2:
                    årstid = "vinter";
                    break;
                case 3:
                case 4:
                case 5:
                    årstid = "Forår";
                    break;
                case 6:
                case 7:
                case 8:
                    årstid = "Sommer";
                    break;
                case 9:
                case 10:
                case 11:
                    årstid = "Efterår";
                    break;
            }

            return årstid;
        }

        public override string ToString()
        {
            return Navn + "-" + Fødselsmåned + "-" + Fødselsdag + " " + Årstid();
        }
    }
}
