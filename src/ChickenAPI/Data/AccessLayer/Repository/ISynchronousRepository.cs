using System.Collections.Generic;

namespace ChickenAPI.Data.AccessLayer.Repository
{
    public interface ISynchronousRepository<TObject, in TObjectId> where TObject : class
    {
        TObject GetById(TObjectId id);

        void Insert(TObject obj);
        void Insert(IEnumerable<TObject> objs);


        void Update(TObject obj);
        void Update(IEnumerable<TObject> objs);


        void Delete(TObject obj);
        void Delete(IEnumerable<TObject> objs);

        void DeleteById(TObjectId id);
        void DeleteByIds(IEnumerable<TObjectId> ids);
    }
}