using System.Collections.Generic;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("ivn")]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1, SpecialSeparator = " ")]
        public IEnumerable<IvnPacketItem> Wearables { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public IEnumerable<InvPacketMainItem> Main { get; set; }
    }
}