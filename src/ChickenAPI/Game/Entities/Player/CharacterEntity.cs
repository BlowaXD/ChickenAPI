using System;
using System.Collections.Generic;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Network;
using ChickenAPI.Packets;

namespace ChickenAPI.Game.Entities.Player
{
    public class CharacterEntity : IPlayerEntity
    {
        private readonly Dictionary<Type, IComponent> _components;

        public CharacterEntity(ISession session)
        {
            Session = session;
            _components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) }
            };
        }

        public ISession Session { get; }

        public long Id { get; set; }

        public IEntityManager EntityManager => null;

        public EntityType Type => EntityType.Player;

        public void AddComponent<T>(T component) where T : IComponent
        {
            throw new NotImplementedException();
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            throw new NotImplementedException();
        }

        public bool HasComponent<T>() where T : IComponent => _components.ContainsKey(typeof(T));

        public void TransferEntity(IEntityManager manager)
        {
            EntityManager.TransferEntity(this, manager);
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