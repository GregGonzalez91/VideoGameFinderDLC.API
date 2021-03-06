using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameFinderDLC.Data
{
    public class GameSystem
    {
        [Key]
        public int GameSystemId { get; set; }
        [Required]
        public string GameSystemName { get; set; }
        [Required]
        public string GameForSystem { get; set; }
        public decimal GameSystemPrice { get; set; }
    }
}
