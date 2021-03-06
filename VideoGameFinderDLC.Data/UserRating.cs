using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Data
{
   public class UserRating
    {
        
        public Guid OwnerId { get; set; }
        [Key]
        public int UserRatingId { get; set; }
        public int UserGameRating { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
        public bool IsRecommended { get; set; }
    }
}
