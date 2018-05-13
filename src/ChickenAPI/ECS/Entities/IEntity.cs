using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.Enums.Game.Entity;

namespace ChickenAPI.ECS.Entities
{
    /// <summary>
    /// Defines an entity
    /// </summary>
    public interface IEntity : IMappedDto
    {
        /// <summary>
        /// Gets the context where the Entity is registered
        /// </summary>
        IContext Context { get; }

        /// <summary>
        /// Gets the entity type
        /// </summary>
        EntityType Type { get; }

        /// <summary>
        /// Add the component to the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        void AddComponent<T>(T component) where T : IComponent;

        /// <summary>
        /// Remove the component from the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        void RemoveComponent<T>(T component) where T : IComponent;


        /// <summary>
        /// Returns if the entity contains the component of type <see cref="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        /// <returns></returns>
        bool HasComponent<T>() where T : IComponent;

        /// <summary>
        /// Get the component from the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>null in case entity does not contain the component</returns>
        T GetComponent<T>() where T : class, IComponent;
    }
}