using Neo4j.Driver;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zdravstvo.DomainModel;

namespace Zdravstvo
{
    public partial class NapisiIzvestaj : Form
    {
        private GraphClient client;
        public NapisiIzvestaj(GraphClient client)
        {
            InitializeComponent();
            this.client = client;
        }
        public Object pacijent { get; set; }
        public String imePacijenta { get; set; }
        public String lekar { get; set; }
        public String bonica { get; set; }
        public String razlog { get; set; }

        private void NapisiIzvestaj_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INFORMACIJE O PACIJENTU:");
            sb.AppendLine();
            sb.AppendLine(pacijent.ToString());
            tbInfoPacijent.Text = sb.ToString();
            tbDatum.Text = System.DateTime.Today.ToString("d");
            tbRazlog.Text = razlog;
        }

        private void btnIstorija_Click(object sender, EventArgs e)
        {
            using(PrikazIstorije forma = new PrikazIstorije())
            {
                forma.tbPacijent.Text = imePacijenta;

                var query = client.Cypher
                    .Match("(p:Pacijent)-[:IMA]->(i:Izvestaj)<-[:DAO]-(l:Lekar)")
                    .Where("p.ime = {ime}")
                    .WithParam("ime", imePacijenta)
                    .Return((i, l) => new
                    {
                        Izvestaj = i.As<Izvestaj>(),
                        Lekar = l.As<Lekar>()
                    })
                    .OrderBy("i.datum")
                    .Results;

                String text = "";
                foreach (var r in query)
                {
                    r.Izvestaj.lekar = r.Lekar;
                    text += r.Izvestaj.ToString();
                }


                forma.richTextBox1.Text = text;

                forma.ShowDialog();
            }
        }

        private void btnKolikoPuta_Click(object sender, EventArgs e)
        {
            var query = client.Cypher
                .Match("(p:Pacijent)-[:IMA]->(i:Izvestaj)")
                .Where("p.ime = {ime} and i.hospitalizacija = true")
                .WithParam("ime", imePacijenta)
                .Return(i => new { brojIzvestaja = i.Count()})
                .Results;

            MessageBox.Show(query.ToList()[0].brojIzvestaja.ToString(), "Odgovor", MessageBoxButtons.OK);
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if(cbHospitalizacija.Checked)
            {
                var query = client.Cypher
                    .Match("(p:Pacijent)-[r:U_CEKAONICI]->(b:Bolnica)")
                    .Where("p.ime = {ime} and b.ime = {bolnica}")
                    .WithParam("ime", imePacijenta)
                    .WithParam("bolnica", bonica)
                    .WithParam("bolest", tbBolest.Text)
                    .Merge("(p)-[u:NALAZI_U{bolest: {bolest}}]->(b)")
                    .Delete("r");

                query.ExecuteWithoutResults();
            }
            else
            {
                var izbaciIzCekaonicu = client.Cypher
                    .Match("(p:Pacijent)-[r:U_CEKAONICI]->(b:Bolnica)") 
                    .Where("p.ime = {ime} and b.ime = {bolnica}")
                    .WithParam("ime", imePacijenta)
                    .WithParam("bolnica", bonica)
                    .Delete("r");

                izbaciIzCekaonicu.ExecuteWithoutResults();
            }
            var DodajIzvestaj = client.Cypher
                .Match("(l:Lekar)-->(b:Bolnica)")
                .Match("(p:Pacijent)")
                .Where("p.ime = {ime} and b.ime = {bolnica} and l.username = {username}")
                .Create("(i:Izvestaj {bolest: {bolest}, kontrola: {kontrola}, terapija: {terapija}, hospitalizacija:{hospitalizacija}, datum: {datum}})")
                .WithParam("bolest", tbBolest.Text)
                .WithParam("kontrola", numKotrola.Value)
                .WithParam("terapija", tbTerapija.Text)
                .WithParam("hospitalizacija", cbHospitalizacija.Checked)
                .WithParam("datum", tbDatum.Text)
                .WithParam("ime", imePacijenta)
                .WithParam("bolnica", bonica)
                .WithParam("username", lekar)
                .Create("(p)-[:IMA]->(i)<-[:DAO]-(l)");

            DodajIzvestaj.ExecuteWithoutResults();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbHospitalizacija_CheckedChanged(object sender, EventArgs e)
        {
            btnZavrsi.Text = (cbHospitalizacija.Checked) ? "Smesti u bolnicu" : "Zavrsi pregled";
        }
    }
}
