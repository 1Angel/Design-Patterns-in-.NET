
using Generic_Repository_Pattern.Data;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository_Pattern.Repository.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AppDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }
        public List<T> Get()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Save(T Data)
        {
            var create = _dbSet.Add(Data);
            _context.SaveChanges();
            return create.Entity;
        }
    }
}
