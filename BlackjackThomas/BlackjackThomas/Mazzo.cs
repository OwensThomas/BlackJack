using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackThomas
{
    public class Mazzo
    {
        public List<Carta> carte = new List<Carta>();
        private const int CarteMazzo = 52;

        public void MescolaMazzo()
        {
            int num,i;
            num = 0;
            Random rnd = new Random();
            Carta tmp;

            for (i=0; i<num; i++)
            {
                int id1 = rnd.Next(0, carte.Count);
                int id2 = rnd.Next(0, carte.Count);
                tmp = carte[id1];
                carte[id1] = carte[id2];
                carte[id2] = tmp;
            }
        }

        public Carta PescaCarta()
        {
            Carta NuovaCarta = carte.First();
            carte.Remove(carte.First());
            return NuovaCarta;
        }
    }
}
