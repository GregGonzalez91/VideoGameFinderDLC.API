using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Models
{
    public class GameDetail
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public int ReleaseDate { get; set; }
        public int PlayerCount { get; set; }
        public string GameSystemName { get; set; }
        public string GenreType { get; set; }
    }
}
