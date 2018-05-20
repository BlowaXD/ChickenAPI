﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in_character_subpacket")]
    public class InCharacterSubPacketBase : PacketBase
    {
        #region Properties
        [PacketIndex(0)]
        public byte Authority { get; set; }

        [PacketIndex(1)]
        public byte Gender { get; set; }

        [PacketIndex(2)]
        public byte HairStyle { get; set; }

        [PacketIndex(3)]
        public byte HairColor { get; set; }

        [PacketIndex(4)]
        public byte Class { get; set; }

        [PacketIndex(5)]
        public byte Equipment { get; set; }
        #endregion
    }
}
