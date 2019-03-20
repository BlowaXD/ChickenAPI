using ChickenAPI.Packets.Game.Client.Chat;

namespace ChickenAPI.Packets.Serialization.Deserializers.World.Chat
{
    public class ClientSayPacketDeserializer : GenericBasePacketDeserializer<ClientSayPacket>
    {
        protected override string Header => "say";

        protected override ClientSayPacket DeserializeImpl(string buffer)
        {
            return new ClientSayPacket
            {
                Header = Header,
                Message = buffer
            };
        }
    }
}