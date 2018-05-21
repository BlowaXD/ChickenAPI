using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Maps
{
    public interface IMapLayer : ISynchronizedDto, IEntityManager
    {
        /// <summary>
        ///     Get the base map of the layer
        /// </summary>
        IMap Map { get; }

        IReadOnlyCollection<IPlayerEntity> Players { get; }

        /// <summary>
        ///     Returns all entities with the same type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IEnumerable<IEntity> GetEntitiesByType(EntityType type);

        /// <summary>
        ///     Get all entities in the area between X and Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        IEnumerable<IEntity> GetEntitiesInRange(Position<short> pos, int range);
    }
}