using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Utils;

namespace ChickenAPI.Data.TransferObjects
{
    public class MapNpcMonsterDto : IMappedDto
    {
        public long Id { get; set; }

        public EntityType Type { get; set; }

        public Position<short> Position { get; set; }

        public long MapId { get; set; }

        public IEnumerable<DropDto> Drops { get; set; }
        public IEnumerable<BCardDto> BCards { get; set; }
        public IEnumerable<NpcMonsterSkillDto> Skills { get; set; }
        public NpcMonsterDto Data { get; set; }
    }
}