using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IItemInstanceService : ISynchronizedRepository<ItemInstanceDto>
    {
        /// <summary>
        /// Will return all the weared gear in the <see cref="CharacterDto"/> inventory by its id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        IEnumerable<ItemInstanceDto> GetWearByCharacterId(long characterId);
    }
}