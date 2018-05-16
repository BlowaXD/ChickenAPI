using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Game.Maps
{
    public class MapLayer : ContextBase, IMapLayer
    {
        public MapLayer(IMap map) : base()
        {
            Map = map;
            Id = Guid.NewGuid();
            Sessions = new Dictionary<int, ISession>();
            Entities = new Dictionary<long, IEntity>();
        }

        public IMap Map { get; }
        public Guid Id { get; set; }

        public Dictionary<int, ISession> Sessions { get; }
        public Dictionary<long, IEntity> Entities { get; }

        public IEnumerable<IEntity> GetEntitiesByType(EntityType type)
        {
            return Entities.Values.Where(e => e.Type == type);
        }

        public IEnumerable<IEntity> GetEntitiesInRange(short x, short y, short range)
        {
            throw new NotImplementedException();
        }
    }
}