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

        public NpcMonsterDto Data { get; set; }
    }
}