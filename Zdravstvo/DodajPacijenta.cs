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

namespace Zdravstvo.DomainModel
{
    public partial class DodajPacijenta : Form
    {
        private GraphClient client;
        public String imeBolnice { get; set; }

        List<bool> polja;
        public DodajPacijenta(GraphClient client)
        {
            InitializeComponent();
            this.client = client;
            polja = new List<bool>(5);
        }

        private void DodajPacijenta_Load(object sender, EventArgs e)
        {
            var query = client.Cypher
                .Match("(p:Pacijent)")
                .Where("NOT (p)-->(:Bolnica)")
                .Return(p => new { Pacijenti = p.As<Pacijent>() })
                .Results;

            foreach(var red in query)
            {
                lbPacijenti.Items.Add(red.Pacijenti.ime + ", " + red.Pacijenti.grad);
            }

            var query2 = client.Cypher
                .Match("(l:Lekar)-->(b:Bolnica)")
                .Where("b.ime = {bolnica}")
                .WithParam("bolnica", imeBolnice)
                .Return(l => new { Lekar = l.As<Lekar>() })
                .Results;

            foreach (var red in query2)
                cbLekari.Items.Add(red.Lekar.ime);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var maxId = client.Cypher
                .Match("(p:Pacijent)-[r:U_CEKAONICI]->(b:Bolnica {ime: {imeBolnice}})")
                .WithParam("imeBolnice", imeBolnice)
                .Return(r => new { Ceka = r.As<Ceka>() })
                .OrderByDescending("r.mestoURedu")
                .Results;
            int max = maxId.ToList()[0].Ceka.mestoURedu; //da bude zadnji u redu
            max++; //da bude iza zadnjeg


            var query = client.Cypher
                .Match("(p:Pacijent)")
                .Match("(b:Bolnica)")
                .Where("p.ime = {ime} and b.ime = {bolnica}")
                .WithParam("ime", lbPacijenti.SelectedItem.ToString().Split(',')[0])
                .WithParam("bolnica", imeBolnice)
                .Create("(p)-[r:U_CEKAONICI {razlog: {razlog}, hitno: {hitno}, mestoURedu: {mesto}}]->(b)")
                .WithParam("razlog", tbRazlog.Text)
                .WithParam("hitno", cbHitno.Checked)
                .WithParam("mesto", max);

            query.ExecuteWithoutResults();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbPacijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            var maxId = client.Cypher
                .Match("(p:Pacijent)-[r:U_CEKAONICI]->(b:Bolnica {ime: {imeBolnice}})")
                .WithParam("imeBolnice", imeBolnice)
                .Return(r => new { Ceka = r.As<Ceka>() })
                .OrderByDescending("r.mestoURedu")
                .Results;
            int max = maxId.ToList()[0].Ceka.mestoURedu; //da bude zadnji u redu
            max++; //da bude iza zadnjeg

            var query = client.Cypher
                .Match("(l:Lekar {ime : {imeLekara}})-->(b:Bolnica {ime: {bolnica} })")
                .Create("(p:Pacijent {ime: {ime}, grad: {grad}, datum: {datum}, status: {radniOdnos}, osiguran: {osiguran}})")
                .WithParam("ime", tbIme.Text)
                .WithParam("grad", tbGrad.Text)
                .WithParam("datum", tbDatum.Text)
                .WithParam("radniOdnos", tbStatus.Text)
                .WithParam("osiguran", cbOsiguran.Checked)
                .WithParam("bolnica", imeBolnice)
                .WithParam("imeLekara", cbLekari.SelectedItem.ToString())
                .Create("(p)-[:IZABRANI]->(l)")
                .Create("(p)-[r:U_CEKAONICI {razlog: {razlog}, hitno: {hitno}, mestoURedu: {mesto}}]->(b)")
                .WithParam("razlog", tbRazlog.Text)
                .WithParam("hitno", cbHitno.Checked)
                .WithParam("mesto", max);

            query.ExecuteWithoutResults();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
