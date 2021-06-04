using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public int ReleaseDate { get; set; }
        public int PlayerCount { get; set; }

        public Guid _userId { get; set; } //revist with Greg
        public Guid OwnerId { get; set; } //revist with Greg
        
        [ForeignKey(nameof(GameSystem))]
        public int GameSystemId { get; set; }
        public virtual GameSystem GameSystem { get; set; }
        
        [ForeignKey(nameof(GameGenre))]
        public int GameGenreId { get; set; }
        public virtual GameGenre GameGenre { get; set; }
        
        public string ESRBRating { get; set; }
        public bool IsReccommended { get; set; }
        public double GamePrice { get; set; }

        //public string GenreType { get; set; } 

        //public string GameSystemName { get; set; } 
    }
}
