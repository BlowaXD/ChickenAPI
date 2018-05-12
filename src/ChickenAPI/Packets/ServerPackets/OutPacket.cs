using ChickenAPI.Enums.Packets;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("out")]
    public class OutPacket : APacket
    {
        public OutPacketType Type { get; set; }

        public long EntityId { get; set; }
    }
}