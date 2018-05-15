using ChickenAPI.Enums.Packets;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("out")]
    public class OutPacketBase : PacketBase
    {
        public OutPacketType Type { get; set; }

        public long EntityId { get; set; }
    }
}