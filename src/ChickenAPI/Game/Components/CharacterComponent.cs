using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class CharacterComponent : IComponent
    {
        public CharacterComponent(IEntity entity)
        {
            Entity = entity;
        }

        public IEntity Entity { get; }

        public long Id { get; set; }
        public byte Slot { get; set; }
    }
}