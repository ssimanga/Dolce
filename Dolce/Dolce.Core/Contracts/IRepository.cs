using System.Linq;

namespace Dolce.DataAccess.InMemory
{
    public interface IRepository<T>
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}