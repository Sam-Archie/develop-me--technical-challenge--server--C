using Bounce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces.GameRepo
{
    public interface IGameRepository
    {
        void AddGame(Game game);
    }
}
