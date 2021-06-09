using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
   public class UserRatingDetail
    {
        public Guid UserId { get; set; }
        public bool IsRecommended  { get; set; }

        public int UserGameRating { get; set; }
        public int GameId { get; set; }

    }
}
