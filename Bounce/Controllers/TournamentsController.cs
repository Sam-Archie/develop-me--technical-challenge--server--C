using Bounce.Entities;
using Bounce.Serivces.TournamentRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bounce.Controllers
{
    [ApiController]
    [Route("api/tournaments")]
    public class TournamentsController : ControllerBase
    {
        private readonly ITournamentRepository _tournanentRepository;

        public TournamentsController(ITournamentRepository tournamentRepository)
        {
            _tournanentRepository = tournamentRepository;
        }

        [HttpPost()]
        public void Post(Tournament tournament)
        {

            _tournanentRepository.AddTournament(tournament);
        }

    }
}
