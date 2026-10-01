using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int szobaszam,int alapar,int extra) : base(szobaszam, alapar)
        {
            extra = ExtraSzolgaltatasAr;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            return (ejszakakSzama*alapar) + ExtraSzolgaltatasAr;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Extra szolgáltatás: {ExtraSzolgaltatasAr} Ft)";
        }
    }
}
