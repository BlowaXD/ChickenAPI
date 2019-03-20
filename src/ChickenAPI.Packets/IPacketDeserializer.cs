namespace ChickenAPI.Packets
{
    public interface IPacketDeserializer
    {
        IPacket Deserialize(string buffer);
    }
}