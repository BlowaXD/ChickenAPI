namespace ChickenAPI.Packets.Serialization.Deserializers
{
    public class DefaultPacketDeserializer : IPacketDeserializer
    {
        /// <summary>
        /// This factory will be used for optimization purposes, Activator.CreateInstance is slow and some workaround can be used to create object much faster
        /// </summary>
        private readonly IObjectFactory _factory;

        public DefaultPacketDeserializer(IObjectFactory factory)
        {
            _factory = factory;
        }

        public IPacket Deserialize(string buffer)
        {
            // todo PROPER implementation
            return null;
        }
    }
}