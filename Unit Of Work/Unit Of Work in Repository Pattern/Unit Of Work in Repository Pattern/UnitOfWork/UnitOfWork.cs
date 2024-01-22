using Unit_Of_Work_in_Repository_Pattern.Data;
using Unit_Of_Work_in_Repository_Pattern.Repositories;

namespace Unit_Of_Work_in_Repository_Pattern.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IUserRepository UserRepository { get; }

        public UnitOfWork(AppDbContext context, IUserRepository userRepository)
        {
            _context = context;
            UserRepository = userRepository;
        }
        public async Task Save()
        {
           await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
