namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("inv_wear_subpacket")]
    public class InvPacketItem : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public short InventorySlot { get; set; }

        [PacketIndex(1, SpecialSeparator = ".")]
        public long ItemVNum { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public short Rare { get; set; }

        [PacketIndex(3, SpecialSeparator = ".")]
        public short Upgrade { get; set; }

        [PacketIndex(4, SpecialSeparator = ".")]
        public byte Unknown { get; set; }
    }
}