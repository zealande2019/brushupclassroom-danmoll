using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        //Instance fields
        string _klasseNavn;
        List<Studerende> _klasseListe;
        DateTime _semesterStart;

        //Properties
        public string KlasseNavn {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }
        public List<Studerende> KlasseListe {
            get { return _klasseListe; }
        }
        DateTime SemesterStart {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

        //Constructor
        public KlasseRum()
        {

        }

    }
}
