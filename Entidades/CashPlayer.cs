using System;

namespace PStarsWrapper.Entidades
{
    internal class CashPlayer : Player
    {
        public Double Cash;

        public CashPlayer(string name) : base(name) {}

        public CashPlayer(string name, Posiciones pos) : base(name, pos) {}

        public CashPlayer(string name, Posiciones pos, Double cash) : base(name, pos)
        {
            Cash = cash;
        }
    }
}