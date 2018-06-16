using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("eq")]
    public class EqPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public VisualType VisualType { get; set; }

        [PacketIndex(2)]
        public GenderType GenderType { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyleType { get; set; }

        [PacketIndex(3)]
        public HairColorType HairColorType { get; set; }

        [PacketIndex(4)]
        public CharacterClassType CharacterClassType { get; set; }

        [PacketIndex(5)]
        public short Hat { get; set; }

        [PacketIndex(6)]
        public short Armor { get; set; }

        [PacketIndex(7)]
        public short MainWeapon { get; set; }

        [PacketIndex(8)]
        public short SecondaryWeapon { get; set; }

        [PacketIndex(9)]
        public short Mask { get; set; }

        [PacketIndex(10)]
        public short Fairy { get; set; }

        [PacketIndex(11)]
        public short CostumeSuit { get; set; }

        [PacketIndex(12)]
        public short CostumeHat { get; set; }

        [PacketIndex(13)]
        public short WeaponSkin { get; set; }

        [PacketIndex(14)]
        public byte WeaponUpgrade { get; set; }

        [PacketIndex(15)]
        public byte WeaponRare { get; set; }

        [PacketIndex(16)]
        public byte ArmorUpgrade { get; set; }

        [PacketIndex(17)]
        public byte ArmorRare { get; set; }

    }
}
