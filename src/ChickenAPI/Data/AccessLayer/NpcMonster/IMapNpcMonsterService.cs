using System.Collections.Generic;
using System.Threading.Tasks;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects.Map;

namespace ChickenAPI.Data.AccessLayer.NpcMonster
{
    public interface IMapNpcMonsterService : IMappedRepository<MapNpcMonsterDto>
    {
        Task<IEnumerable<MapNpcMonsterDto>> GetByMapIdAsync(long mapId);
    }
}