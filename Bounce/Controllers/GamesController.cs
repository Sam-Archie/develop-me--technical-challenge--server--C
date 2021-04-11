using Bounce.DbContexts;
using Bounce.Entities;
using Bounce.Serivces.GameRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpPost()]
        public void CreateGames(IList<Game> games)
        {
            foreach(Game game in games)
            {
                _gameRepository.AddGame(game);
            }
        }
    }
}
