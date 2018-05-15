using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface IAsyncRepository<TObject, in TObjectId> where TObject : class
    {
        /// <summary>
        /// Will return object by its id in data storage
        /// will return default null if not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TObject> GetByIdAsync(TObjectId id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TObject>> GetByIdsAsync(IEnumerable<TObjectId> ids);

        /// <summary>
        /// Asynchronously insert object parameter into data storage
        /// Parameter's id will be set in this method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task InsertAsync(TObject obj);


        /// <summary>
        /// Asynchronously insert objects given in parameter into data storage
        /// Parameter's id will be set in this method
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        Task InsertAsync(IEnumerable<TObject> objs);

        Task UpdateAsync(TObject obj);
        Task UpdateAsync(IEnumerable<TObject> objs);

        Task DeleteAsync(TObject obj);
        Task DeleteAsync(IEnumerable<TObject> objs);

        Task DeleteByIdAsync(TObjectId id);
        Task DeleteByIdsAsync(IEnumerable<TObjectId> ids);
    }
}