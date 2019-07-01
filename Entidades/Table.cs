using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStarsWrapper.Entidades
{
    abstract class Table
    {
        public TableTypes TableType { get; }
        public short NumPlayers {get;set;}
        public string Name { get;}
        public List<Player> Players;

        public Table(short numplayers, string name = "Nombre de Mesa no Asignado", TableTypes tabletype = TableTypes.Zoom, List<Player> listaJugadores = null)
        {
            // TODO: Para mesas Heads Up, el dealer y la SB son el mismo jugador, hay que manejar esto en el futuro de otra forma
            if (numplayers < 3) throw new NotImplementedException();
            NumPlayers = numplayers;
            Name = name;
            TableType = tabletype;
            Players = listaJugadores;
        }
    }
}
