namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("Char_DEL")]
    public class CharacterDeletePacket : APacket
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Password { get; set; }
    }
}