using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int Szobaszam { get; }
        protected int alapar;

        public int Alapar {
            get { return alapar;} 
            set
            {
                if (alapar >0) alapar=value;
            } 
        }

        public Szoba(int szobaszam, int ar)
        {
            szobaszam = Szobaszam;
            ar = Alapar;
            

        }
        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }
        public override string ToString()
        {
            return $"Szoba {Szobaszam} | Alapár: {Alapar} Ft/éj";
        }
    }
}
