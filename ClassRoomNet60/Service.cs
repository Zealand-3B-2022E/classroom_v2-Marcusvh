using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Service
    {

        public string Årstid(int måned)
        {
            string årstid = "";
            if (måned == 12 || måned == 1 || måned == 2)
            {
                årstid = "Vinter";
            }
            if (måned == 3 || måned == 4 || måned == 5)
            {
                årstid = "Forår";
            }
            if (måned == 6 || måned == 7 || måned == 8)
            {
                årstid = "Sommer";
            }
            if (måned == 9 || måned == 10 || måned == 11)
            {
                årstid = "Efterår";
            }

            return årstid;
        }
    }
}
