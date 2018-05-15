using System;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface ISynchronizedSynchronousRepository<T> : ISynchronousRepository<T, Guid>, IAsyncRepository<T, Guid> where T : class
    {
    }
}