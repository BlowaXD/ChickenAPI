namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("rest")]
    public class RestPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte VisualType { get; set; } // always set to 1

        [PacketIndex(1)]
        public int EntityId { get; set; }

        [PacketIndex(2)]
        public bool Entity.IsSitting { get; set; } // always set to 0
    }
}

