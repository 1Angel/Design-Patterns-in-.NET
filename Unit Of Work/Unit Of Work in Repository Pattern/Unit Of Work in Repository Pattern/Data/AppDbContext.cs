using Microsoft.EntityFrameworkCore;
using Unit_Of_Work_in_Repository_Pattern.Models;

namespace Unit_Of_Work_in_Repository_Pattern.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
