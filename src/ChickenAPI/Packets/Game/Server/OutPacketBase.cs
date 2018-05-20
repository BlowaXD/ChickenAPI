using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("out")]
    public class OutPacketBase : PacketBase
    {
        public OutPacketBase(IPlayerEntity entity)
        {
            Type = VisualType.Character;
            EntityId = entity.GetComponent<CharacterComponent>().Id;
        }

        public VisualType Type { get; set; }

        public long EntityId { get; set; }
    }
}