using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in_character_subpacket")]
    public class InCharacterSubPacketBase : PacketBase
    {
        #region Properties
        [PacketIndex(0)]
        public byte Authority { get; set; }

        [PacketIndex(1)]
        public GenderType Gender { get; set; }

        [PacketIndex(2)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(3)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(4)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(5)]
        public string Equipment { get; set; }
        #endregion
    }
}
