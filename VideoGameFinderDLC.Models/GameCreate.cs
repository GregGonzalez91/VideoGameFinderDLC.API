using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
    public class GameCreate
    {
        public string GameTitle { get; set; }
        public double GamePrice { get; set; }
        public string GameSystemName { get; set; }
        public string ESRBRating { get; set; }
        public bool IsReccommended { get; set; }
        public string GenreType { get; set; }
        public int ReleaseDate { get; set; }
        public int PlayerCount { get; set; }
        public int OwnerId { get; set; }
    }
}
