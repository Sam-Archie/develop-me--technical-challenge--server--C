using Bounce.DbContexts;
using Bounce.Entities;
using Bounce.Serivces.PlayerRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bounce.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _context;

        public PlayersController(IPlayerRepository context)
        {
            _context = context;
        }

        [HttpPost]

        public void CreatePlayer(string name, Guid id)
        {
            var player = new Player()
            {
                Id = id,
                Name = name,
            };
            _context.AddPlayer(player);
        }

        [HttpGet]

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.GetPlayers();
        }
    }
}
