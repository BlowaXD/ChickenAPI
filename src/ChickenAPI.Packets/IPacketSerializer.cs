using System;

namespace ChickenAPI.Packets
{
    public interface IPacketSerializer
    {
        string Serialize(IPacket packet);
    }
}