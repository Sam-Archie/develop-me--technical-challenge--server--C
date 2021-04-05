using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Enitities
{
    public class Game
    {
        [ForeignKey("RoundId")]
        public int RoundId { get; set; }
        [Required]
        [ForeignKey("PlayerId")]
        public int PlayerAId { get; set; }
        public Player PlayerA { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerBId { get; set; }
        public Player PlayerB { get; set; }
    }
}
