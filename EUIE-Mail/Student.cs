using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUIE_Mail
{
    class Student : IPerson
    {
        public string NameStudent { get ; set; }
        public string EmailStudent { get; set; }
        public int MatriNr { get; set; }
        public string GetEmail()
        {
            return  NameStudent + "@stud.hs-flensburg.de";
        }

        public string GetName()
        {
            return   NameStudent;
        }

        public int GetNr()
        {
            return MatriNr;
        }
        public override string ToString ()
        {
            return "Name \t" + NameStudent + "\t Immatrikulation Nr \t " + MatriNr + " \t E-Mail \t" + GetEmail(); ;
        }
    }
}
