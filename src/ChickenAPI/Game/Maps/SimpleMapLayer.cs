using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Components;
using ChickenAPI.Utils;

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
        public IEnumerable<IEntity> GetEntitiesByType(EntityType type) => Entities.Where(s => s.Type == type);

        public IEnumerable<IEntity> GetEntitiesInRange(Position<short> pos, int range) => Entities.Where(e => e.HasComponent<MovableComponent>() && GetDistance(pos, e.GetComponent<MovableComponent>().Actual) < range);

        public static int GetDistance(Position<short> current, Position<short> target)
        {
            return Math.Abs(current.X - target.X) + Math.Abs(current.Y - target.Y);
        }
    }
}