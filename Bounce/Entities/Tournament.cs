using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Entities
{
    public class Tournament
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Player> Entrants { get; set; }
        public List<Game> Games { get; set; }
    }
}
