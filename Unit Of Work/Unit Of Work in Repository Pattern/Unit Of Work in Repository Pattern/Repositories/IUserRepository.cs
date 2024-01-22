using Unit_Of_Work_in_Repository_Pattern.Models;

namespace Unit_Of_Work_in_Repository_Pattern.Repositories
{
    public interface IUserRepository
    {
        Task Save(User user);
        Task<List<User>> Get();
        Task<User> GetById(int id);
    }
}
