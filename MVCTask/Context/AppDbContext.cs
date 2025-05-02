using Microsoft.EntityFrameworkCore;
using MVCTask.Models;

namespace MVCTask.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<HealthCareSolution> HealthCareSolutions { get; set; }
       public AppDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
