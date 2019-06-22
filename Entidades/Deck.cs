using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace PStarsWrapper.Entidades
{
    class Deck
    {
        public Card[] Cartas { get; } // Dejamos como Solo lectura el diccionario.
        public Deck()
        {
            Cartas = GenerarCartas();
        }


        //Creamos El Tkey Para el diccionario ( por ejemeplo, dos de corazones seria 2C, extrayendo el valor y el palo)
        private static string AsignarValor(Rank valor)
        {
            switch (valor)
            {

                case Rank.Ace: return "A";
                case Rank.Two: return "2"; 
                case Rank.Three: return "3";
                case Rank.Four: return "4";
                case Rank.Five: return "5";
                case Rank.Six: return "6";
                case Rank.Seven: return "7";
                case Rank.Eight: return "8"; 
                case Rank.Nine: return "9"; 
                case Rank.Ten: return "T";
                case Rank.Jack: return "J";
                case Rank.Queen: return "Q"; 
                case Rank.King: return "K"; 
                default: throw new FormatException();
            }
        }   
        private static string AsignarPalo(Suits palo)
        {
            string palobuffer;
            switch (palo)
            {
                case Suits.Hearts: palobuffer = "H"; break;
                case Suits.Spades: palobuffer = "S"; break;
                case Suits.Diamonds: palobuffer = "D"; break;
                case Suits.Clubs: palobuffer = "C"; break;
                default: throw new FormatException();
            }

            return palobuffer;
        }
        private static string AsignarTkey(Suits palo, Rank valor)   
        {

            string valorbuffer = AsignarValor(valor); // Al no poder Extraer el numero del valor ( as.value = 1), Asignamos en un metodo.
            string palobuffer = AsignarPalo(palo);    // Del Palo necesitamos la primera letra, se podria cambiar por las siglas en ingles (H,D,S,C)

            return valorbuffer + palobuffer;
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
                    buffer[contador] = new Card(valor, palo);
                }

            }
            return buffer;
        }
    }
}
