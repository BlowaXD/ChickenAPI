using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Utils;

namespace ChickenAPI.ECS.Entities
{
    public abstract class EntityManagerBase : IEntityManager
    {
        protected static readonly Logger Log = Logger.GetLogger<EntityManagerBase>();
        protected bool Update;
        protected long LastEntityId;
        protected Dictionary<long, IEntity> _entities = new Dictionary<long, IEntity>();
        protected Dictionary<Type, INotifiableSystem> _notifiableSystems = new Dictionary<Type, INotifiableSystem>();
        protected List<ISystem> _systems = new List<ISystem>();
        protected List<IEntityManager> EntityManagers = new List<IEntityManager>();

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
            TEntity entity = new TEntity { Id = NextEntityId };
            RegisterEntity(entity);
            return entity;
        }

        public IEntity GetEntity(long id) => throw new System.NotImplementedException();

        public T GetEntity<T>(long id) where T : IEntity => throw new System.NotImplementedException();

        public void RegisterEntity<T>(T entity) where T : IEntity
        {
            throw new System.NotImplementedException();
        }

        public void UnregisterEntity<T>(T entity) where T : IEntity
        {
            throw new System.NotImplementedException();
        }

        public bool HasEntity(IEntity entity) => HasEntity(entity.Id);

        public bool HasEntity(long id) => _entities.ContainsKey(id);

        public bool DeleteEntity(IEntity entity) => _entities.Remove(entity.Id);

        public void TransferEntity(long id, IEntityManager manager)
        {
            throw new System.NotImplementedException();
        }

        public void TransferEntity(IEntity entity, IEntityManager manager)
        {
            throw new System.NotImplementedException();
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
                _notifiableSystems[typeof(T)].Execute(entity, e);
            }
            catch (Exception exception)
            {
                Log.Error("[NOTIFY_SYSTEM]", exception);
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}