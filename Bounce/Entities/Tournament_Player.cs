using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Enitities
{
    public class Tournament_Player
    {
        public Guid TournamentPlayerId { get; set; }
        [ForeignKey("TournamentId")]
        public Guid TournamentId { get; set; }
        [ForeignKey("PlayerId")]
        public Guid PlayerId { get; set; }
    }
}
