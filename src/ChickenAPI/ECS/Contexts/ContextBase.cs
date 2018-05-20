using System;
using System.Collections.Generic;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;

namespace ChickenAPI.ECS.Contexts
{
    public class ContextBase : IContext
    {
        public ContextBase()
        {

        }

        public IContext ParentContext { get; }

        public IReadOnlyList<IEntity> Entities { get; }

        public IReadOnlyList<ISystem> Systems { get; }

        public IEnumerable<IContext> ChildContexts { get; }

        public void AddChildContext(IContext context)
        {
            throw new NotImplementedException();
        }

        public void RemoveChildContext(IContext context)
        {
            throw new NotImplementedException();
        }

        public void RegisterEntity(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UnregisterEntity(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity CreateEntity<TEntity>() where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public T FindEntity<T>(long id) where T : IEntity
        {
            throw new NotImplementedException();
        }

        public void StartSystemUpdate(int delay)
        {
            throw new NotImplementedException();
        }

        public void StopSystemUpdate()
        {
            throw new NotImplementedException();
        }

        public void AddSystem(ISystem system)
        {
            throw new NotImplementedException();
        }

        public void RemoveSystem(ISystem system)
        {
            throw new NotImplementedException();
        }

        public void NotifySystem<T>(IEntity entity, SystemEventArgs e) where T : class, INotifiableSystem
        {
            throw new NotImplementedException();
        }
    }
}