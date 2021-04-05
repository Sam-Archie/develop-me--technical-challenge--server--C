using Bounce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces.TournamentRepo
{
    public interface ITournamentRepository
    {
        void CreateTournament(Tournament tournament);
    }
}
