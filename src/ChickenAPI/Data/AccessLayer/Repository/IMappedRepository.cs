using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface IMappedRepository<T> : IRepository<T, long>, IAsyncRepository<T, long> where T : class, IMappedDto
    {
    }
}