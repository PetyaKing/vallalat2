using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vallalat
{
    public class Tagság
    {
        public int TprojektId;
        public int tdolg;
       

        public Tagság(int tid, int pdolg)
        {
            TprojektId = tid;
            tdolg = pdolg;
            
        }
    }
}
