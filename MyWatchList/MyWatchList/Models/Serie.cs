using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWatchList.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalEpisodes { get; set; }
        public string ImagePath { get; set; }
        public string Synopsis { get; set; }

        public ICollection<UserSerieConfig> UserConfigurations { get; set; }
        public ICollection<SerieGenre> SerieGenres { get; set; }
    }

}
