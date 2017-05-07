using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackThomas
{
    class Carta
    {
        public string suit { set; get; }
        public int value { set; get; }
        public int card_number { set; get; }

        public Carta()
        {
            value = -1;
            suit = "";
            card_number = -1;
        }
    }
}
