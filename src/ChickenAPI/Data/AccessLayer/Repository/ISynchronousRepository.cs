using System.Collections.Generic;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface ISynchronousRepository<TObject, in TObjectId> where TObject : class
    {
        /// <summary>
        ///     Returns the object from data storage by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TObject GetById(TObjectId id);


        /// <summary>
        ///     Returns all the objects from data storage by their ids
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        IEnumerable<TObject> GetByIds(IEnumerable<TObjectId> ids);

        /// <summary>
        ///     Insert object given in parameter into data storage
        /// </summary>
        /// <param name="obj"></param>
        TObject Insert(TObject obj);

        /// <summary>
        ///     Insert all the objects given in parameter into data storage
        /// </summary>
        /// <param name="objs"></param>
        void Insert(IEnumerable<TObject> objs);

        /// <summary>
        ///     Updates the object given in parameter into data storage
        /// </summary>
        /// <param name="obj"></param>
        TObject Update(TObject obj);

        /// <summary>
        ///     Updates all the objects given in parameter into data storage
        /// </summary>
        /// <param name="objs"></param>
        void Update(IEnumerable<TObject> objs);


        /// <summary>
        ///     Delete all objects given in parameter from data storage
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        void Delete(TObject obj);

        /// <summary>
        ///     Asynchronously delete all objects given in parameter from data storage
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        void Delete(IEnumerable<TObject> objs);

        /// <summary>
        ///     Delete the object from the data storage with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteById(TObjectId id);

        /// <summary>
        ///     Delete all the objects from the data storage with the given id
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        void DeleteByIds(IEnumerable<TObjectId> ids);
    }
}