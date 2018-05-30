using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class NpcMonsterComponent : IComponent
    {
        public NpcMonsterComponent(IEntity entity, MapNpcMonsterDto dto)
        {
            Entity = entity;
            Vnum = dto.Data.Id;
            MapNpcMonsterId = dto.Id;
            MapId = dto.MapId;
        }
        public IEntity Entity { get; }

        public long Vnum { get; set; }
        public long MapNpcMonsterId { get; set; }
        public long MapId { get; set; }
    }
}