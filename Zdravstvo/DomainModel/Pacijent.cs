using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdravstvo.DomainModel
{
    class Pacijent
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String grad { get; set; }
        public String datum { get; set; }
        public bool osiguran { get; set; }
        public String status { get; set; }
        public Ceka ceka { get; set; }
        public Nalazi nalazi { get; set; }
        public List<Izvestaj> izvestaji { get; set; }
        public Lekar izabrani { get; set; }
        public void u_cekaonici(Bolnica n, String razlog, int mestoURedu, bool hitno)
        {
            ceka = new Ceka();
            ceka.bolnica = n;
            ceka.pacijent = this;
            ceka.razlog = razlog;
            ceka.mestoURedu = mestoURedu;
            ceka.hitno = hitno;
            n.cekaonica.Add(this);
        }

        public void nalazi_u(Bolnica n, String bolest)
        {
            nalazi = new Nalazi();
            nalazi.bolnica = n;
            nalazi.pacijent = this;
            nalazi.bolest = bolest;
            n.hospitalizovani.Add(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Naziv pacijent: " + ime);
            sb.AppendLine("Grad: " + grad);
            sb.AppendLine("Datum rodjenja: " + datum);
            sb.AppendLine("Osiguran " + ((osiguran) ? "da" : "ne"));
            sb.AppendLine("Status: " + status);
            sb.AppendLine("Izabrani lekar: " + izabrani.ime + " - " + izabrani.username);
            return sb.ToString();
        }

        public Pacijent()
        {
            izvestaji = new List<Izvestaj>();
        }
    }
}
