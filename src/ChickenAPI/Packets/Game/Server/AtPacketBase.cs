using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Maps;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("at")]
    public class AtPacketBase : PacketBase
    {
        public AtPacketBase(IPlayerEntity entity)
        {
            var character = entity.GetComponent<CharacterComponent>();
            var layer = (IMapLayer)entity.EntityManager;
            

            CharacterId = character.Id;
            MapId = character.MapId;
            PositionX = entity.GetComponent<MovableComponent>().Actual.X;
            PositionY = entity.GetComponent<MovableComponent>().Actual.Y;
            Unknown1 = 2; // TODO: Find signification
            Unknown2 = 0; // TODO: Find signification
            Music = layer.Map.MusicId;
            Unknown3 = -1; // TODO: Find signification
        }

        #region Properties

        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public short MapId { get; set; }

        [PacketIndex(2)]
        public short PositionX { get; set; }

        [PacketIndex(3)]
        public short PositionY { get; set; }

        [PacketIndex(4)]
        public byte Unknown1 { get; set; }

        [PacketIndex(5)]
        public byte Unknown2 { get; set; }

        [PacketIndex(6)]
        public int Music { get; set; }

        [PacketIndex(7)]
        public short Unknown3 { get; set; }
        #endregion
    }
}
