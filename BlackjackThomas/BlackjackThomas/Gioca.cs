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
        public Gioca()
        {
            InitializeComponent();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
