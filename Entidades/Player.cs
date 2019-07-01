using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStarsWrapper.Entidades
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Posiciones posicion { get; set; }
        public Player (string name)
        {
            Name = name;
        }
        public Player (string name, Posiciones pos)
        {
            Name = name;
            posicion = pos;
        }
        public bool Isdealer()
        {
            if (posicion == Posiciones.Delaer) return true;
            else return false;
        }
    }
}
