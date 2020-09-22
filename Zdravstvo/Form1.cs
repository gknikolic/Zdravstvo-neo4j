using Neo4j.Driver;
using Neo4jClient;
using Neo4jClient.Cypher;
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
using Zdravstvo.DomainModel.Views;

namespace Zdravstvo
{
    public partial class Form1 : Form
    {
        private GraphClient client;

        private List<Bolnica> bolnice; //sve bolnice
        private Bolnica _bolnica; //izabrana bolnica
        private Lekar _lekar; //trenutni lekar (ulogovani)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();

                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Bolnica) return n", new Dictionary<String, Object>(), Neo4jClient.Cypher.CypherResultMode.Set);
                this.bolnice = ((IRawGraphClient)client).ExecuteGetCypherResults<Bolnica>(query).ToList();

                foreach (Bolnica b in bolnice)
                {
                    cbBolnice.Items.Add(b.ime);
                }

                //dgvCekaonica.Columns[5].Visible = ((_lekar == null) ? false : true);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void ucitajDGV<T>(DataGridView dgv, List<T> list)
        {
            dgv.DataSource = new BindingList<T>(list);
            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewElementStates states = DataGridViewElementStates.None;
            //var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            //dgv.ClientSize = new Size(totalWidth, dgv.Height);
            dgv.ScrollBars = ScrollBars.Both;
            dgv.ClearSelection();
            dgv.MultiSelect = false;
        }
        private void dgvLekari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnIzbrisiLekara.Enabled = true;
        }

        private void dgvLekari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzbrisiLekara.Enabled = false;
        }

        private void cbBolnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Bolnica b in bolnice)
                if (b.ime.Equals(cbBolnice.SelectedItem))
                    this._bolnica = b;

            ucitajCekaonicu();
            ucitajHospitalizovane();
            ucitajLekare();

            tbInfoBolnica.Visible = true;
            tbInfoBolnica.Text = _bolnica.ToString();


            btnLogIn.Enabled = true;
            btnDodajLekara.Enabled = true;
            btnDodajUCekaonicu.Enabled = true;
        }

        private void ucitajLekare()
        {
            var query = client.Cypher
                .Match("(n:Bolnica)<-[r:RADI_U]-(l:Lekar)")
                .Where("n.ime = {bolnica}")
                .WithParam("bolnica", _bolnica.ime)
                .Return((l, r) => new
                {
                    Lekari = l.As<Lekar>(),
                    RadiU = r.As<Radi>()
                })
                .Results;

            this._bolnica.lekari = new List<Lekar>();

            foreach(var red in query)
                red.Lekari.radi_u(_bolnica, red.RadiU.odeljenje);

            ucitajDGV(dgvLekari, _bolnica.lekari);
            dgvLekari.Columns[0].Visible = false;
            dgvLekari.Columns[5].Visible = false;
            dgvLekari.Columns[6].HeaderText = "Odeljenje";
        }

        private void ucitajCekaonicu()
        {
            var query = client.Cypher
                .Match("(i:Lekar)<-[:IZABRANI]-(p:Pacijent)-[r:U_CEKAONICI]->(b:Bolnica)")
                .Where("b.ime = {bolnica}")
                .WithParam("bolnica", _bolnica.ime)
                .Return((p, r, i) => new
                {
                    Pacijenti = p.As<Pacijent>(),
                    CekaU = r.As<Ceka>(),
                    Izabrani = i.As<Lekar>()
                })
                .OrderBy("r.mestoURedu")
                .Results;

            _bolnica.cekaonica = new List<Pacijent>();

            List<PacijentUCekaonici> zaPrikaz = new List<PacijentUCekaonici>();

            foreach(var red in query)
            {
                red.Pacijenti.u_cekaonici(_bolnica, red.CekaU.razlog, red.CekaU.mestoURedu, red.CekaU.hitno);
                red.Pacijenti.izabrani = red.Izabrani;
                zaPrikaz.Add(new PacijentUCekaonici(red.Pacijenti));
            }

            ucitajDGV<PacijentUCekaonici>(dgvCekaonica, zaPrikaz);

            foreach(DataGridViewRow red in dgvCekaonica.Rows)
            {
                if ((bool)red.Cells["hitno"].Value)
                    red.DefaultCellStyle.BackColor = Color.Red;
            }

            dgvCekaonica.Columns[5].Visible = (_lekar == null) ? false : true;
        }
        private void dgvCekaonica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                MessageBox.Show(_bolnica.cekaonica[e.RowIndex].ToString(), "INFORMACIJE O PACIJENTU", MessageBoxButtons.OK);
            }
            if(e.ColumnIndex == dgvCekaonica.Columns["Akcija"].Index)
            {
                using (NapisiIzvestaj dialog = new NapisiIzvestaj(client))
                {
                    dialog.pacijent = _bolnica.cekaonica[e.RowIndex];
                    dialog.lekar = _lekar.username;
                    dialog.bonica = _bolnica.ime;
                    dialog.imePacijenta = _bolnica.cekaonica[e.RowIndex].ime;
                    dialog.razlog = dgvCekaonica.Rows[e.RowIndex].Cells["razlog"].Value.ToString();

                    var result = dialog.ShowDialog();

                    if(result == DialogResult.OK)
                    {
                        ucitajCekaonicu();
                        ucitajHospitalizovane();
                    }
                }
            }
        }

        private void ucitajHospitalizovane()
        {
            var query = client.Cypher
              .Match("(i:Lekar)<-[:IZABRANI]-(p:Pacijent)-[r:NALAZI_U]->(b:Bolnica)")
              .Where("b.ime = {bolnica}")
              .WithParam("bolnica", _bolnica.ime)
              .Return((p, r, i) => new
              {
                  Pacijenti = p.As<Pacijent>(),
                  Nalazi = r.As<Nalazi>(),
                  Izabrani = i.As<Lekar>()
              })
              .Results;

            _bolnica.hospitalizovani = new List<Pacijent>();

            List<PacijentUBolnici> zaPrikaz = new List<PacijentUBolnici>();

            foreach (var red in query)
            {
                red.Pacijenti.izabrani = red.Izabrani;
                red.Pacijenti.nalazi_u(_bolnica, red.Nalazi.bolest);
                zaPrikaz.Add(new PacijentUBolnici(red.Pacijenti));
            }


            ucitajDGV<PacijentUBolnici>(dgvHospitalizovani, zaPrikaz);

            dgvHospitalizovani.Columns[5].Visible = (_lekar == null) ? false : true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (LogInForm login = new LogInForm(client, _bolnica.ime))
            {
                if(dgvLekari.SelectedRows.Count > 0)
                {
                    login.username = dgvLekari.SelectedRows[0].Cells[4].Value.ToString();
                }

                //String enPassword = Password.Encrypt("1234", Form1.passKey);
                //String denPassword = Password.Decrypt(enPassword, Form1.passKey);

                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _lekar = login.res1 as Lekar;
                    var pom = login.res2 as Radi;
                    _lekar.radi_u(_bolnica, pom.odeljenje);

                    groupLekari.Visible = false;
                    tbInfoLekar.Text = _lekar.ToString();
                    tbInfoLekar.Visible = true;
                    btnLogOut.Visible = true;

                    dgvCekaonica.Columns[5].Visible = true; 
                    dgvHospitalizovani.Columns[5].Visible = true;
                    cbBolnice.Enabled = false;
                    btnIzabraniLekar.Enabled = true;
                }
            }


        }
        private void btnDodajLekara_Click(object sender, EventArgs e)
        {
            using (DodajLekara diag = new DodajLekara(client, _bolnica.ime))
            {
                var result = diag.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ucitajLekare();
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _lekar = null;
            groupLekari.Visible = true;
            tbInfoLekar.Visible = false;
            btnLogOut.Visible = false;
            dgvCekaonica.Columns[5].Visible = false;
            dgvHospitalizovani.Columns[5].Visible = false;
            cbBolnice.Enabled = true;
            btnIzabraniLekar.Enabled = false;
        }

        private void btnIzbrisiLekara_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show(@"Da li ste siguni da zelite da obrisete lekara "
                    + dgvLekari.SelectedRows[0].Cells[1].Value.ToString() + "?", "POTVRDA BRISANJA", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(potvrda == DialogResult.Yes)
            {
                var query = client.Cypher
                    .Match("(lekar:Lekar)")
                    .Where("lekar.username = {username}")
                    .WithParam("username", dgvLekari.SelectedRows[0].Cells[4].Value.ToString())
                    .DetachDelete("lekar");

                query.ExecuteWithoutResults();

                ucitajLekare();
                btnIzbrisiLekara.Enabled = false;
            }
        }

        private void btnDodajUCekaonicu_Click(object sender, EventArgs e)
        {
            using(DodajPacijenta form = new DodajPacijenta(client))
            {
                form.imeBolnice = _bolnica.ime;
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    ucitajCekaonicu();
            }
        }

        private void btnVanBolnice_Click(object sender, EventArgs e)
        {
            var query = client.Cypher
                .Match("(p:Pacijent)")
                .Where("NOT (p)-->(:Bolnica)")
                .Return(p => new { Pacijenti = p.As<Pacijent>() })
                .Results;

            StringBuilder sb = new StringBuilder();

            foreach (var red in query)
                sb.AppendLine(red.Pacijenti.ime + ", " + red.Pacijenti.grad);
            MessageBox.Show(sb.ToString(), "Pacijenti koji nisu u bolnicu.", MessageBoxButtons.OK);
        }

        private void dgvHospitalizovani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                MessageBox.Show(_bolnica.hospitalizovani[e.RowIndex].ToString(), "INFORMACIJE O PACIJENTU", MessageBoxButtons.OK);
            }
            if (e.ColumnIndex == dgvHospitalizovani.Columns["Akcija"].Index)
            {
                var query = client.Cypher
                    .Match("(p:Pacijent)-[r:NALAZI_U]->(b:Bolnica)")
                    .Where("p.ime = {ime} and b.ime = {bolnica}")
                    .WithParam("ime", dgvHospitalizovani.Rows[e.RowIndex].Cells["ime"].Value.ToString())
                    .WithParam("bolnica", _bolnica.ime)
                    .Delete("r");

                query.ExecuteWithoutResults();

                ucitajHospitalizovane();
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Da biste ucitali pacijente i lekare, morate prvo odabrati bolinicu.");
            sb.AppendLine("2. Svim dodatim lekarima za testiranje je SIFRA 1234, a KORISNICKO IME je samo njihovo ime malim slovima.");
            sb.AppendLine("3. Da bi se otvorile akcije za pacijente, mora se ulogovati neki lekar ");
            sb.AppendLine("4. Ponudjeni su lekari koji rade u tu bonicu. (korisnicko ime za ponudjene lekare se automatski prenosi u formu \"Log in \" ako se selektuje red u kome je taj lekar)");
            sb.AppendLine("5. Pamte se i pacijenti koji su bilo kada bili u bilo koju bolnicu, a trenutno se ne nalaze u njoj");
            sb.AppendLine("6. Moguce je registrovanje novih lekara kao i novih pacijenata.");
            sb.AppendLine("7. Kada je pacijent u cekaonici on moze biti pregledan, a posle toga biti smesten u bolnicu ako ima potreba, a ako nema onda se pacijent salje kuci");
            sb.AppendLine("8. Uz svaki pregled pise se izvestaj koji se odnosi na pregledanog pacijenta i sadrzi potpis lekara koji je izvrsio pregled kao i dijagnozu.");
            sb.AppendLine("9. Pacijenti su u cekaonici sortirani po mestu u redu na kome se nalaze. (ima i hitnih slucajeva)");
            sb.AppendLine("10. Lekar moze pogledati istoriju bolesti za pacijenta koga trenutno pregleda tokom pisanja izvestaja.");

            MessageBox.Show(sb.ToString(), "Istrukcije za rad sa programom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIzabraniLekar_Click(object sender, EventArgs e)
        {
            var query = client.Cypher
                .Match("(l:Lekar)<-[:IZABRANI]-(p:Pacijent)")
                .Where("l.username = {username}")
                .WithParam("username", _lekar.username)
                .Return(p => new
                {
                    Pacijenti = p.CollectAs<Pacijent>(),
                    broj = p.Count()
                })
                .Results;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lekar " + _lekar.ime + " ima " + query.ToList()[0].broj + " pacijenata.");
            sb.AppendLine("");
            
            foreach (Pacijent pacijent in query.ToList()[0].Pacijenti)
            {
                sb.AppendLine(pacijent.ime + ", " + pacijent.grad);
            }
            MessageBox.Show(sb.ToString(), "Pacijenti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
