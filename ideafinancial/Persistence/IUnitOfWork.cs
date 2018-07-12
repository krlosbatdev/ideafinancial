namespace ideafinancial.Persistence
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        void Complete();
    }
}
