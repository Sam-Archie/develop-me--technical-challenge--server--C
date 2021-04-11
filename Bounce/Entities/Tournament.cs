using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Entities
{
    public class Tournament
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Player> Entrants { get; set; }
        public int WinningScore { get; set; }
    }
}
