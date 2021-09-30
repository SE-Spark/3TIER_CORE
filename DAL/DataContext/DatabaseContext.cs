using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace DAL.DataContext
{
    public class DatabaseContext:DbContext
    {
        
        public class OptionBuild
        {
            public OptionBuild()
            {
                settings = new AppConfiguration();
                optsBuilder.UseSqlServer(settings.connstring);
                opts = optsBuilder.Options;
            }
            
            public DbContextOptionsBuilder<DatabaseContext> optsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> opts { get; set; }
            private AppConfiguration settings { get; set; }
        }
        public static OptionBuild ops = new OptionBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
