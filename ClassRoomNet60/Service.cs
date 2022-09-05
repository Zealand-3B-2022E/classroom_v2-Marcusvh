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

        public void HvilkenÅrstid(KlasseRum klasseRum)
        {
            int vinter = 0;
            int forår = 0;
            int sommer = 0;
            int efterår = 0;

            foreach (var list in klasseRum.Klasseliste)
            {
                int måned = list.Fødelsmåned;
                if(måned <= 0 || måned > 12)
                {
                    //throw new ArgumentOutOfRangeException("welp");
                    return;
                }

                if (måned == 12 || måned == 1 || måned == 2)
                {
                    vinter++;
                }
                if (måned == 3 || måned == 4 || måned == 5)
                {
                    forår++;
                }
                if (måned == 6 || måned == 7 || måned == 8)
                {
                    sommer++;
                }
                if (måned == 9 || måned == 10 || måned == 11)
                {
                    efterår++;
                }
            }

            Console.WriteLine($"Vinter: {vinter}");
            Console.WriteLine($"Forår: {forår}");
            Console.WriteLine($"Sommer: {sommer}");
            Console.WriteLine($"Efterår: {efterår}");
        }
    }

}
