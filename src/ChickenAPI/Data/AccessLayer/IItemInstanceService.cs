using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IItemInstanceService : ISynchronizedSynchronousRepository<ItemInstanceDto>
    {
        /// <summary>
        /// Will return all the weared gear in the <see cref="CharacterDto"/> inventory by its id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        IEnumerable<ItemInstanceDto> GetWearByCharacterId(long characterId);
    }
}