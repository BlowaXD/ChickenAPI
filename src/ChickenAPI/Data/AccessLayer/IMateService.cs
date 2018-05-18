using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IMateService : IMappedRepository<MateDto>
    {
        /// <summary>
        ///     Will get all <see cref="MateDto" /> owned by the <see cref="CharacterDto" /> with the given id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        IList<MateDto> GetMatesByCharacterId(long characterId);
    }
}