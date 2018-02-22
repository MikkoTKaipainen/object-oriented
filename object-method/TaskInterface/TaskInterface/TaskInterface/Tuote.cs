using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Tuote : ITuote
    {
        public string nimi;
        public int yksikköhinta;
        public int lukumäärä;

        public Tuote(string nimi, int yksikköhinta, int lukumäärä)
        {
            this.nimi = nimi;
            this.yksikköhinta = yksikköhinta;
            this.lukumäärä = lukumäärä;
        }

        
    }
}
