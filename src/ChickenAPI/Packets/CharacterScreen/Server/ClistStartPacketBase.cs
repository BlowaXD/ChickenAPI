namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("clist_start")]
    public class ClistStartPacketBase : PacketBase
    {
        public ClistStartPacketBase()
        {
            Type = 0; //TODO: Find signification
        }
        #region Properties

        [PacketIndex(0)]
        public byte Type { get; set; }

        #endregion
    }
}