namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("rest")]
    public class RestPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown1 { get; set; } // always set to 1

        [PacketIndex(1)]
        public byte Unknown2 { get; set; } // always set to 1

        [PacketIndex(2)]
        public int PlayerId { get; set; }
    }
}
