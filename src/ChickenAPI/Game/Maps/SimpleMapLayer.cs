using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Systems.Visibility;
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
            _notifiableSystems = new Dictionary<Type, INotifiableSystem>
            {
                { typeof(VisibilitySystem), new VisibilitySystem(this) }
            };
        }
        public Guid Id { get; set; }
        public IMap Map { get; }
        public IReadOnlyCollection<IPlayerEntity> Players { get; }
        public IEnumerable<IEntity> GetEntitiesByType(EntityType type) => Entities.Where(s => s.Type == type);

        public IEnumerable<IEntity> GetEntitiesInRange(Position<short> pos, int range) => Entities.Where(e => e.HasComponent<MovableComponent>() && PositionHelper.GetDistance(pos, e.GetComponent<MovableComponent>().Actual) < range);
    }
}