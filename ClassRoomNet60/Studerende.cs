using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Studerende
    {
        private string _navn;
        private int _fødelsmåned;
        private int _fødelsdag;

        public Studerende(string navn, int fødelsmåned, int fødelsdag)
        {
            _navn = navn;          
            _fødelsmåned = fødelsmåned;
            _fødelsdag = fødelsdag;
        }

        public string Navn
        {
            get { return _navn; }
            private set { _navn = value; }
        }
        public int Fødelsmåned
        {
            get { return _fødelsmåned; }
            private set { _fødelsmåned = value; }
        }
        
        public int Fødelsdag
        {
            get { return _fødelsdag; }
            private set { _fødelsdag = value; }
        }

        public override string ToString()
        {
            return $"Navn: {Navn}\nFødelsmåned: {Fødelsmåned}\nFødelsdag: {Fødelsdag}";
        }
    }
}
