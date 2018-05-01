using System;
using System.Collections.Generic;

namespace ChickenAPI.Dtos
{
    public class WorldServerDto
    {
        public Guid Id { get; set; }
        public short ChannelId { get; set; }
        public string WorldGroup { get; set; }
        public HashSet<PlayerSessionDto> Players { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
    }
}