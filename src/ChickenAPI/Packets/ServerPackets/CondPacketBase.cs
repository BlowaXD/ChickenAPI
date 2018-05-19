using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("cond")]
    public class CondPacketBase : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public bool NoAttack { get; set; }

        [PacketIndex(3)]
        public bool NoMove { get; set; }

        [PacketIndex(4)]
        public byte Speed { get; set; }

        #endregion
    }
}
