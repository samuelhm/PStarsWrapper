using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStarsWrapper.Entidades
{
    internal class TournamentPlayer : Player
    {
        public long Chips;

        public TournamentPlayer(string name) : base(name) { }

        public TournamentPlayer(string name, Posiciones pos) : base(name, pos) { }

        public TournamentPlayer(string name, Posiciones pos, long chips) : base(name, pos)
        {
            Chips = chips;
        }
    }
}
