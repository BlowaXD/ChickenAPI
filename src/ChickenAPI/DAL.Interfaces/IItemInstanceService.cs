using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IItemInstanceService : ISynchronizedRepository<ItemInstanceDto>
    {
        IEnumerable<ItemInstanceDto> GetWearByCharacterId(long characterId);
    }
}