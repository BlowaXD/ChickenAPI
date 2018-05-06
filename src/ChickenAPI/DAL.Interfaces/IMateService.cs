using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IMateService : ISynchronizedRepository<MateDto>
    {
        /// <summary>
        /// Will get all <see cref="MateDto"/> owned by the <see cref="CharacterDto"/> with the given id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        IList<MateDto> GetMatesByCharacterId(long characterId);
    }
}