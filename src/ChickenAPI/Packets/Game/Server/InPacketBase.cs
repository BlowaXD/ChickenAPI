using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("in")]
    public class InPacketBase : PacketBase
    {
        public InPacketBase(IPlayerEntity entity)
        {
            var character = entity.GetComponent<CharacterComponent>();
            var battle = entity.GetComponent<BattleComponent>();

            string str = "";
            for (int i = 0; i < 16; i++)
            {
                str += "-1.";
            }

            VisualType = VisualType.Character;
            Name = entity.GetComponent<NameComponent>().Name;
            VNum = character.Id;
            PositionX = entity.GetComponent<MovableComponent>().Actual.X;
            PositionY = entity.GetComponent<MovableComponent>().Actual.Y;
            Direction = entity.GetComponent<MovableComponent>().Direction;
            InCharacterSubPacket = new InCharacterSubPacketBase
            {
                Authority = entity.Session.Account.Authority > AuthorityType.GameMaster ? (byte)2 : (byte)0,
                Class = character.Class,
                Equipment = str.Substring(0, 0b101111), // str.Length - 1 will call to length and so its much slower KAPPAAAAAAAAAAAA
                Gender = character.Gender,
                HairColor = character.HairColor,
                HairStyle = character.HairStyle,
            };
            InAliveSubPacket = new InAliveSubPacketBase
            {
                HpPercentage = battle.Hp / battle.HpMax * 100,
                MpPercentage = battle.Mp / battle.MpMax * 100,
            };
        }

        #region Properties

        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public long VNum { get; set; }

        [PacketIndex(3)]
        public short PositionX { get; set; }

        [PacketIndex(4)]
        public short PositionY { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public Direction? Direction { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public short? Amount { get; set; }

        [PacketIndex(7, IsOptional = true, RemoveSeparator = true)]
        public InCharacterSubPacketBase InCharacterSubPacket { get; set; }

        [PacketIndex(8, IsOptional = true, RemoveSeparator = true)]
        public InAliveSubPacketBase InAliveSubPacket { get; set; }

        [PacketIndex(9, IsOptional = true, RemoveSeparator = true)]
        public InItemSubPacketBase InItemSubPacket { get; set; }

        [PacketIndex(10, IsOptional = true, RemoveSeparator = true)]
        public InNonPlayerSubPacketBase InNonPlayerSubPacket { get; set; }

        [PacketIndex(11, IsOptional = true, RemoveSeparator = true)]
        public InOwnableSubPacketBase InOwnableSubPacket { get; set; }

        #endregion
    }
}