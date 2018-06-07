namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("get")]
    public class GetPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; } // seems to be always 1

        [PacketIndex(1)]
        public short CharacterID { get; set; }

        [PacketIndex(2)]
        public long DropID { get; set; }

        [PacketIndex(3)]
        public byte Unknown2 { get; set; } // seems to be always 0
    }
}
