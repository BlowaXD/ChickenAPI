namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("inv_main_subpacket")]
    public class InvPacketMainItem : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public short InventorySlot { get; set; }

        [PacketIndex(1, SpecialSeparator = ".")]
        public long ItemVNum { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public short Amount { get; set; }

        [PacketIndex(3, SpecialSeparator = ".")]
        public short Unknown { get; set; } = 0; // seems to always be 0 
    }
}