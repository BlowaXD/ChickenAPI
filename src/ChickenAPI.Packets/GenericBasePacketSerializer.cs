using System;

namespace ChickenAPI.Packets
{
    public abstract class GenericBasePacketSerializer<TPacket> : IPacketSerializer where TPacket : IPacket
    {
        public string Serialize(IPacket packet)
        {
            if (packet is TPacket pack)
            {
                return SerializeImpl(pack);
            }

            throw new ArgumentException($"Expected packet type : {typeof(TPacket).FullName}");
        }

        protected abstract string SerializeImpl(TPacket packet);
    }
}