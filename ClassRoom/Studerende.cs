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

        //Properties
        public string Name {
            get { return _name; }
            private set { _name = value; }
        }

        public int BMonth {
            get { return _bmonth; }
            private set { _bmonth = value; }
        }

        public int BDay
        {
            get { return _bday; }
            private set { _bday = value; }
        }

        //Constructor
        public Studerende(string navn, int bmonth, int bday)
        {
            Name = navn;
            BMonth = bmonth;
            BDay = bday;
        }
    }
}
