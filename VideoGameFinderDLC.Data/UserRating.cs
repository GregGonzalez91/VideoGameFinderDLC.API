using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Data
{
   public class UserRating
    {
        [Key]
        public int UserId { get; set; }
        public string GameTitle { get; set; }

        // [ForeignKey]
        public int GameId { get; set; }
        public bool IsRecommended { get; set; }
    }
}
