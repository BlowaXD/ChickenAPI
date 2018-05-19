using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface IAsyncRepository<TObject, in TObjectId> where TObject : class
    {
        /// <summary>
        ///     Will return object by its id in data storage
        ///     will return default null if not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TObject> GetByIdAsync(TObjectId id);

        /// <summary>
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TObject>> GetByIdsAsync(IEnumerable<TObjectId> ids);

        /// <summary>
        ///     Asynchronously insert object parameter into data storage
        ///     Parameter's id will be set in this method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<TObject> InsertAsync(TObject obj);


        /// <summary>
        ///     Asynchronously insert objects given in parameter into data storage
        ///     Parameter's id will be set in this method
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        Task InsertAsync(IEnumerable<TObject> objs);


        /// <summary>
        ///     Asynchronously update objects given in parameter into data storage
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<TObject> UpdateAsync(TObject obj);

        /// <summary>
        ///     Asynchronously update all objects given in parameter into data storage
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        Task UpdateAsync(IEnumerable<TObject> objs);

        /// <summary>
        ///     Delete all objects given in parameter from data storage
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task DeleteAsync(TObject obj);

        /// <summary>
        ///     Asynchronously delete all objects given in parameter from data storage
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        Task DeleteAsync(IEnumerable<TObject> objs);

        /// <summary>
        ///     Asynchronously delete the object from the data storage with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteByIdAsync(TObjectId id);

        /// <summary>
        ///     Asynchronously delete all the objects from the data storage with the given id
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task DeleteByIdsAsync(IEnumerable<TObjectId> ids);
    }
}