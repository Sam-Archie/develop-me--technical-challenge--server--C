using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Enitities
{
    public class Tournament
    {
        [Key]
        public Guid TournamentId { get; set; }
        [Required]
        public string Name { get; set; }
    }

}
