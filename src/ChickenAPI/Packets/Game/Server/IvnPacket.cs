using System.Collections.Generic;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("ivn")]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1, SpecialSeparator = " ", IsOptional = true, RemoveSeparator = true)]
        public List<IvnPacketItem> Wearables { get; set; }

        [PacketIndex(2, SpecialSeparator = " ", IsOptional = true, RemoveSeparator = true)]
        public List<InvPacketMainItem> Main { get; set; }
    }
}