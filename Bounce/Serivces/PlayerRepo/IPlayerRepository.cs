using Bounce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces.PlayerRepo
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers();
        void AddPlayer(Player player);
    }
}
