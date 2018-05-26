using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Character;
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
    public class CharacterEntity : IPlayerEntity
    {
        private readonly Dictionary<Type, IComponent> _components;

        public CharacterEntity(ISession session, CharacterDto dto)
        {
            Session = session;
            _components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                {
                    typeof(MovableComponent), new MovableComponent(this)
                    {
                        Actual = new Position<short>
                        {
                            X = dto.MapX,
                            Y = dto.MapY,
                        },
                        Destination = new Position<short>
                        {
                            X = dto.MapX,
                            Y = dto.MapY,
                        },
                    }
                },
                { typeof(BattleComponent), new BattleComponent(this) },
                {
                    typeof(CharacterComponent), new CharacterComponent(this)
                    {
                        Id = dto.Id,
                        Authority = session.Account.Authority,
                        ArenaWinner = dto.ArenaWinner,
                        Class = dto.Class,
                        MapId = dto.MapId,
                        Compliment = dto.Compliment,
                        Gender = dto.Gender,
                        HairColor = dto.HairColor,
                        HairStyle = dto.HairStyle,
                        ReputIcon = ReputationIconType.Beginner, // todo GetReputIcon (IAlgorithmService)
                        Reputation = dto.Reput,
                        Slot = dto.Slot
                    }
                },
                {
                    typeof(ExperienceComponent), new ExperienceComponent(this)
                    {
                        Level = dto.Level,
                        LevelXp = dto.LevelXp,
                        JobLevel = dto.JobLevel,
                        JobLevelXp = dto.JobLevelXp,
                        HeroLevel = dto.HeroLevel,
                        HeroLevelXp = dto.HeroXp,
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

        public long Id { get; set; }

        public IEntityManager EntityManager { get; set; }

        public EntityType Type => EntityType.Player;

        public void AddComponent<T>(T component) where T : IComponent
        {
            _components.Add(typeof(T), component);
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            _components.Remove(typeof(T));
        }

        public bool HasComponent<T>() where T : IComponent
        {
            return _components.ContainsKey(typeof(T));
        }

        public void TransferEntity(IEntityManager manager)
        {
            if (EntityManager == null)
            {
                EntityManager = manager;
            }
            else
            {
                EntityManager.NotifySystem<VisibilitySystem>(this, new VisibilitySetInvisibleEventArgs { Broadcast = true });
                EntityManager.TransferEntity(this, manager);
            }

            if (!(manager is IMapLayer map))
            {
                return;
            }

            map.NotifySystem<VisibilitySystem>(this, new VisibilitySetVisibleEventArgs()
            {
                Broadcast = true,
                IsChangingMapLayer = true
            });

            SendPacket(new CInfoPacketBase(this));
            SendPacket(new CModePacketBase(this));
            // eq
            // Equipment()

            SendPacket(new LevPacket(this));
            // Stat()
            SendPacket(new AtPacketBase(this));
            SendPacket(new CondPacketBase(this));
            SendPacket(new CMapPacketBase(map.Map));
            // StatChar()
            SendPacket(new InPacketBase(this));
            // Pairy()
            // Pst()
            // mates In()
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
        }

        public T GetComponent<T>() where T : class, IComponent => !_components.TryGetValue(typeof(T), out IComponent component) ? null : component as T;

        public void SendPacket(IPacket packetBase) => Session.SendPacket(packetBase);

        public void SendPackets(IEnumerable<IPacket> packets) => Session.SendPackets(packets);

        public void Dispose()
        {
            // TODO Implement a real dispose pattern
            GC.SuppressFinalize(this);
        }
    }
}