using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class KlasseRum
    {
        private string _klasseNavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterStart;

        public KlasseRum() { }

        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public override string ToString()
        {
            return $"Klasse navn: {KlasseNavn}\nKlasse liste: {Klasseliste.Count}\nSemester start: {SemesterStart}";
        }
    }
}
