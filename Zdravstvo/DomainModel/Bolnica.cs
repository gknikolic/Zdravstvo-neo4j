using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Bolnica
    {
        public Bolnica()
        {
            cekaonica = new List<Pacijent>();
            hospitalizovani = new List<Pacijent>();
            lekari = new List<Lekar>();
        }

        public String id { get; set; }
        public String ime { get; set; }
        public String adresa { get; set; }
        public String grad { get; set; }
        public int brojKreveta { get; set; }

        public List<Pacijent> cekaonica { get; set; }
        public List<Pacijent> hospitalizovani { get; set; }
        public List<Lekar> lekari { get; set; }
        public int brojSlobodnih { get { return brojKreveta - hospitalizovani.Count; } }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Naziv ustanove: " + ime);
            sb.AppendLine("Adresa:" + adresa + ", " + grad);
            sb.AppendLine("Broj kreveta: " + brojKreveta.ToString());
            sb.AppendLine("Broj slobodnih kreveta: " + brojSlobodnih.ToString());
            sb.AppendLine("Broj zaposljenih doktora: " + lekari.Count.ToString());
            return sb.ToString();
        }


    }
}
