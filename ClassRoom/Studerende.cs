using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        //Instance fields
        string _name;
        int _bmonth;
        int _bday;

        //Constructor
        public Studerende(string navn, int bmonth, int bday)
        {
            _name = navn;
            _bmonth = bmonth;
            _bday = bday;
        }
    }
}
