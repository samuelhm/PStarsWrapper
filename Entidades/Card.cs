using System;

namespace PStarsWrapper.Entidades
{
    internal class Card
    {
        public Rank Valor { get; }
        public Suits Palo { get; }

        public Card(Rank v, Suits p)
        {
            Valor = v;
            Palo = p;
        }

        public override string ToString() //Sobreescribimos principalmente para pruebas de desarrollo
        {
            return Valor + " of " + Palo;
        }

        public string Name { get { return getAbrebName(this.Palo,this.Valor); } }

        private static char getValueChar(Rank valor)
        {
            switch (valor)
            {
                case Rank.Ace: return 'A';
                case Rank.Two: return '2';
                case Rank.Three: return '3';
                case Rank.Four: return '4';
                case Rank.Five: return '5';
                case Rank.Six: return '6';
                case Rank.Seven: return '7';
                case Rank.Eight: return '8';
                case Rank.Nine: return '9';
                case Rank.Ten: return 'T';
                case Rank.Jack: return 'J';
                case Rank.Queen: return 'Q';
                case Rank.King: return 'K';
                default: throw new FormatException();
            }
        }

        private static char getSuitChar(Suits palo)
        {
            switch (palo)
            {
                case Suits.Hearts: return 'H';
                case Suits.Spades: return 'S';
                case Suits.Diamonds: return 'D';
                case Suits.Clubs: return 'C';
                default: throw new FormatException();
            }
        }

        private static string getAbrebName(Suits palo, Rank valor)
        {
             // Al no poder Extraer el numero del valor ( as.value = 1), Asignamos en un metodo.
             // Del Palo necesitamos la primera letra, se podria cambiar por las siglas en ingles (H,D,S,C)

            return getValueChar(valor).ToString() + getSuitChar(palo).ToString();
        }
    }
}