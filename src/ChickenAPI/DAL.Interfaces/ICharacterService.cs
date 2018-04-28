using System.Collections.Generic;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ICharacterService
    {
        IEnumerable<CharacterDto> GetActiveByAccountId(ulong accountId);
    }
}