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

        public void MescolaMazzo()
        {
            
            Random rnd = new Random();
            int num = rnd.Next(50, 100);
            int posizione1;
            int posizione2;
            for (int i=0; i<num; i++)
            {
                posizione1 = rnd.Next(carte.Count);
                do
                {
                    posizione2 = rnd.Next(carte.Count);
                }
                while (posizione1 == posizione2);

                Carta cartaTemp = carte[posizione1];
                carte[posizione1] = carte[posizione2];
                carte[posizione2] = cartaTemp;
            }
        }

        public Carta PescaCarta()
        {
            Carta NuovaCarta = carte[carte.Count-1];
            carte.RemoveAt(carte.Count-1);
            return NuovaCarta;
        }
        public int CarteMazzo()
        {
            return carte.Count;
        }
    }
}
