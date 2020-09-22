using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel.Views
{
    class PacijentUBolnici
    {
        public PacijentUBolnici(Pacijent p)
        {
            ime = p.ime;
            grad = p.grad;
            datum = p.datum;
            osiguran = p.osiguran;
            bolest = p.nalazi.bolest;
            akcija = "OTPUSTI PACIJENTA";
        }
        public String ime { get; set; }
        public String grad { get; set; }
        public String datum { get; set; }
        public bool osiguran { get; set; }
        public String bolest { get; set; }

        public String akcija { get; set; }

    }
}
