using ChickenAPI.Packets.Game.Client.Chat;

namespace ChickenAPI.Packets.Serialization.Deserializers.World.Chat
{
    public class ClientSayPacketDeserializer : GenericBasePacketDeserializer<ClientSayPacket>
    {
        protected override string Header => "say";

        protected override ClientSayPacket DeserializeImpl(string bufferWithoutHeader, bool isReturn)
        {
            return new ClientSayPacket
            {
                Header = Header,
                Message = bufferWithoutHeader
            };
        }
    }
}