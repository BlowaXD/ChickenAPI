using System.Collections.Generic;

namespace ChickenAPI.DAL.Interfaces.Repository
{
    public interface IMappedRepository<T> : IRepository<T> where T : class, IMappedDto
    {
        T GetById(ulong id);
        IEnumerable<T> GetByIds(IEnumerable<ulong> ids);


        void DeleteById(ulong id);
        void DeleteByIds(IEnumerable<ulong> ids);
    }
}