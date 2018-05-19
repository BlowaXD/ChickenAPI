using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in_alive_subpacket")]
    public class InAliveSubPacketBase : PacketBase
    {
        #region Properties
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public int Mp { get; set; }

        #endregion
    }
}
