using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        string Name;
        int Birthmonth;
        int Birthday;

        public Studerende(string navn, int bmonth, int bday)
        {
            Name = navn;
            Birthmonth = bmonth;
            Birthday = bday;
        }
    }
}
