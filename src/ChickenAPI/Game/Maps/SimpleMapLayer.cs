using System;
using System.Collections.Generic;
using System.Linq;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Monster;
using ChickenAPI.Game.Entities.Npc;
using ChickenAPI.Game.Systems.Visibility;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMapLayer : EntityManagerBase, IMapLayer
    {
        public SimpleMapLayer(IMap map, IEnumerable<MapNpcMonsterDto> npcs)
        {
            Id = Guid.NewGuid();
            Map = map;
            ParentEntityManager = map;
            Players = new List<IPlayerEntity>();
            NotifiableSystems = new Dictionary<Type, INotifiableSystem>
            {
                { typeof(VisibilitySystem), new VisibilitySystem(this) }
            };
            foreach (MapNpcMonsterDto npc in npcs)
            {
                switch (npc.Type)
                {
                    case EntityType.Npc:
                        RegisterEntity(new NpcEntity(npc));
                        break;
                    case EntityType.Monster:
                      RegisterEntity(new MonsterEntity(npc));
                        break;
                    default:
                        break;
                }
            }

        }
        public Guid Id { get; set; }
        public IMap Map { get; }
        public IReadOnlyCollection<IPlayerEntity> Players { get; }
        public IEnumerable<IEntity> GetEntitiesByType(EntityType type) => Entities.Where(s => s.Type == type);

        public IEnumerable<IEntity> GetEntitiesInRange(Position<short> pos, int range) => Entities.Where(e => e.HasComponent<MovableComponent>() && PositionHelper.GetDistance(pos, e.GetComponent<MovableComponent>().Actual) < range);
    }
}