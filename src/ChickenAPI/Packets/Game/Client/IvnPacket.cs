using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("ivn")]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1)]
        public short InventorySlot { get; set; }

        [PacketIndex(2)]
        public long ItemVNum { get; set; }

        [PacketIndex(3)]
        public short Rare { get; set; }

        [PacketIndex(4)]
        public short Upgrade { get; set; }

        [PacketIndex(5)]
        public byte Unknown { get; set; } // looks like always 0
    }
}