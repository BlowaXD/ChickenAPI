using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IBCardService : IMappedRepository<BCardDto>
    {
        IEnumerable<BCardDto> GetBySkillId(long skillId);

        IEnumerable<BCardDto> GetByMapMonsterId(long monsterId);

        IEnumerable<BCardDto> GetByCardId(long cardId);

        IEnumerable<BCardDto> GetByItemId(long itemId);
    }
}