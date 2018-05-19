using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in")]
    public class InPacketBase : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte VisualType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public string VNum { get; set; }

        [PacketIndex(3)]
        public short PositionX { get; set; }

        [PacketIndex(4)]
        public short PositionY { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public byte? Direction { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public short? Amount { get; set; }

        [PacketIndex(7, IsOptional = true, RemoveSeparator = true)]
        public InCharacterSubPacketBase InCharacterSubPacket { get; set; }

        [PacketIndex(8, IsOptional = true, RemoveSeparator = true)]
        public InAliveSubPacketBase InAliveSubPacket { get; set; }

        [PacketIndex(9, IsOptional = true, RemoveSeparator = true)]
        public InItemSubPacketBase InItemSubPacket { get; set; }

        [PacketIndex(10, IsOptional = true, RemoveSeparator = true)]
        public InNonPlayerSubPacketBase InNonPlayerSubPacket { get; set; }

        [PacketIndex(11, IsOptional = true, RemoveSeparator = true)]
        public InOwnableSubPacketBase InOwnableSubPacket { get; set; }

        #endregion
    }
}
