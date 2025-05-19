using Microsoft.EntityFrameworkCore;
using MyWatchList.Models;

namespace MyWatchList.Data
{
    public class MyWatchListContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<UserSerieConfig> UserSerieConfigs { get; set; }
        public DbSet<SerieGenre> SerieGenres { get; set; }
        public MyWatchListContext(DbContextOptions<MyWatchListContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Clave compuesta para tabla de unión SerieGenre
            modelBuilder.Entity<SerieGenre>()
                .HasKey(sg => new { sg.SerieId, sg.GenreId });

            //Relaciones entre Serie y SerieGenre
            modelBuilder.Entity<SerieGenre>()
                .HasOne(sg => sg.Serie)
                .WithMany(s => s.SerieGenres)
                .HasForeignKey(sg => sg.SerieId);

            modelBuilder.Entity<SerieGenre>()
                .HasOne(sg => sg.Genre)
                .WithMany(g => g.SerieGenres)
                .HasForeignKey(sg => sg.GenreId);

            //Relaciones entre User y UserSerieConfig
            modelBuilder.Entity<UserSerieConfig>()
                .HasOne(usc => usc.User)
                .WithMany(u => u.SeriesConfigs)
                .HasForeignKey(usc => usc.UserId);

            //Relaciones entre Serie y UserSerieConfig
            modelBuilder.Entity<UserSerieConfig>()
                .HasOne(usc => usc.Serie)
                .WithMany(s => s.UserConfigs)
                .HasForeignKey(usc => usc.SerieId);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Acción" },
                new Genre { Id = 2, Name = "Aventura" },
                new Genre { Id = 3, Name = "Anime" },
                new Genre { Id = 4, Name = "Ciencia Ficción" },
                new Genre { Id = 5, Name = "Comedia" },
                new Genre { Id = 6, Name = "Crimen" },
                new Genre { Id = 7, Name = "Drama" },
                new Genre { Id = 8, Name = "Documental" },
                new Genre { Id = 9, Name = "Fantasía" },
                new Genre { Id = 10, Name = "Historia" },
                new Genre { Id = 11, Name = "Misterio" },
                new Genre { Id = 12, Name = "Musical" },
                new Genre { Id = 13, Name = "Romance" },
                new Genre { Id = 14, Name = "Suspenso" },
                new Genre { Id = 15, Name = "Terror" },
                new Genre { Id = 16, Name = "Guerra" },
                new Genre { Id = 17, Name = "Western" },
                new Genre { Id = 18, Name = "Superhéroes" },
                new Genre { Id = 19, Name = "Noir" },
                new Genre { Id = 20, Name = "Slice of Life" }
                );
        }
    }
}
