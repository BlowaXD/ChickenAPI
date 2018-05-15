using System;

namespace ChickenAPI.Packets
{
    public interface IPacket
    {
        string Header { get; }
    }
}