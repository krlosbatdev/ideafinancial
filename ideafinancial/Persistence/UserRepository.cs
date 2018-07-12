using ideafinancial.Models;
using System.Linq;

namespace ideafinancial.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly IIdeafinancialDbContext _dbContext;

        public UserRepository(IIdeafinancialDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
