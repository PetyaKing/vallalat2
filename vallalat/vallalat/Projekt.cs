using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vallalat
{
    public class Projekt
    {
        public int ProjektId;
        public int Pdolg;
        public bool ProjektVezeto;

        public Projekt(int pid, int pdolg)
        {
            ProjektId = pid;
            Pdolg = pdolg;
        }

    }
}
