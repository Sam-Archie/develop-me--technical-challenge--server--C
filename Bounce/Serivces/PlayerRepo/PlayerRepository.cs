using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces
{
    public class PlayerRepository
    {
        public PlayerRepository()
        {

        }
        public void AddPlayer(Player newPlayer)
        {
            _tournamentContext.Players.Add(newPlayer);

            _tournamentContext.SaveChanges();
        }
    }
}
