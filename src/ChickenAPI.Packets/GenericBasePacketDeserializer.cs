using System;

namespace ChickenAPI.Packets
{
    public abstract class GenericBasePacketDeserializer<TPacket> : IPacketDeserializer where TPacket : IPacket
    {
        /// <summary>
        /// if the packet has a # at the beginning, it's a "returned packet"
        /// </summary>
        protected virtual bool IsReturnablePacket => false;

        protected abstract string Header { get; }

        public IPacket Deserialize(string buffer)
        {
            if (IsReturnablePacket && buffer.StartsWith($"#{Header}"))
            {
                return DeserializeImpl(buffer.Substring(buffer.IndexOf(Header, StringComparison.Ordinal)), true);
            }

            if (!buffer.StartsWith(Header))
            {
                throw new ArgumentException($"{Header} is expected to deserialize {typeof(TPacket)}");
            }

            return DeserializeImpl(buffer.Substring(buffer.IndexOf(Header, StringComparison.Ordinal)), false);
        }

        protected abstract TPacket DeserializeImpl(string bufferWithoutHeader, bool isReturnPacket);
    }
}