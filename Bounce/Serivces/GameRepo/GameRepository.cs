using Bounce.DbContexts;
using Bounce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces.GameRepo
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddGame(Game game)
        {
            _context.Entry(game.PlayerA).State = EntityState.Unchanged;
            _context.Entry(game.PlayerB).State = EntityState.Unchanged;
            _context.Games.Add(game);
            _context.SaveChanges();
        }
    }
}
