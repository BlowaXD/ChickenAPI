using System;
using System.Collections.Generic;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface ISynchronizedRepository<T> : IRepository<T, Guid>, IAsyncRepository<T, Guid> where T : class
    {
    }
}