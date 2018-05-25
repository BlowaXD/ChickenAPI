namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("inv")]
    public class InvPacket : PacketBase
    {
        [PacketIndex(0)]
        public short InventoryType { get; set; }

        [PacketIndex(1)]
        public short InventorySlot { get; set; }

        [PacketIndex(2)]
        public long ItemVNum { get; set; }

        [PacketIndex(3)]
        public short Rare { get; set; }

        [PacketIndex(4)]
        public short Upgrade { get; set; }

        [PacketIndex(5)]
        public byte Unknown2 { get; set; } // looks like always 0
    }
}