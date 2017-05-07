using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackThomas
{
    public partial class Inizio : Form
    {
        public string nomeGiocatore;
        public int soldiIniziali = 5000;
        public Inizio()
        {
            InitializeComponent();
        }
        private void btnGioca_Click(object sender, EventArgs e)
        {
            nomeGiocatore = txtGiocatore.Text;
            Gioca newForm = new Gioca(nomeGiocatore, soldiIniziali);
            newForm.Show();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
