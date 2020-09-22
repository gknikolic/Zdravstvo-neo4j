using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Nalazi
    {
        public Pacijent pacijent { get; set; }
        public Bolnica bolnica { get; set; }
        public String bolest { get; set; }

        public override string ToString()
        {
            return bolest;
        }
    }
}
