using System.Collections.Generic;
using ChickenAPI.ECS.Systems;

namespace ChickenAPI.ECS.Entities
{
    public abstract class EntityManagerBase : IEntityManager
    {
        protected long LastEntityId;
        protected List<IEntity> _entities = new List<IEntity>();
        protected IReadOnlyList<ISystem> _systems = new List<ISystem>();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEntityManager ParentEntityManager { get; protected set; }
        public IReadOnlyList<ISystem> Systems => _systems;
        public IEnumerable<IEntityManager> ChildEntityManagers { get; }

        public virtual void AddChildEntityManager(IEntityManager entityManager)
        {
            throw new System.NotImplementedException();
        }

        public virtual void RemoveChildEntityManager(IEntityManager entityManager)
        {
            throw new System.NotImplementedException();
        }

        public long NextEntityId => ++LastEntityId;
        public IReadOnlyCollection<IEntity> Entities => _entities;
        public TEntity CreateEntity<TEntity>() where TEntity : class, IEntity => throw new System.NotImplementedException();

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

        public bool HasEntity(IEntity entity) => throw new System.NotImplementedException();

        public bool HasEntity(long id) => throw new System.NotImplementedException();

        public bool DeleteEntity(IEntity entity) => throw new System.NotImplementedException();

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
            throw new System.NotImplementedException();
        }

        public void StopSystemUpdate()
        {
            throw new System.NotImplementedException();
        }

        public void AddSystem(ISystem system)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveSystem(ISystem system)
        {
            throw new System.NotImplementedException();
        }

        public void NotifySystem<T>(IEntity entity, SystemEventArgs e) where T : class, INotifiableSystem
        {
            throw new System.NotImplementedException();
        }
    }
}