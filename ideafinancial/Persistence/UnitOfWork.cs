﻿namespace ideafinancial.Persistence
{


    public class UnitOfWork : IUnitOfWork
    {
        private readonly IIdeafinancialDbContext _dbContext;
        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(IIdeafinancialDbContext dbContext, IUserRepository userRepository)
        {
            _dbContext = dbContext;
            UserRepository = userRepository;
        }

        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}