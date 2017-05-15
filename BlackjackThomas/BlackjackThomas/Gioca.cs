using BlackjackThomas;
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
        private List<Carta> ManoDealer;
     //   private List<carta> pictureBoxB1;
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
            lblGiocatore.Text = nomeGiocatore;
            lblSoldi.Text = soldiIniziali.ToString();

        }

        private void Gioca_Load(object sender, EventArgs e)
        {

            mazzo = new Mazzo();
            mazzo.MescolaMazzo();
            ManoGiocatore = new List<Carta>();
           // pictureBoxB1 = new List<Label>();

            Carta carta1 = mazzo.PescaCarta();
            btnCarta.Visible = false;
            btnResta.Visible = false;
            btnRigioca.Enabled = true;
            btnAsso1.Visible = false;
            btnAsso11.Visible = false;
            btnDoppio.Visible = false;
            btnSplit.Visible = false;


            ManoGiocatore.Add(carta1);

            Label lblcata1 = new Label();
            string nomeimg = "../" + carta1.ToString() + ".bmp";
            Image imgcarta1 = Image.FromFile(nomeimg);
            lblcarta1.Image = imgcarta1;

        }






        //bottone per l'uscita del programma
        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pictureBoxB1_Click(object sender, EventArgs e)
        {

        }

        private void btnRigioca_Click(object sender, EventArgs e)
        {
            mazzo = new Mazzo();
            mazzo.MescolaMazzo();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btn5.Enabled = true;
            btn10.Enabled = true;
            btn25.Enabled = true;
            btn50.Enabled = true;
            btnRigioca.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
