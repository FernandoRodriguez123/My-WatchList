using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyWatchList.Data;
using MyWatchList.Data.Controller;

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
            var factory = new MyWatchListContextFactory();
            using var context = factory.CreateDbContext([]);

            context.Database.Migrate();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var servicio = new MyWatchListQueryService(context);
            Application.Run(new SignInForm(servicio));
        }
    }
}