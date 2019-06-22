using System;
using System.Collections.Generic;
using System.Text;
using PStarsWrapper.Entidades;

namespace PStarsWrapper
{
    static class Consola
    {

        public static void Main()
        {
            Deck MiBaraja = new Deck();

            foreach (Card c in MiBaraja.CardRemainingList)
            {
                Console.WriteLine(c.ToString()+" Abb Name = " + c.Name);
            }
            Console.ReadLine();

        }
    }
}
