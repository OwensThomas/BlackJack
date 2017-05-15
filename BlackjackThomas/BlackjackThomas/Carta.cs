using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackThomas
{
    //dato che il programma legge come primo numero l'asso quindi '0' riassegno i valori corretti per ciascuna carta
    public class Carta
    {
        public Suit seme { set; get; }
        public Valore valore { set; get; }

        public Carta(Suit seme, Valore valore)
        {
            this.seme = seme;
            this.valore = valore;
        }

        public int CalcolaValoreCarta()
        {
            int valueInt = 0;
            switch (valore)
            {
                case Valore.Due: valueInt = 2;
                    break;
                case Valore.Tre: valueInt = 3;
                    break;
                case Valore.Quattro: valueInt = 4;
                    break;
                case Valore.Cinque: valueInt = 5;
                    break;
                case Valore.Sei: valueInt = 6;
                    break;
                case Valore.Sette: valueInt = 7;
                    break;
                case Valore.Otto: valueInt = 8;
                    break;
                case Valore.Nove: valueInt = 9;
                    break;
                case Valore.Jack: valueInt = 10;
                    break;
                case Valore.Regina: valueInt = 10;
                    break;
                case Valore.Re: valueInt = 10;
                    break;
                case Valore.Asso: valueInt = 11;
                    break;
            }
            return valueInt;
        }

        public override string ToString()
        {
            return "" + valore + seme;
        }
    }
}
        