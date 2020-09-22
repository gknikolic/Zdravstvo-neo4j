using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zdravstvo.DomainModel
{
    class Lekar
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String grad { get; set; }
        public String datum { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public Radi radi { get; set; }

        //sta moze lekar da uradi
        public void dao(Izvestaj izvestaj, Pacijent pacijent)
        {
            pacijent.izvestaji.Add(izvestaj);
        }
        public void radi_u(Bolnica bolnica, String odeljenje)
        {
            radi = new Radi();
            radi.bolnica = bolnica;
            radi.lekar = this;
            radi.odeljenje = odeljenje;
            bolnica.lekari.Add(this);
        }
        public void smesti_pacijenta(Pacijent pacijent, Bolnica bolnica, String bolest)
        {
            pacijent.nalazi_u(bolnica, bolest);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ime: " + ime);
            sb.AppendLine("Grad: " + grad);
            sb.AppendLine("Datum rodj: " + datum);
            sb.AppendLine("Korisnicko ime: " + username);
            sb.AppendLine("odeljenje: " + radi.odeljenje);
            return sb.ToString();
        }
    }
}
