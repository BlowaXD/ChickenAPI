using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class CharacterComponent : IComponent
    {
        public CharacterComponent(IEntity entity) => Entity = entity;

        public long Id { get; set; }
        public byte Slot { get; set; }

        public IEntity Entity { get; }
    }
}