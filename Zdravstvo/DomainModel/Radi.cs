using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Radi
    {
        public Lekar lekar { get; set; }
        public Bolnica bolnica { get; set; }
        public String odeljenje { get; set; }

        public override string ToString()
        {
            return odeljenje;
        }
    }
}
