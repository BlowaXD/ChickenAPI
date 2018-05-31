using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Entities.Monster
{
    public class MonsterEntity : EntityBase
    {
        public MonsterEntity(MapNpcMonsterDto dto) : base(EntityType.Monster)
        {
            Components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                { typeof(BattleComponent), new BattleComponent(this) },
                { typeof(MovableComponent), new MovableComponent(this) },
                { typeof(NpcMonsterComponent), new NpcMonsterComponent(this, dto) }
            };
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}