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
        }
        public IEntity Entity { get; }

        public short Vnum { get; set; }
    }
}