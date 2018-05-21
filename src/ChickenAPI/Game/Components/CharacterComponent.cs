using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Game.Components
{
    public class CharacterComponent : IComponent
    {
        public CharacterComponent(IEntity entity) => Entity = entity;

        public short Compliment { get; set; }

        public ReputationIconType ReputIcon { get; set; }

        public int Reputation { get; set; }

        public AuthorityType Authority { get; set; }

        public long Id { get; set; }

        public short MapId { get; set; }

        public byte Slot { get; set; }

        public CharacterClassType Class { get; set; }

        public GenderType Gender { get; set; }

        public HairColorType HairColor { get; set; }

        public HairStyleType HairStyle { get; set; }

        public bool ArenaWinner { get; set; }

        public short Morph { get; set; }

        public IEntity Entity { get; }
    }
}