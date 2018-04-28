using System;
using System.Collections.Generic;

namespace ChickenAPI.Packets
{
    public interface IPacketFactory
    {
        string Serialize<TPacket>(TPacket packet) where TPacket : APacket;
        APacket Deserialize(string packetContent, Type packetType, bool includesKeepAliveIdentity = false);


        /// <summary>
        /// Register a packet in packet factory
        /// </summary>
        /// <param name="packetInformation"></param>
        void RegisterPacket(PacketInformation packetInformation);
        void RegisterPackets(IEnumerable<PacketInformation> packetInformations);
        void UnregisterPacket(string header);
        void UnregisterPacket(Type type);
    }
}