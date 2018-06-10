using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects.Character;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Maps;
using ChickenAPI.Game.Network;
using ChickenAPI.Game.Systems.Visibility;
using ChickenAPI.Packets;
using ChickenAPI.Packets.Game.Server;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Entities.Player
{
    public class PlayerEntity : EntityBase, IPlayerEntity
    {
        public PlayerEntity(ISession session, CharacterDto dto) : base(EntityType.Player)
        {
            Session = session;
            Components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                {
                    typeof(MovableComponent), new MovableComponent(this)
                    {
                        Actual = new Position<short>
                        {
                            X = dto.MapX,
                            Y = dto.MapY
                        },
                        Destination = new Position<short>
                        {
                            X = dto.MapX,
                            Y = dto.MapY
                        }
                    }
                },
                { typeof(BattleComponent), new BattleComponent(this, dto) },
                { typeof(CharacterComponent), new CharacterComponent(this, dto) },
                {
                    typeof(ExperienceComponent), new ExperienceComponent(this)
                    {
                        Level = dto.Level,
                        LevelXp = dto.LevelXp,
                        JobLevel = dto.JobLevel,
                        JobLevelXp = dto.JobLevelXp,
                        HeroLevel = dto.HeroLevel,
                        HeroLevelXp = dto.HeroXp
                    }
                },
                { typeof(FamilyComponent), new FamilyComponent(this) },
                { typeof(InventoryComponent), new InventoryComponent(this) },
                {
                    typeof(NameComponent), new NameComponent(this)
                    {
                        Name = dto.Name
                    }
                },
                { typeof(SpecialistComponent), new SpecialistComponent(this) }
            };
        }

        public ISession Session { get; }

        public override void TransferEntity(IEntityManager manager)
        {
            EntityManager?.NotifySystem<VisibilitySystem>(this, new VisibilitySetInvisibleEventArgs { Broadcast = true, IsChangingMapLayer = true });
            base.TransferEntity(manager);

            if (!(manager is IMapLayer map))
            {
                return;
            }

            SendPacket(new CInfoPacketBase(this));
            SendPacket(new CModePacketBase(this));
            // eq
            // Equipment()

            SendPacket(new LevPacket(this));
            SendPacket(new StatPacket(this));
            SendPacket(new StPacket(this));
            SendPacket(new AtPacketBase(this));
            SendPacket(new CondPacketBase(this));
            SendPacket(new CMapPacketBase(map.Map));
            // StatChar()
            SendPacket(new InPacketBase(this));
            // Pairy()
            // Pst()
            // Act6() : Act()
            // PInitPacket
            // ScPacket
            // ScpStcPacket
            // FcPacket
            // Act4Raid ? DgPacket() : RaidMbf
            // MapDesignObjects()
            // MapDesignObjectsEffects
            // MapItems()
            // Gp()
            EntityManager.NotifySystem<VisibilitySystem>(this, new VisibilitySetVisibleEventArgs
            {
                Broadcast = true,
                IsChangingMapLayer = true
            });
        }

        public void SendPacket<T>(T packetBase) where T : IPacket => Session.SendPacket(packetBase);

        public void SendPackets(IEnumerable<IPacket> packets) => Session.SendPackets(packets);

        private void Save()
        {
            Log.Info($"[SAVE_START] {Session.Account.Name}");
        }

        public override void Dispose()
        {
            Save();
            GC.SuppressFinalize(this);
        }
    }
}