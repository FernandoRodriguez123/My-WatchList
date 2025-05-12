using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWatchList.Data
{
    public class MyWatchListContextFactory : IDesignTimeDbContextFactory<MyWatchListContext>, IDisposable
    {
        public MyWatchListContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyWatchListContext>();
            optionsBuilder.UseSqlite("Data Source=blog.db");

            return new MyWatchListContext(optionsBuilder.Options);
        }

        public void Dispose()
        {
            
        }
    }
}
