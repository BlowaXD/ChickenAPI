namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("rest")]
    public class RestPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte VisualType { get; set; } // always set to 1

        [PacketIndex(1)]
        public byte VisualType { get; set; } // always set to 1

        [PacketIndex(2)]
        public int EntityId { get; set; }
    }
}
