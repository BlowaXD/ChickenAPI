using System.Collections;
using System.Collections.Generic;
using ChickenAPI.Packets;

namespace ChickenAPI.ECS.Entities
{
    public interface IPlayerEntity : IEntity
    {
        void SendPacket(APacket packet);
        void SendPackets(IEnumerable<APacket> packets);
    }
}