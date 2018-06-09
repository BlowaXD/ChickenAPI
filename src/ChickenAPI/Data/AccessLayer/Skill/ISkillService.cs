using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer.Skill
{
    public interface ISkillService : IMappedRepository<SkillDto>
    {
    }
}