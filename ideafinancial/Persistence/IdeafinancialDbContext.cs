using ideafinancial.Models;
using Microsoft.EntityFrameworkCore;

namespace ideafinancial.Persistence
{
    public class IdeafinancialDbContext : DbContext, IIdeafinancialDbContext
    {
        public IdeafinancialDbContext(DbContextOptions<IdeafinancialDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
