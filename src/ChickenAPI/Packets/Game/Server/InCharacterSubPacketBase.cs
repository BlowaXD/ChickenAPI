using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Packets.Game.Server
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
        public InAliveSubPacketBase InAliveSubPacketBase { get; set; }

        [PacketIndex(7)]
        public bool IsSitting { get; set; }

        [PacketIndex(8)]
        public long GroupId { get; set; }

        [PacketIndex(9)]
        public byte FairyId { get; set; }

        [PacketIndex(10)]
        public byte FairyElement { get; set; }

        [PacketIndex(11)]
        public byte Unknown1 { get; set; }

        [PacketIndex(12)]
        public byte FairyMorph { get; set; }

        [PacketIndex(13)]
        public byte Unknown2 { get; set; }

        [PacketIndex(14)]
        public long Morph { get; set; }

        [PacketIndex(15)]
        public string EquipmentRare { get; set; }

        [PacketIndex(16)]
        public long FamilyId { get; set; }

        [PacketIndex(17)]
        public string FamilyName { get; set; }

        [PacketIndex(18)]
        public short ReputationIcon { get; set; }

        [PacketIndex(19)]
        public bool Invisible { get; set; }

        [PacketIndex(20)]
        public long SpUpgrade { get; set; }

        [PacketIndex(21)]
        public FactionType Faction { get; set; }

        [PacketIndex(22)]
        public long SpDesign { get; set; }

        [PacketIndex(23)]
        public byte Level { get; set; }

        [PacketIndex(24)]
        public byte FamilyLevel { get; set; }

        [PacketIndex(25)]
        public bool ArenaWinner { get; set; }

        [PacketIndex(26)]
        public int Compliment { get; set; }

        [PacketIndex(27)]
        public short Size { get; set; }

        [PacketIndex(28)]
        public short HeroLevel { get; set; }
        #endregion
    }
}
