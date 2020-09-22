using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Izvestaj
    {
        public String id { get; set; }
        public String bolest { get; set; }
        public String terapija { get; set; }
        public String kontrola { get; set; }
        public bool hospitalizacija { get; set; }
        public String datum { get; set; }
        public Pacijent pacijent { get; set; }
        public Lekar lekar { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("================IZVESTAJ===================");
            sb.AppendLine("Datum pregleda: " + datum);
            sb.AppendLine("Naziv bolesti: " + bolest);
            sb.AppendLine("Terapija: " + terapija);
            sb.AppendLine("Kontrola: " + kontrola);
            sb.AppendLine("Potrebna hospitalizacija: " + ((hospitalizacija) ? "Da" : "Ne"));
            sb.AppendLine("Potpis lekara: " + lekar.ime);
            sb.AppendLine("===========================================");
            return sb.ToString();
        }
    }
}
