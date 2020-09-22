using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdravstvo
{
    public partial class PrikazIstorije : Form
    {
        public PrikazIstorije()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PrikazIstorije_Load(object sender, EventArgs e)
        {
            
        }
    }
}
