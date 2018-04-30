using System.Collections;
using System.Collections.Generic;

namespace ChickenAPI.DAL.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        void InsertOrUpdate(T obj);
        void InsertOrUpdate(IEnumerable<T> objs);

        void Delete(T obj);
        void Delete(IEnumerable<T> objs);
    }
}