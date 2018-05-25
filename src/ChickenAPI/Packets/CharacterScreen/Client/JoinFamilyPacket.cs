namespace ChickenAPI.Packets.CharacterScreen.Client
{
    [PacketHeader("gjoin")]
    public class JoinFamilyPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }

        #endregion
    }
}
