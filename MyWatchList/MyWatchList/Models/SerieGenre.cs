using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWatchList.Models
{
    public class SerieGenre
    {
        public int SerieId { get; set; }
        public Serie Serie { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
