using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUIE_Mail
{
    class Prof : IPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNr { get; set; }
       public string GetEmail()
        {
            return Name + "@hs-flensburg.de";
        }

        public string GetName()
        {
            return Name;
        }

        public int GetNr()
        {
            return RoomNr;
        }
        public override string ToString()
        {
            return "Name \t" + GetName() + "\t Room Nr\t " + GetNr() + " \t E-Mail \t" + GetEmail(); ;
        }
    }
}
