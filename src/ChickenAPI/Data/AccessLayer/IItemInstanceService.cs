using System.Collections.Generic;
using System.Threading.Tasks;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IItemInstanceService : ISynchronizedRepository<ItemInstanceDto>
    {
        /// <summary>
        ///     Will return all the weared gear in the <see cref="CharacterDto" /> inventory by its id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        Task<IEnumerable<ItemInstanceDto>> GetWearByCharacterIdAsync(long characterId);
    }
}