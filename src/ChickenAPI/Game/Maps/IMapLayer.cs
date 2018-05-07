using System.Collections.Generic;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities;
using ChickenAPI.Session;

namespace ChickenAPI.Game.Maps
{
    public interface IMapLayer
    {
        IMap Map { get; }
        Dictionary<int, ISession> Sessions { get; }
        Dictionary<long, IEntity> Entities { get; }

        IEnumerable<IEntity> GetEntitiesByType(EntityType type);
        IEnumerable<IEntity> GetEntitiesInRange(int x, int y);
    }
}