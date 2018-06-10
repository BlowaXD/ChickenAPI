using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Character;

namespace ChickenAPI.Data.AccessLayer.Character
{
    public interface ICharacterSkillService : ISynchronizedRepository<CharacterSkillDto>
    {
        
    }
}