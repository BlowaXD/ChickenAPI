using System;
using System.Collections.Generic;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Entities.Npc
{
    public class NpcEntity : EntityBase
    {
        public NpcEntity() : base(EntityType.Npc)
        {
            Components = new Dictionary<Type, IComponent>
            {
                { typeof(BattleComponent), new BattleComponent(this) },
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                { typeof(MovableComponent), new MovableComponent(this) }
            };
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}