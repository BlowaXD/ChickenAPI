namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("eq")]
    public class EqPacket : PacketBase
    {
        [PacketIndex(0)]
        public short CharacterId { get; set; }

        [PacketIndex(1)]
        public byte VisualType { get; set; }

        [PacketIndex(2)]
        public byte Gender { get; set; }

        [PacketIndex(3)]
        public byte HairStyle { get; set; }

        [PacketIndex(3)]
        public byte HairColor { get; set; }

        [PacketIndex(4)]
        public byte Class { get; set; }

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
