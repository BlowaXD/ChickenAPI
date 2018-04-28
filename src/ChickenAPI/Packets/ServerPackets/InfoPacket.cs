namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("info")]
    public class InfoPacket : APacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}