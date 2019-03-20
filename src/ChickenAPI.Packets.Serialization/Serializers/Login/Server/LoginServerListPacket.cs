using System.Collections.Generic;
using ChickenAPI.Enums.Game.Character;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.Serializers.Login.Server
{
    [PacketHeader("NsTeST")]
    public class LoginServerListPacket : PacketBase
    {
        [PacketIndex(0)]
        public string AccountName { get; set; }

        [PacketIndex(1)]
        public int SessionId { get; set; }

        [PacketIndex(2, SeparatorNestedElements = " ")]
        public List<ChannelInfo> Channels { get; set; }

        public class ChannelInfo
        {
            [PacketIndex(0)]
            public string IpAddress { get; set; }

            [PacketIndex(1, SeparatorBeforeProperty = ":")]
            public ushort Port { get; set; }

            [PacketIndex(2, SeparatorBeforeProperty = ":")]
            public ChannelColor ChannelColor { get; set; }

            [PacketIndex(3, SeparatorBeforeProperty = ":")]
            public ushort ChannelGroupId { get; set; }

            [PacketIndex(4, SeparatorBeforeProperty = ".")]
            public ushort ChannelId { get; set; }

            /// <summary>
            /// Also commonly named
            /// </summary>
            [PacketIndex(5, SeparatorBeforeProperty = ".")]
            public string ChannelGroupName { get; set; }
        }
    }
}