using System;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Character;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.ServerPackets
{
    /*
        $"in 
        1
        {CharacterName}
        - 
        {CharacterId}
        {PositionX}
        {PositionY}
        {Direction}
        {(Undercover ? (byte)AuthorityType.User : Authority < AuthorityType.GameMaster ? 0 : 2)}
        {(byte)Gender}
        {(byte)HairStyle}
        {color}
        {(byte)Class}
        {GenerateEqListForPacket()}
        {Math.Ceiling(Hp / HpLoad() * 100)}
        {Math.Ceiling(Mp / MpLoad() * 100)}
        {(IsSitting ? 1 : 0)}
        {(Group?.GroupType == GroupType.Group ? (long)Group?.GroupId : -1)}
        {(fairy != null ? 4 : 0)}
        {fairy?.Item.Element ?? 0}
        0 // ???
        {fairy?.Item.Morph ?? 0}
        0 // ??
        {(UseSp || IsVehicled ? Morph : 0)}
        {GenerateEqRareUpgradeForPacket()}
        {(foe ? -1 : Family?.FamilyId ?? -1)}
        {(foe ? name : Family?.Name ?? "-")}
        {(GetDignityIco() == 1 ? GetReputIco() : -GetDignityIco())}
        {(Invisible ? 1 : 0)}
        {(UseSp ? MorphUpgrade : 0)}
        {faction}
        {(UseSp ? MorphUpgrade2 : 0)}
        {Level}
        {Family?.FamilyLevel ?? 0}
        {ArenaWinner}
        {(Authority == AuthorityType.Moderator ? 500 : Compliment)}
        {Size} 
        {HeroLevel}";
    */
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
                Gender = character.Gender,
                HairStyle = character.HairStyle,
                HairColor = character.HairColor,
                Class = character.Class,
                Equipment = str.Substring(0, 0b101111), // str.Length - 1 will call to length and so its much slower KAPPAAAAAAAAAAAA,
                InAliveSubPacketBase = new InAliveSubPacketBase
                {
                    HpPercentage = (byte)Math.Ceiling(battle.Hp / battle.HpMax * 100D),
                    MpPercentage = (byte)Math.Ceiling(battle.Mp / battle.MpMax * 100D)
                },
                IsSitting = false,
                GroupId = -1,
                FairyId = 0,
                FairyElement = 0,
                Unknown1 = 0,
                FairyMorph = 0,
                Unknown2 = 0,
                Morph = 0,
                EquipmentRare = "00 00",
                FamilyId = -1,
                FamilyName = "-", // if not put -1
                ReputationIcon = 0,
                Invisible = entity.GetComponent<VisibilityComponent>().IsVisible,
                SpUpgrade = 0,
                Faction = FactionType.Neutral, // todo faction system
                SpDesign = 0,
                Level = entity.GetComponent<ExperienceComponent>().Level,
                FamilyLevel = 0,
                ArenaWinner = character.ArenaWinner,
                Compliment = character.Compliment,
                Size = 10,
                HeroLevel = entity.GetComponent<ExperienceComponent>().HeroLevel
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

        [PacketIndex(9, IsOptional = true, RemoveSeparator = true)]
        public InItemSubPacketBase InItemSubPacket { get; set; }

        [PacketIndex(10, IsOptional = true, RemoveSeparator = true)]
        public InNonPlayerSubPacketBase InNonPlayerSubPacket { get; set; }

        [PacketIndex(11, IsOptional = true, RemoveSeparator = true)]
        public InOwnableSubPacketBase InOwnableSubPacket { get; set; }

        #endregion
    }
}