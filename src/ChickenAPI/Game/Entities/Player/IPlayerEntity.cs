using System.Collections.Generic;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Game.Network;
using ChickenAPI.Packets;

namespace ChickenAPI.Game.Entities.Player
{
    public interface IPlayerEntity : IEntity
    {
        ISession Session { get; }
        void SendPacket(IPacket packetBase);
        void SendPackets(IEnumerable<IPacket> packets);
    }
}