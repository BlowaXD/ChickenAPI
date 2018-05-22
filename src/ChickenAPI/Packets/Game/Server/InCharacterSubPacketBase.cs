using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in_character_subpacket")]
    public class InCharacterSubPacketBase : PacketBase
    {
        #region Properties
        [PacketIndex(0)]
        public byte Authority { get; set; }

        [PacketIndex(1)]
        public GenderType Gender { get; set; }

        [PacketIndex(2)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(3)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(4)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(5)]
        public string Equipment { get; set; }

        [PacketIndex(6)]
        public long FamilyId { get; set; }

        [PacketIndex(7)]
        public string FamilyName { get; set; }

        [PacketIndex(8)]
        public short ReputationIcon { get; set; }

        [PacketIndex(9)]
        public bool Invisible { get; set; }

        [PacketIndex(10)]
        public long Morph { get; set; }

        [PacketIndex(11)]
        public FactionType Faction { get; set; }

        [PacketIndex(12)]
        public long MorphDesign { get; set; }

        [PacketIndex(13)]
        public byte Level { get; set; }

        [PacketIndex(14)]
        public byte FamilyLevel { get; set; }

        [PacketIndex(15)]
        public bool ArenaWinner { get; set; }

        [PacketIndex(16)]
        public int Compliment { get; set; }

        [PacketIndex(17)]
        public short Size { get; set; }

        [PacketIndex(18)]
        public short HeroLevel { get; set; }
        #endregion
    }
}
