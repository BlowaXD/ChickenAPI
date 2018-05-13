﻿using System.Collections.Generic;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;

namespace ChickenAPI.Game.Maps
{
    public interface IMapLayer : ISynchronizedDto, IContext
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
        /// <param name="range"></param>
        /// <returns></returns>
        IEnumerable<IEntity> GetEntitiesInRange(int x, int y, int range);
    }
}