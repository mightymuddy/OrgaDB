using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgaMS
{
    public partial class frmAuftraege : Form
    {
        Form form;
        public frmAuftraege(ref Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        public frmAuftraege()
        {
            InitializeComponent();
        }



        private void ClearText(object sender, EventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            txtSender.Clear();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Auftraege auftrag = new Auftraege(
                iAuftr: int.Parse(txtAuftragsNr.Text),
                sTitle: txtAuftragstitel.Text,
                kat: cbKategorie.SelectedIndex,
                date: Convert.ToDateTime(txtAuftrErstDatum.Text),
                iKN: int.Parse(txtKuNummer.Text),
                sDesc: txtAuftrDesc.Text
                ) ;

            DataManager.writeNewAuftrag(auftrag);

            
        }

        private void frmAuftraege_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OpenForm(this, new frmAuftraege());
        }
    }
}
