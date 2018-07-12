using ideafinancial.Models;
using Microsoft.EntityFrameworkCore;

namespace ideafinancial.Persistence
{
    public interface IIdeafinancialDbContext
    {
        DbSet<User> Users { get; set; }
        int SaveChanges();
    }
}