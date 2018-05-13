using System;
using ChickenAPI.Game;

namespace ChickenAPI.Packets
{
    public interface IPacketHandler
    {
        void Register(PacketHandlerMethodReference method);
        PacketHandlerMethodReference GetPacketHandlerMethodReference(string header);
        void Handle(APacket packet, ISession session, Type type);
    }
}