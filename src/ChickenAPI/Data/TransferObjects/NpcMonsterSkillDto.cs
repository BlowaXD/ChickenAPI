using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class NpcMonsterSkillDto : IMappedDto
    {
        /// <summary>
        /// Can be considered as the skill vnum
        /// </summary>
        public long Id { get; set; }
        public short Rate { get; set; }
        public long NpcMonsterId { get; set; }
    }
}