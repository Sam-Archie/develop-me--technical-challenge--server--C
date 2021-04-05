using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Enitities
{
    public class Round
    {
        public Guid RoundId { get; set; }
        public int RoundNumber { get; set; }
        [ForeignKey("TournamentId")]
        public Guid TournamentId { get; set; }
        public List<Game> Game { get; set; }
    }
}
