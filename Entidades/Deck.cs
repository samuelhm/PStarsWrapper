using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace PStarsWrapper.Entidades
{
    class Deck
    {
        public Card[] Cartas { get; } // Dejamos como Solo lectura el diccionario.
        public List<Card> CardRemainingList = new List<Card>();
        public Deck()
        {
            Cartas = GenerarCartas();
            CardRemainingList.AddRange(Cartas);
        }

        private Card[] GenerarCartas()
        {
            //Recorre Todos los palos incluidos en el enum con ***foreach (Palos palo in Enum.GetValues(typeof(Palos))) {}****
            //Segun parece hacer un cast (Suit[]) hace que vaya mas rapido.

            Card[] buffer = new Card[52];
            int contador = 0;
            foreach (Suits palo in (Suits[])Enum.GetValues(typeof(Suits))) 
            {
                foreach (Rank valor in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    buffer[contador++] = new Card(valor, palo);
                }

            }
            return buffer;
        }
    }
}
