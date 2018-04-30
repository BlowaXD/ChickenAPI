using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IMateService : ISynchronizedRepository<MateDto>
    {
        IList<MateDto> GetMatesByCharacterId(long characterId);
    }
}