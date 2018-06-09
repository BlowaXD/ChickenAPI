using System.Collections.Generic;
using System.Threading.Tasks;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Character;

namespace ChickenAPI.Data.AccessLayer
{
    public interface ICharacterMateService : IMappedRepository<CharacterMateDto>
    {
        /// <summary>
        ///     Will get all <see cref="CharacterMateDto" /> owned by the <see cref="CharacterDto" /> with the given id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        IList<CharacterMateDto> GetMatesByCharacterId(long characterId);

        /// <summary>
        ///     Will get all <see cref="CharacterMateDto" /> owned by the <see cref="CharacterDto" /> with the given id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        Task<IList<CharacterMateDto>> GetMatesByCharacterIdAsync(long characterId);
    }
}