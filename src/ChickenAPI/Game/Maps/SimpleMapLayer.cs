using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMapLayer : EntityManagerBase, IMapLayer
    {
        public SimpleMapLayer(IMap map)
        {
            Map = map;
            ParentEntityManager = map;
            Players = new List<IPlayerEntity>();
        }
        public Guid Id { get; set; }
        public IMap Map { get; }
        public IReadOnlyCollection<IPlayerEntity> Players { get; }
        public IEnumerable<IEntity> GetEntitiesByType(EntityType type) => _entities.Where(s => s.Type == type);

        public IEnumerable<IEntity> GetEntitiesInRange(int x, int y, int range) => throw new NotImplementedException();
    }
}