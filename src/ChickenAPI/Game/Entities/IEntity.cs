using System;
using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Enums.Game.Entity;

namespace ChickenAPI.Game.Entities
{
    /// <summary>
    /// Defines an entity
    /// </summary>
    public interface IEntity : IMappedDto
    {
        EntityType Type { get; }

        /// <summary>
        /// Add the component to the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        void AddComponent<T>(T component) where T : IEntityComponent;

        /// <summary>
        /// Remove the component from the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        void RemoveComponent<T>(T component) where T : IEntityComponent;

        /// <summary>
        /// Get the component from the actual <see cref="IEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>null in case entity does not contain the component</returns>
        T GetComponent<T>() where T : IEntityComponent;
    }
}