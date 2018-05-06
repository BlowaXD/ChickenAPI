using System;
using System.Collections.Generic;

namespace ChickenAPI.Packets
{
    public interface IPacketFactory
    {
        string Serialize<TPacket>(TPacket packet) where TPacket : APacket;
        APacket Deserialize(string packetContent, Type packetType, bool includesKeepAliveIdentity);
    }
}