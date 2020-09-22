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

namespace Zdravstvo
{
    public partial class DodajLekara : Form
    {
        GraphClient client;
        public String bolnica { get; set; }
        public DodajLekara(GraphClient client, String bolnica)
        {
            InitializeComponent();
            this.client = client;
            this.bolnica = bolnica;
        }

        private void DodajLekara_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Dictionary<string, object> queryDict = new Dictionary<string, object>();
            //queryDict.Add("ime", tbIme.Text);
            //queryDict.Add("grad", tbGrad.Text);
            //queryDict.Add("datum", tbDatum.Text);
            //queryDict.Add("odeljenje", tbOdeljenje.Text);
            //queryDict.Add("username", tbUsername.Text);
            //queryDict.Add("password", tbPassword.Text);
            //queryDict.Add("bolnica", this.bolnica);

            //var query = new Neo4jClient.Cypher.CypherQuery( "match (b:Bolnica {ime:{bolnica}})" +
            //                                                "CREATE(l: Lekar { ime:{ime}, datum: {datum}, grad: {grad}})" +
            //                                                "create(l)-[:RADI_U{odeljenje: {odeljenje}]->(b)",
            //                                                queryDict, CypherResultMode.Set);

            //var result = ((IRawGraphClient)client).ExecuteGetCypherResults<Lekar>(query).ToList();

            var query = client.Cypher
                .Match("(b:Bolnica {ime:{bolnica}})")
                .Create("(l: Lekar { ime: { ime}, datum: { datum}, grad: { grad}, username: {username}, password: {password} })")
                .Create("(l)-[r:RADI_U{odeljenje: {odeljenje}}]->(b)")
                .WithParam("ime", tbIme.Text)
                .WithParam("grad", tbGrad.Text)
                .WithParam("datum", tbDatum.Text)
                .WithParam("odeljenje", tbOdeljenje.Text)
                .WithParam("username", tbUsername.Text)
                .WithParam("password", Password.Encrypt(tbPassword.Text))
                .WithParam("bolnica", this.bolnica)
                .Return(l => new
                {
                    Lekar = l.As<Lekar>()
                })
                .Results;

            if(query.ToList().Count == 0)
            {
                MessageBox.Show("Lekar nije kreiran.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
