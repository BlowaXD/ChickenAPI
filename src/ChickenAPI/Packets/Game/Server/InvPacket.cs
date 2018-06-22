using System.Collections.Generic;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("inv")]
    public class InvPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1, SpecialSeparator = " ")]
        public IEnumerable<InvPacketItem> Wearables { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public IEnumerable<InvPacketMainItem> Main { get; set; }
    }
}