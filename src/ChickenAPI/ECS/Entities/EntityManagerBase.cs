using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets;
using ChickenAPI.Utils;

namespace ChickenAPI.ECS.Entities
{
    public abstract class EntityManagerBase : IEntityManager
    {
        protected static readonly Logger Log = Logger.GetLogger<EntityManagerBase>();
        protected bool Update;
        protected long LastEntityId;
        protected Dictionary<long, IEntity> _entities = new Dictionary<long, IEntity>();

        protected List<IEntityManager> EntityManagers = new List<IEntityManager>();


        protected Dictionary<Type, INotifiableSystem> NotifiableSystems = new Dictionary<Type, INotifiableSystem>();
        protected List<ISystem> _systems = new List<ISystem>();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEntityManager ParentEntityManager { get; protected set; }
        public IReadOnlyList<ISystem> Systems => _systems;
        public IEnumerable<IEntityManager> ChildEntityManagers => EntityManagers;

        public virtual void AddChildEntityManager(IEntityManager entityManager)
        {
            EntityManagers.Add(entityManager);
        }

        public virtual void RemoveChildEntityManager(IEntityManager entityManager)
        {
            EntityManagers.Remove(entityManager);
        }

        public long NextEntityId => ++LastEntityId;
        public IEnumerable<IEntity> Entities => _entities.Values.AsEnumerable();

        public TEntity CreateEntity<TEntity>() where TEntity : class, IEntity, new()
        {
            var entity = new TEntity();
            RegisterEntity(entity);
            return entity;
        }

        public IEntity GetEntity(long id)
        {
            return !_entities.TryGetValue(id, out IEntity entity) ? null : entity;
        }

        public T GetEntity<T>(long id) where T : class, IEntity
        {
            return !_entities.TryGetValue(id, out IEntity entity) ? null : entity as T;
        }

        public void RegisterEntity<T>(T entity) where T : IEntity
        {
            entity.Id = NextEntityId;
            _entities[entity.Id] = entity;
        }

        public void UnregisterEntity<T>(T entity) where T : IEntity
        {
            _entities.Remove(entity.Id);
        }

        public bool HasEntity(IEntity entity) => HasEntity(entity.Id);

        public bool HasEntity(long id) => _entities.ContainsKey(id);

        public bool DeleteEntity(IEntity entity) => _entities.Remove(entity.Id);

        public void TransferEntity(long id, IEntityManager manager)
        {
            if (!_entities.TryGetValue(id, out IEntity entity))
            {
                return;
            }

            TransferEntity(entity, manager);
        }

        public void TransferEntity(IEntity entity, IEntityManager manager)
        {
            UnregisterEntity(entity);
            manager.RegisterEntity(entity);
            entity.TransferEntity(manager);
        }

        public void StartSystemUpdate(int delay)
        {
            // todo tick system
            Update = true;
        }

        public void StopSystemUpdate()
        {
            Update = false;
        }

        public void AddSystem(ISystem system)
        {
            _systems.Add(system);
        }

        public void RemoveSystem(ISystem system)
        {
            _systems.Remove(system);
        }

        public void NotifySystem<T>(IEntity entity, SystemEventArgs e) where T : class, INotifiableSystem
        {
            try
            {
                NotifiableSystems[typeof(T)].Execute(entity, e);
            }
            catch (Exception exception)
            {
                Log.Error("[NOTIFY_SYSTEM]", exception);
                Console.WriteLine(exception);
                throw;
            }
        }

        public void Broadcast<T>(T packet) where T : IPacket
        {
            foreach (IEntity entity in _entities.Values.AsParallel().Where(s => s.Type == EntityType.Player))
            {
                if (!(entity is IPlayerEntity session))
                {
                    continue;
                }

                session.SendPacket(packet);
            }
        }
    }
}