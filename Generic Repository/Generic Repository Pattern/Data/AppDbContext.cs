using Generic_Repository_Pattern.Models;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository_Pattern.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
            
        }

        public DbSet<Model1> model1 { get; set; }
    }
}
