using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
    public class UserRatingListItem
    {
        public bool IsRecommended { get; set; }
        public int UserGameRating { get; set; }
        public string GameTitle { get; set; }
        public int UserRatingId { get; set; }
    }
}
