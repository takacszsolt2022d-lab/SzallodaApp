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

        public int Alapar { get; set
            {
                if (alapar <= 0)
                {
                    Console.WriteLine("Nem lehet kisebb vagy 0.");
                }
            } }
        public Szoba(int szobaszam, int alapar)
        {
            szobaszam = Szobaszam;
            alapar = Alapar;
            

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
