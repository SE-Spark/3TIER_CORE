using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var optsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optsBuilder.UseSqlServer(appConfig.connstring);
            return new DatabaseContext(optsBuilder.Options);
        }
    }
}
