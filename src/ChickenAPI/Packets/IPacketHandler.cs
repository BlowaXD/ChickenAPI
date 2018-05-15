using System;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Packets
{
    public interface IPacketHandler
    {
        void Register(PacketHandlerMethodReference method);
        PacketHandlerMethodReference GetPacketHandlerMethodReference(string header);
        void Handle(IPacket packetBase, ISession session, Type type);
    }
}