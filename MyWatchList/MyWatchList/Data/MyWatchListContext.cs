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
        }
    }
}
