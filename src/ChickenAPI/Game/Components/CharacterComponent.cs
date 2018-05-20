using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Game.Components
{
    public class CharacterComponent : IComponent
    {
        public CharacterComponent(IEntity entity) => Entity = entity;

        public IEntity Entity { get; }
        public long Id { get; set; }
        public short MapId { get; set; }
        public byte Slot { get; set; }
        public CharacterClassType Class { get; set; }
        public GenderType Gender { get; set; }
        public HairColorType HairColor { get; set; }
        public HairStyleType HairStyle { get; set; }
    }
}