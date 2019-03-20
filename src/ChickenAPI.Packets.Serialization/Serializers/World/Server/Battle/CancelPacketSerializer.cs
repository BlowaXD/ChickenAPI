using ChickenAPI.Packets.Game.Server.Battle;

namespace ChickenAPI.Packets.Serializers.World.Server.Battle
{
    public class CancelPacketSerializer : GenericBasePacketSerializer<CancelPacket>
    {
        protected override string SerializeImpl(CancelPacket packet)
        {
            return $"cancel {(byte)packet.Type} {packet.TargetId}";
        }
    }
}