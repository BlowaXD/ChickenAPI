using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IDropService : IMappedRepository<DropDto>
    {
        IEnumerable<DropDto> GetByMapNpcMonsterId(long mapNpcMonsterId);
    }
}