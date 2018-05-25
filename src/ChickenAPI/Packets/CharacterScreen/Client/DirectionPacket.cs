namespace ChickenAPI.Packets.CharacterScreen.Client
{
    [PacketHeader("dir")]
    public class DirectionPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(1)]
        public int Option { get; set; }

        [PacketIndex(0)]
        public byte Direction { get; set; }

        [PacketIndex(2)]
        public long CharacterId { get; set; }

        #endregion
    }
}
