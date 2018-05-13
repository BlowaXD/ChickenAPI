using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        void InsertOrUpdate(T obj);
        Task InsertOrUpdateAsync(T obj);
        void InsertOrUpdate(IEnumerable<T> objs);
        Task InsertOrUpdateAsync(IEnumerable<T> objs);

        void Delete(T obj);
        void Delete(IEnumerable<T> objs);
    }
}