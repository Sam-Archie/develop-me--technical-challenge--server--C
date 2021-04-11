using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bounce.Entities
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
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
