using backEndConnect.entity;
using Microsoft.EntityFrameworkCore;

namespace backEndConnect.context
{
    internal class DbConnect : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;" +
                "database=northwind" +
                "Trusted_connection=true;" +
                "TrustServerCertificate=True; ");

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
