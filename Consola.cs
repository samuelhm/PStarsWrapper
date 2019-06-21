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

            foreach (KeyValuePair<string,Card> c in MiBaraja.Cartas)
            {
                Console.WriteLine(c.Key.ToString()+" - "+  c.Value.ToString());
            }
            Console.ReadLine();

        }
    }
}
