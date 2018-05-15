namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface IMappedSynchronousRepository<T> : ISynchronousRepository<T, long>, IAsyncRepository<T, long> where T : class, IMappedDto
    {
    }
}