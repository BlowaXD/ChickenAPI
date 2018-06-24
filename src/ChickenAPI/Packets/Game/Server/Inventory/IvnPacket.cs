using System.Collections.Generic;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("ivn")]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public long ItemId { get; set; }

        [PacketIndex(3, SpecialSeparator = ".")]
        public short Rare { get; set; }

        [PacketIndex(4, SpecialSeparator = ".", IsOptional = true)]
        public short? Upgrade { get; set; }

        [PacketIndex(5, SpecialSeparator = ".", IsOptional = true)]
        public short SpStoneUpgrade { get; set; } = 0; // seems to always be 0 
    }
}