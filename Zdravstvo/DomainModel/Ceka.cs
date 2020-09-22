using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Ceka
    {
        public Bolnica bolnica { get; set; }
        public Pacijent pacijent { get; set; }
        public String razlog { get; set; }
        public int mestoURedu { get; set; }
        public bool hitno { get; set; }

        public override string ToString()
        {
            return razlog + "_" + ((hitno)?"da":"ne") + "_" + mestoURedu;
        }
    }
}
