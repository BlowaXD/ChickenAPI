using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("pairy")]
    public class PairyPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; } // seems to be always 1

        [PacketIndex(1)]
        public short CharacterID { get; set; }

        [PacketIndex(2)]
        public byte FairyMoveType { get; set; }

        [PacketIndex(3)]
        public ElementType ElementType { get; set; }

        [PacketIndex(4)]
        public short FairyLevel { get; set; }

        [PacketIndex(5)]
        public short ItemMorph { get; set; }
    }
}
