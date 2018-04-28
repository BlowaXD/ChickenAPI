using System.Collections.Generic;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ICharacterService
    {
        void Insert(CharacterDto dto);
        void Update(CharacterDto dto);
        IEnumerable<CharacterDto> GetActiveByAccountId(ulong accountId);
    }
}