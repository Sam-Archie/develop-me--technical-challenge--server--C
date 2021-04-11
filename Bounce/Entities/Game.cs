using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        [ForeignKey("TournamentId")]
        public Guid TournamentId { get; set; }
        public Player PlayerA { get; set; }
        public Player PlayerB { get; set; }
        public int RoundNumber { get; set; }
        public int PlayerAScore { get; set; }
        public int PlayerBScore { get; set; }
    }
}
