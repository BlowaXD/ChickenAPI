using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("c_mode")]
    public class CModePacketBase : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Morph { get; set; }

        [PacketIndex(3)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(4)]
        public byte MorphDesign { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public byte MorphBonus { get; set; }

        #endregion
    }
}
