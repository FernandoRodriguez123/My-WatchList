using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWatchList.Models
{
    public class UserSerieConfig
    {
        public int Id { get; set; }

        public int EpisodesWatched { get; set; }
        public SerieStatus Status { get; set; }
        public int Score { get; set; }
        public bool Liked { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int SerieId { get; set; }
        public Serie Serie { get; set; }
    }

}
