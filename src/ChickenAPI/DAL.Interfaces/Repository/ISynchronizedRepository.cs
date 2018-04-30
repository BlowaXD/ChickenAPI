using System;
using System.Collections;
using System.Collections.Generic;

namespace ChickenAPI.DAL.Interfaces.Repository
{
    public interface ISynchronizedRepository<T> : IRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetByIds(IEnumerable<Guid> ids);

        void DeleteById(Guid id);
        void DeleteByIds(IEnumerable<Guid> ids);
    }
}