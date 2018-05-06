namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("select", NeedCharacter = false)]
    public class SelectPacket : APacket
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}