namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("clist_start")]
    public class ClistStartPacket : APacket
    {
        #region Properties

        [PacketIndex(0)]
        public byte Type { get; set; }

        #endregion
    }
}