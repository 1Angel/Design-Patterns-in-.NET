using Unit_Of_Work_in_Repository_Pattern.Repositories;

namespace Unit_Of_Work_in_Repository_Pattern.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository UserRepository { get; }
        Task Save();
    }
}
