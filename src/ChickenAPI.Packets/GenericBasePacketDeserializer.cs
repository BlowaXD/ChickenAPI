using System;

namespace ChickenAPI.Packets
{
    public abstract class GenericBasePacketDeserializer<TPacket> : IPacketDeserializer where TPacket : IPacket
    {
        protected abstract string Header { get; }

        public IPacket Deserialize(string buffer)
        {
            if (!buffer.StartsWith(Header))
            {
                throw new ArgumentException($"{Header} is expected to deserialize {typeof(TPacket)}");
            }

            return DeserializeImpl(buffer.Substring(buffer.IndexOf(Header, StringComparison.Ordinal)));
        }

        protected abstract TPacket DeserializeImpl(string buffer);
    }
}