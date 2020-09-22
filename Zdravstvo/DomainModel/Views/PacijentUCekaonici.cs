using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class PacijentUCekaonici
    {
        public PacijentUCekaonici(Pacijent p)
        {
            ime = p.ime;
            red = p.ceka.mestoURedu;
            osiguran = p.osiguran;
            razlog = p.ceka.razlog;
            hitno = p.ceka.hitno;
        }
        public int red { get; set; }
        public String ime { get; set; }
        public String razlog { get; set; }
        public bool osiguran { get; set; }
        public bool hitno { get; set; }
        public String Akcija { get { return "PREGLEDAJ PACIJENTA"; } }
    }
}
