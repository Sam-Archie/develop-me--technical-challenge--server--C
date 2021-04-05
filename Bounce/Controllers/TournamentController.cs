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
    [Route("api/tournament")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentRepository _tournanentRepository;

        public TournamentController(ITournamentRepository tournamentRepository)
        {
            _tournanentRepository = tournamentRepository;
        }
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return "x";
        //}

        // GET api/<TournamentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TournamentController>
        [HttpPost]
        public void Post(Tournament tournament)
        {
            _tournanentRepository.CreateTournament(tournament);
        }

        // PUT api/<TournamentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TournamentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
