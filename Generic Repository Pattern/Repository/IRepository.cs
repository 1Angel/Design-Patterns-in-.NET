namespace Generic_Repository_Pattern.Repository
{
    public interface IRepository<T> where T : class
    {

        List<T> Get();
        T GetById(int id);
        T Save(T Data);


    }
}
