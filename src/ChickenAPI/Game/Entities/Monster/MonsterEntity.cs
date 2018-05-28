using System;
using System.Collections.Generic;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Entities.Monster
{
    public class MonsterEntity : EntityBase
    {
        public MonsterEntity() : base(EntityType.Monster)
        {
            Components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                { typeof(BattleComponent), new BattleComponent(this) },
                { typeof(MovableComponent), new MovableComponent(this) }
            };
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}