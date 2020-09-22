using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zdravstvo.DomainModel;

namespace Zdravstvo
{
    public partial class LogInForm : Form
    {
        GraphClient client;
        public Object res1 { get; set; }
        public Object res2 { get; set; }
        public String username { get; set; }
        public String bolnica { get; set; }
        public LogInForm(GraphClient client, String bolnica)
        {
            InitializeComponent();
            this.client = client;
            this.bolnica = bolnica;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //proverava se prvo da li lekar radi u trenutno izabranoj bolnici
            if(!radiUBolnici())
                MessageBox.Show("Lekar ne radi u izabranoj bolnici.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Dictionary<string, object> queryDict = new Dictionary<string, object>();
            //queryDict.Add("username", tbUsername.Text);
            //queryDict.Add("password", tbPassword.Text);

            //var query = new Neo4jClient.Cypher.CypherQuery("match (n:Lekar) where n.username = {username} and n.password = {password} return n",
            //                                                queryDict, CypherResultMode.Set);

            //String proba = Password.Encrypt("1234");
            //String proba2 = Password.Decrypt(proba);

            var query = client.Cypher
                .Match("(n:Lekar)-[r:RADI_U]->(b:Bolnica)")
                .Where("n.username = {username} and n.password = {password}")
                .WithParam("username", tbUsername.Text)
                .WithParam("password", Password.Encrypt(tbPassword.Text))
                .Return((n, r) => new
                    {
                        Lekari = n.As<Lekar>(),
                        RadiU = r.As<Radi>()
                    })
                .Results;


            if (query.ToList().Count > 0)
            {
                this.res1 = query.ToList()[0].Lekari;
                this.res2 = query.ToList()[0].RadiU;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Pogresno korisnicko ime ili lozinka.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            if (this.username != null)
            {
                tbUsername.Text = this.username;
                this.ActiveControl = tbPassword;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool radiUBolnici()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("username", tbUsername.Text);
            queryDict.Add("bolnica", this.bolnica);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Lekar)-[:RADI_U]->(b:Bolnica) where n.username = {username} and b.ime = {bolnica} return n",
                                                            queryDict, CypherResultMode.Set);
            var result = ((IRawGraphClient)client).ExecuteGetCypherResults<Lekar>(query).ToList();

            return (result.Count > 0) ? true : false;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
