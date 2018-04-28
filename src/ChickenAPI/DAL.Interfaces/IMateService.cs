using System.Collections.Generic;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IMateService
    {
        IList<MateDto> GetMatesByCharacterId(ulong characterId);
    }
}