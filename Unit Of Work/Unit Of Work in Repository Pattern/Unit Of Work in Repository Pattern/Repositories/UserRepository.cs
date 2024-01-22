using Microsoft.EntityFrameworkCore;
using Unit_Of_Work_in_Repository_Pattern.Data;
using Unit_Of_Work_in_Repository_Pattern.Models;

namespace Unit_Of_Work_in_Repository_Pattern.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> Get()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetById(int id)
        {
            var userId = await _context.Users.FirstOrDefaultAsync(x=>x.Id == id);   
            return userId;
        }

        public async Task Save(User user)
        {
            var save = await _context.Users.AddAsync(user);

        }
    }
}
