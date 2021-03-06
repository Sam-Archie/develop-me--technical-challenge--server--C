using Bounce.DbContexts;
using Bounce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Serivces.PlayerRepo
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _context;

        public PlayerRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public void AddPlayer(Player player)
        {
            _context.Entry(player).State = EntityState.Unchanged;
            _context.Players.Add(player);
            _context.SaveChanges();
        }
    }
}
