using System.Collections;
using System.Collections.Generic;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;

namespace ChickenAPI.ECS.Contexts
{
    /// <summary>
    /// Contains entities and sub <see cref="IContext"/>
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// Gets the parent context, returns null if none
        /// </summary>
        IContext ParentContext { get; }

        /// <summary>
        /// Get all entities
        /// </summary>
        IReadOnlyList<IEntity> Entities { get; }


        IReadOnlyList<ISystem> Systems { get; }


        /// <summary>
        /// Gets the child contexts, returns null if none
        /// </summary>
        IEnumerable<IContext> ChildContexts { get; }

        /// <summary>
        /// Add a child context to the actual context
        /// </summary>
        /// <param name="context"></param>
        void AddChildContext(IContext context);

        /// <summary>
        /// Remove the child context from the actual context
        /// </summary>
        /// <param name="context"></param>
        void RemoveChildContext(IContext context);

        /// <summary>
        /// Register Entity by its context
        /// </summary>
        /// <param name="entity"></param>
        void RegisterEntity(IEntity entity);

        /// <summary>
        /// Remove entity from the context
        /// </summary>
        /// <param name="entity"></param>
        void UnregisterEntity(IEntity entity);

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <typeparam name="TEntity">Entity concrete type.</typeparam>
        /// <returns>New entity</returns>
        TEntity CreateEntity<TEntity>() where TEntity : class, IEntity;

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        /// <returns>Deleted state</returns>
        bool DeleteEntity(IEntity entity);

        /// <summary>
        /// Finds an entity by his id.
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>The found entity</returns>
        T FindEntity<T>(long id) where T : IEntity;

        /// <summary>
        /// Starts the context update.
        /// </summary>
        /// <param name="delay"></param>
        void StartSystemUpdate(int delay);

        /// <summary>
        /// Stops the context update.
        /// </summary>
        void StopSystemUpdate();

        /// <summary>
        /// Adds a new system to the context.
        /// </summary>
        /// <param name="system">System</param>
        void AddSystem(ISystem system);

        /// <summary>
        /// Removes a system from the context.
        /// </summary>
        /// <param name="system"></param>
        void RemoveSystem(ISystem system);

        /// <summary>
        /// Notify a system of this context to be executed.
        /// </summary>
        /// <typeparam name="T">System type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="e">Arguments</param>
        void NotifySystem<T>(IEntity entity, SystemEventArgs e) where T : class, INotifiableSystem;
    }
}