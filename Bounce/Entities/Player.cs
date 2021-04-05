using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Enitities
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        [Required]
        public int Score { get; set; }
        public string Name { get; set; }
        public bool Winner { get; set; }
        public int Rating { get; set; }
        public int TotalGames { get; set; }
    }
    public enum PlayerRating
    {
        Novice,
        Beginner,
        intermediate,
        Advanced,
        Expert
    }
}
