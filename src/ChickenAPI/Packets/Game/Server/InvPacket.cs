using System.Collections.Generic;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("inv_wear_subpacket")]
    public class InvPacketItem : PacketBase
    {
        [PacketIndex(0)]
        public short InventorySlot { get; set; }

        [PacketIndex(1)]
        public long ItemVNum { get; set; }

        [PacketIndex(2)]
        public short Rare { get; set; }

        [PacketIndex(3)]
        public short Upgrade { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; } // looks like always 0
    }

    [PacketHeader("inv_main_subpacket")]
    public class InvPacketMain : PacketBase
    {
        [PacketIndex(0)]
        public short InventorySlot { get; set; }

        [PacketIndex(1)]
        public long ItemVNum { get; set; }

        [PacketIndex(2)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; } = 0; // seems to always be 0 
    }

    [PacketHeader("inv")]
    public class InvPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1, SpecialSeparator = " ")]
        public IEnumerable<InvPacketItem> Wearables { get; set; }

        public IEnumerable<InvPacketMain> Main { get; set; }
    }
}