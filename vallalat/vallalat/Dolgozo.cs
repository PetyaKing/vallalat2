using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vallalat
{
    public class Dolgozo
    {
        public int DolgozoId;
        public string Nev;
        public string Jelszo;
        

        public Dolgozo(int id, string nev, string jelszo)
        {
            Nev = nev;
            DolgozoId = id;
            Jelszo = jelszo;
        }
      /*  public override string ToString()
        {
            return string.Format("{0} {1} {2}", DolgozoId, Nev, Jelszo);
        }
        public void dolgozik()
        {
            Console.WriteLine("{0} Nyomja a prest", Nev);
        } */
    }
}
