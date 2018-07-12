using ideafinancial.Models;

namespace ideafinancial.Persistence
{
    public interface IUserRepository
    {
        User GetUser(int id);
    }
}