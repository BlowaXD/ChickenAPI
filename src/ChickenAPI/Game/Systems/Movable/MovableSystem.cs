using System;
using System.Linq.Expressions;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Systems.Movable
{
    public class MovableSystem : NotifiableSystemBase
    {
        public MovableSystem(IEntityManager entityManager) : base(entityManager)
        {
        }

        protected override Expression<Func<IEntity, bool>> Filter => entity => entity.HasComponent<MovableComponent>();

        public override void Execute(IEntity entity)
        {
            var movable = entity.GetComponent<MovableComponent>();
        }

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}