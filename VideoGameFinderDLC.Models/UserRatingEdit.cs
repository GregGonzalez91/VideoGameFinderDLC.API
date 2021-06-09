using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
   public class UserRatingEdit
    {
        public bool IsRecommended { get; set; }
        public int UserGameRating { get; set; }
        public int GameId { get; set; }
        public int UserRatingId { get; set; }
    }
}
