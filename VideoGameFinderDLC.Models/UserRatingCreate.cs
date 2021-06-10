using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
    public class UserRatingCreate
    {
        [Required]
        public int UserGameRating { get; set; }

        public int GameId { get; set; }

        public bool IsRecommended { get; set; }
    }
}
