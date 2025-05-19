using Microsoft.EntityFrameworkCore;
using MyWatchList.Models;

namespace MyWatchList.Data.Controller
{
    public class MyWatchListQueryService(MyWatchListContext context)
    {
        private readonly MyWatchListContext _context = context ?? throw new ArgumentNullException();

        // Obtener un usuario por su nombre
        public User? GetUserByName(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);
        }

        // Comprobar contraseña
        public bool VerifyUserPassword(int userId, string password)
        {
            var user = _context.Users.Find(userId);
            return user != null && user.Password.Equals(password, StringComparison.CurrentCultureIgnoreCase);
        }

        // Obtener todas las series
        public List<Serie> GetAllSeries()
        {
            return [.. _context.Series];
        }

        // Obtener config por user y serie
        public UserSerieConfig? GetUserSerieConfig(int userId, int serieId)
        {
            return _context.UserSerieConfigs
                .FirstOrDefault(usc =>
                    usc.UserId == userId &&
                    usc.SerieId == serieId);
        }

        // Borrar serie y sus configs
        public void DeleteSerie(int serieId)
        {
            var serie = _context.Series
                .Include(s => s.UserConfigs)
                .FirstOrDefault(s => s.Id == serieId);

            if (serie != null)
            {
                _context.UserSerieConfigs.RemoveRange(serie.UserConfigs);

                var serieGenres = _context.SerieGenres.Where(sg => sg.SerieId == serieId).ToList();
                _context.SerieGenres.RemoveRange(serieGenres);

                _context.Series.Remove(serie);
                _context.SaveChanges();
            }
        }

        // Añadir nueva serie y configs a los user
        public void AddSerie(string title, int totalEpisodes, string imagePath, string synopsis)
        {
            var newSerie = new Serie
            {
                Title = title,
                TotalEpisodes = totalEpisodes,
                ImagePath = imagePath,
                Synopsis = synopsis
            };

            _context.Series.Add(newSerie);
            _context.SaveChanges();

            var allUsers = _context.Users.ToList();
            foreach (var user in allUsers)
            {
                var config = new UserSerieConfig
                {
                    UserId = user.Id,
                    SerieId = newSerie.Id,
                    EpisodesWatched = 0,
                    Status = SerieStatus.Inactive,
                    Score = 0,
                    Liked = false
                };
                _context.UserSerieConfigs.Add(config);
            }

            _context.SaveChanges();
        }

        // Validacion episodios existentes/vistos
        public void NormalizeWatchedEpisodes(int serieId)
        {
            var serie = _context.Series.Find(serieId);
            if (serie == null) return;

            var configs = _context.UserSerieConfigs.Where(usc => usc.SerieId == serieId).ToList();

            foreach (var config in configs)
            {
                if (config.EpisodesWatched > serie.TotalEpisodes)
                {
                    config.EpisodesWatched = serie.TotalEpisodes;
                }
            }

            _context.SaveChanges();
        }

        // Update serie
        public void UpdateSerie(int serieId, string title, int totalEpisodes, string imagePath, string synopsis)
        {
            var serie = _context.Series.Find(serieId);
            if (serie == null) return;

            serie.Title = title;
            serie.TotalEpisodes = totalEpisodes;
            serie.ImagePath = imagePath;
            serie.Synopsis = synopsis;

            _context.SaveChanges();
        }

        // Obtener generos
        public List<Genre> GetAllGenres()
        {
            return [.. _context.Genres];
        }

        // Obtener generos de una serie
        public List<Genre> GetGenresForSerie(int serieId)
        {
            return [.. _context.SerieGenres
                .Where(sg => sg.SerieId == serieId)
                .Select(sg => sg.Genre)];
        }

        // Aañdir usuario y sus configs
        public User AddUser(string name, string password)
        {
            var newUser = new User
            {
                Name = name,
                Password = password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            var allSeries = _context.Series.ToList();
            foreach (var serie in allSeries)
            {
                var config = new UserSerieConfig
                {
                    UserId = newUser.Id,
                    SerieId = serie.Id,
                    EpisodesWatched = 0,
                    Status = SerieStatus.Inactive,
                    Score = 0,
                    Liked = false
                };
                _context.UserSerieConfigs.Add(config);
            }

            _context.SaveChanges();

            return newUser;
        }

        // Relacionar serie con un género
        public void AddSerieGenre(int serieId, int genreId)
        {
            var exists = _context.SerieGenres.Any(sg => sg.SerieId == serieId && sg.GenreId == genreId);
            if (!exists)
            {
                _context.SerieGenres.Add(new SerieGenre { SerieId = serieId, GenreId = genreId });
                _context.SaveChanges();
            }
        }

        // Eliminar relación serie-género
        public void RemoveSerieGenre(int serieId, int genreId)
        {
            var relation = _context.SerieGenres.FirstOrDefault(sg => sg.SerieId == serieId && sg.GenreId == genreId);
            if (relation != null)
            {
                _context.SerieGenres.Remove(relation);
                _context.SaveChanges();
            }
        }

        public List<Serie> FilterSeries(int userId, List<string> generos, List<SerieStatus> statusList, OrderStatus order, string titulo)
        {
            var series = _context.Series
                .Include(s => s.SerieGenres)
                    .ThenInclude(sg => sg.Genre)
                .Include(s => s.UserConfigs)
                .ToList();

            var filtered = series
                .Where(s => s.Title.Contains(titulo, StringComparison.OrdinalIgnoreCase))
                .Where(s => generos.Count == 0 ||
                    generos.All(g => s.SerieGenres.Any(sg => sg.Genre.Name.Equals(g, StringComparison.OrdinalIgnoreCase))))
                .Where(s => statusList.Count == 0 ||
                    s.UserConfigs.Any(uc => uc.UserId == userId && statusList.Contains(uc.Status)))
                .ToList();

            filtered = order switch
            {
                OrderStatus.TitleAsc => filtered.OrderBy(s => s.Title).ToList(),
                OrderStatus.TitleDesc => filtered.OrderByDescending(s => s.Title).ToList(),
                OrderStatus.EpisodesAsc => filtered.OrderBy(s => s.TotalEpisodes).ToList(),
                OrderStatus.EpisodesDesc => filtered.OrderByDescending(s => s.TotalEpisodes).ToList(),
                _ => filtered
            };

            return filtered;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
