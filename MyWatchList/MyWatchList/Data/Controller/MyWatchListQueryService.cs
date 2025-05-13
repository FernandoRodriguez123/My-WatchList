using Microsoft.EntityFrameworkCore;
using MyWatchList.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWatchList.Data.Controller
{
    public class MyWatchListQueryService (MyWatchListContext context)
    {
        private readonly MyWatchListContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<List<Serie>> GetAllSeriesAsync()
        {
            return await _context.Series
                .Include(x => x.SerieGenres)
                .ThenInclude(x => x.Genre)
                .ToListAsync();
        }

        public async Task<UserSerieConfig?> GetUserSerieConfigAsync(int userId,
            int serieId)
        {
            var config = await _context.UserSerieConfigs
                .Include(x => x.User)
                .Include(x => x.Serie)
                .FirstOrDefaultAsync(x => x.UserId == userId && x.SerieId == serieId);

            return config;
        }

        public async Task<List<Genre>> GetGenresAsync()
        {
            return await _context.Genres
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task SetUserSerieConfig(int userId,
            int serieId,
            int episodesWatched,
            SerieStatus status,
            int score,
            bool liked)
        {
            var config = await GetUserSerieConfigAsync(userId, serieId);

            if (config == null)
            {
                config = new UserSerieConfig
                {
                    UserId = userId,
                    SerieId = serieId,
                    EpisodesWatched = 0,
                    Status = SerieStatus.Inactive,
                    Score = 0,
                    Liked = false
                };

                _context.UserSerieConfigs.Add(config);
            }
            else
            {
                config.EpisodesWatched = episodesWatched;
                config.Status = status;
                config.Score = score;
                config.Liked = liked;

                _context.UserSerieConfigs.Update(config);
            }

            await _context.SaveChangesAsync();
        }
    }
}
