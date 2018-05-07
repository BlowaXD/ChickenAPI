using System.Collections.Generic;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities;
using ChickenAPI.Session;

namespace ChickenAPI.Game.Maps
{
    public interface IMapLayer
    {
        /// <summary>
        /// Get the base map of the layer
        /// </summary>
        IMap Map { get; }
        Dictionary<int, ISession> Sessions { get; }
        Dictionary<long, IEntity> Entities { get; }

        /// <summary>
        /// Returns all entities with the same type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IEnumerable<IEntity> GetEntitiesByType(EntityType type);

        /// <summary>
        /// Get all entities in the area between X and Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        IEnumerable<IEntity> GetEntitiesInRange(int x, int y);
    }
}