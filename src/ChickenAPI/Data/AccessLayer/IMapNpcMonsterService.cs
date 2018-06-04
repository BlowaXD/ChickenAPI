using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IMapNpcMonsterService : IMappedRepository<MapNpcMonsterDto>
    {
        IEnumerable<MapNpcMonsterDto> GetByMapId(long mapId);
    }
}