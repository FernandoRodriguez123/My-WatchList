using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyWatchList.Data;

namespace MyWatchList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new MyWatchListContextFactory())
            {
                context.CreateDbContext([]).Database.Migrate();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SeeFilmForm());
        }
    }
}