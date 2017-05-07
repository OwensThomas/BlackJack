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
    public partial class Gioca : Form
    {
        private Mazzo mazzo;
        private string nomeGiocatore;
        private int numPictureBoxGiocatore = 0;
        private int numPictureBoxBanco = 0;
        private int puntata = 0;
        private int valoreGiocatore = 0;
        private int valoreBanco = 0;
        private int valoreSplit = 0;
        private int soldiIniziali;
        private string vincitore;

        public Gioca(string nomeGiocatore, int soldiIniziali)
        {
            InitializeComponent();
            lblGiocatore.Text += (nomeGiocatore.ToString() != "");
        }
        private void CaricaGioca(object sender, EventArgs e)
        {
            mazzo = new Mazzo();
            mazzo.MescolaMazzo();
            btnCarta.Enabled = false;
            btnResta.Enabled = false;
            btnRigioca.Enabled = false;
          //  lblSoldi.Text = soldi.ToString();

        }



        //bottone per l'uscita del programma
        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
